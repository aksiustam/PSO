namespace _153301021_PSO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_basla = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_min = new System.Windows.Forms.RadioButton();
            this.num_jen = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_c = new System.Windows.Forms.NumericUpDown();
            this.num_pen = new System.Windows.Forms.NumericUpDown();
            this.num_gen = new System.Windows.Forms.NumericUpDown();
            this.num_max = new System.Windows.Forms.NumericUpDown();
            this.num_min = new System.Windows.Forms.NumericUpDown();
            this.num_pop = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_pso = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_jen)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_gen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(705, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 342);
            this.listBox1.TabIndex = 9;
            // 
            // btn_basla
            // 
            this.btn_basla.Location = new System.Drawing.Point(288, 316);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(411, 37);
            this.btn_basla.TabIndex = 7;
            this.btn_basla.Text = "BAŞLA";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_min);
            this.groupBox2.Controls.Add(this.num_jen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 89);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonlanma Ölçütü";
            // 
            // rad_min
            // 
            this.rad_min.AutoSize = true;
            this.rad_min.Checked = true;
            this.rad_min.Location = new System.Drawing.Point(10, 29);
            this.rad_min.Name = "rad_min";
            this.rad_min.Size = new System.Drawing.Size(98, 17);
            this.rad_min.TabIndex = 2;
            this.rad_min.TabStop = true;
            this.rad_min.Text = "Minimum Nokta";
            this.rad_min.UseVisualStyleBackColor = true;
            // 
            // num_jen
            // 
            this.num_jen.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_jen.Location = new System.Drawing.Point(155, 63);
            this.num_jen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_jen.Name = "num_jen";
            this.num_jen.Size = new System.Drawing.Size(98, 20);
            this.num_jen.TabIndex = 1;
            this.num_jen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_jen.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Jenerasyon Sayısı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_c);
            this.groupBox1.Controls.Add(this.num_pen);
            this.groupBox1.Controls.Add(this.num_gen);
            this.groupBox1.Controls.Add(this.num_max);
            this.groupBox1.Controls.Add(this.num_min);
            this.groupBox1.Controls.Add(this.num_pop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 189);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // num_c
            // 
            this.num_c.Location = new System.Drawing.Point(155, 128);
            this.num_c.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.num_c.Name = "num_c";
            this.num_c.Size = new System.Drawing.Size(98, 20);
            this.num_c.TabIndex = 1;
            this.num_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_c.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // num_pen
            // 
            this.num_pen.Location = new System.Drawing.Point(155, 154);
            this.num_pen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_pen.Name = "num_pen";
            this.num_pen.Size = new System.Drawing.Size(98, 20);
            this.num_pen.TabIndex = 1;
            this.num_pen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_pen.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // num_gen
            // 
            this.num_gen.Location = new System.Drawing.Point(155, 99);
            this.num_gen.Name = "num_gen";
            this.num_gen.Size = new System.Drawing.Size(98, 20);
            this.num_gen.TabIndex = 1;
            this.num_gen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_gen.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // num_max
            // 
            this.num_max.Location = new System.Drawing.Point(155, 69);
            this.num_max.Name = "num_max";
            this.num_max.Size = new System.Drawing.Size(98, 20);
            this.num_max.TabIndex = 1;
            this.num_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_max.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // num_min
            // 
            this.num_min.Location = new System.Drawing.Point(155, 42);
            this.num_min.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_min.Name = "num_min";
            this.num_min.Size = new System.Drawing.Size(98, 20);
            this.num_min.TabIndex = 1;
            this.num_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_min.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // num_pop
            // 
            this.num_pop.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_pop.Location = new System.Drawing.Point(155, 16);
            this.num_pop.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_pop.Name = "num_pop";
            this.num_pop.Size = new System.Drawing.Size(98, 20);
            this.num_pop.TabIndex = 1;
            this.num_pop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_pop.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "C Sabit Değeri :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Virgül sonrası :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gen Sayısı :\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Max :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Min :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Populasyon Boyutu:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chart_pso
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_pso.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_pso.Legends.Add(legend4);
            this.chart_pso.Location = new System.Drawing.Point(288, 12);
            this.chart_pso.Name = "chart_pso";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_pso.Series.Add(series4);
            this.chart_pso.Size = new System.Drawing.Size(411, 300);
            this.chart_pso.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_153301021_PSO.Properties.Resources.sixhump;
            this.pictureBox2.Location = new System.Drawing.Point(12, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.chart_pso);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_jen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_gen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_jen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_min;
        private System.Windows.Forms.NumericUpDown num_pop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pso;
        private System.Windows.Forms.NumericUpDown num_c;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_max;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_pen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_gen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rad_min;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}

