using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _153301021_PSO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_basla_Click(object sender, EventArgs e)
        {

            int pop = (int)num_pop.Value;
            double min = decimal.ToDouble(num_min.Value);
            double max = decimal.ToDouble(num_max.Value);
            double pen = decimal.ToDouble(num_pen.Value);
            double gen = decimal.ToDouble(num_gen.Value);
            double c = decimal.ToDouble(num_c.Value);
            double jen = decimal.ToDouble(num_jen.Value);

            bool kon_min = rad_min.Checked;
            


            while (chart_pso.Series.Count > 0) { chart_pso.Series.RemoveAt(0); } // Resetle

            Series series = this.chart_pso.Series.Add("Total");
            series.ChartType = SeriesChartType.Spline;
            chart_pso.Series["Total"].BorderWidth = 2;
            chart_pso.Series["Total"].Color = Color.Red;
            
            Pop p = new Pop(pop);

            //Bilgileri al
            Pop.penalty = (int)pen;
            Pop.max = (int)max;
            Pop.min = (int)min;
            Pop.gensize = (int)gen;
            Pop.C = (int)c;
            
            //Bilgileri al

            p.Generate();
            
            for (int i = 0; i < jen; i++)
            {

                p.ScoreAll();
             
                if (i % (jen / 10) == 0)
                    series.Points.AddXY(i, Math.Round(p.BestGen.Pscore, 0));
                
                p = PSO.Speed(p);

            }
            p.ScoreAll();
            listBox1.Items.Add("----------------------");
            for (int i = 0; i < p.Kromozon.Count; i++)
            {

                listBox1.Items.Add("Krom_" + (i + 1) + " Score =" + p.Kromozon[i].Score);
                listBox1.Items.Add("Krom_" + (i + 1) + " PScore = " + p.Kromozon[i].Pscore);
                listBox1.Items.Add("----------------------");
            }
            
            int j = 0;
            listBox1.Items.Add("----------------------");
            listBox1.Items.Add("BestGen_Score = " + p.BestGen.Score);
            foreach (double g in p.BestGen.Genes)
            {
                j++;
                listBox1.Items.Add("BestGen_Gen " + j + "=" + g);
            }
            listBox1.Items.Add("----------------------");
            listBox1.Items.Add("----------------------");
            listBox1.Items.Add("BestGen_PScore = " + p.BestGen.Pscore);
            j = 0;
            foreach (double g in p.BestGen.Pbest)
            {
                j++;
                listBox1.Items.Add("BestGen_PGen " + j + "=" + g);
            }
            
            

        }


    }
}
