using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153301021_PSO
{
    class PSO
    {

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static double RandomNumber(int min, int max) // Random saat tick ine göre işliyo 
        {
            lock (syncLock) // 
            { // synchronize
                return Math.Round((random.NextDouble() * (max - min) + min), Pop.penalty); // tick işlemesi çok fazla oldugundan bu kodu yazıyoz
            } // deyse sürekli aynı sayıları elde ederiz.
        }
        public static Gen GenRanGen(int min, int max, int gensize)
        {
            var sonuc = new Gen(gensize);

            for (int i = 0; i < sonuc.Genes.Length; i++)
            {

                sonuc.Genes[i] = RandomNumber(min, max);
            }
            return sonuc;
        }

        public static double Solution(Gen s)
        {
            double sonuc = 0;
            //  (4-2.1·x1^2+x1^4/3)·x1^2+x1·x2+(-4+4·x2^2)·x2^2;
            for (int i = 0; i < s.Genes.Length -1 ; i++)
            {
                double a = s.Genes[i];
                double b = s.Genes[i+1];

                double x = 4 - 2.1 * Math.Pow(a, 2) + Math.Pow(a, 4)/3;
                x = x * Math.Pow(a, 2);
                double y = a * b;
                double z = -4 + 4 * Math.Pow(b, 2);
                z = z * Math.Pow(b, 2);


                sonuc = x + y + z;
                
            }
            return Math.Round(sonuc, Pop.penalty);
        }

  

        public static Pop Sort(Pop p)
        {
            IList<Gen> list = new List<Gen>();
            list = p.Kromozon;
            IEnumerable<Gen> sortedEnum = list.OrderBy(f => f.Score);
            IList<Gen> sortedList = sortedEnum.ToList();
            p.Kromozon = sortedList;
            return p;
        }

        public static Pop Speed(Pop p)
        {
            
            foreach (Gen h in p.Kromozon)
            {
                double rand1 = Math.Round(RandomNumber(0, 1),1);
                double rand2 = Math.Round(RandomNumber(0, 1),1);
                
                if (h.Speed == null)
                {
                    h.Speed = new double[h.Genes.Length];
                    for (int i = 0; i < h.Genes.Length; i++)
                    {
                        h.Speed[i] = 0;
                    }
                }

                for (int i = 0; i < h.Genes.Length; i++)
                {
                    
                    double a = h.Pbest[i] - h.Genes[i];
                    double b = p.BestGen.Pbest[i] - h.Genes[i];
                    double son = h.Speed[i] + (Pop.C * rand1 * a) + (Pop.C * rand2 * b);
                    h.Speed[i] = son;

                    double sonuc = h.Genes[i] + son;
                    if (sonuc >= Pop.max) // -3 > 5
                        sonuc = Pop.max;

                    if (sonuc <= Pop.min)
                        sonuc = Pop.min;
                    sonuc = Math.Round(sonuc, Pop.penalty);
                    h.Genes[i] = sonuc;
                }

                
            }

            return p;
        }
        
    }
}
