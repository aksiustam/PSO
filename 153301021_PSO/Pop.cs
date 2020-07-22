using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153301021_PSO
{
    class Pop
    {
        public static int penalty;
        public static int max;
        public static int min;
        public static int C;
        public static int gensize;
        

        private IList<Gen> kromozon = new List<Gen>();
        public IList<Gen> Kromozon
        {
            set { kromozon = value; }
            get { return kromozon; }
        }

        private Gen _bestgen;
        public Gen BestGen
        {
            set { _bestgen = value; }
            get { return _bestgen; }
        }
        private int poplengt;
        public Pop(int Poplength)
        {
            poplengt = Poplength;
        }


        public void ScoreAll()
        {
            
            foreach (Gen g in kromozon) // her kromozonun genine baq
            {
                g.Score = PSO.Solution(g);
                UpdatePbest(g);
                UpdateBestGenome(g);
            }
            
            

        }

        private void UpdateBestGenome(Gen g)
        {
 
                if (_bestgen == null || g.Pscore < _bestgen.Pscore)
                {
                    _bestgen = g;
                    UpdatePbest(_bestgen);
                }

            
        }

        private void UpdatePbest(Gen g)
        {

            if (g.Pbest == null)
            {
                g.Pbest = new double[g.Genes.Length];
                g.Pscore = g.Score;
            }
            if ( g.Score < g.Pscore) // 45 < 55
            {
                g.Pscore = g.Score; //  55 == 45
                for (int i = 0; i < g.Genes.Length; i++)
                {
                    g.Pbest[i] = g.Genes[i];
                }
                    // x1 x2 = g1 g2
            }
           
            
            
        }

        public void Generate()
        {

            kromozon.Clear();
            _bestgen = null;

            for (int i = 0; i < poplengt; i++)
            {
                Gen genes = PSO.GenRanGen(min, max, gensize);
                kromozon.Add(genes);

            }
        }

    }
}
