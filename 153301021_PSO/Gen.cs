using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153301021_PSO
{
    class Gen
    {
        
        private double[] _genes;
        
        public Gen(int gensayı)
        {
            _genes = new double[gensayı];

        }
        public double[] Genes
        {

            get { return _genes; }
            
        }


        public double[] Pbest { get; set; }
        public double[] Speed { get; set; }
        public double Pscore { get; set; }
        public double Score { get; set; }
       
    }
}
