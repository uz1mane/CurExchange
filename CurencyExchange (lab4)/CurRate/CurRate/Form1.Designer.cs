namespace CurRate
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edSellingAmount = new System.Windows.Forms.NumericUpDown();
            this.edBuyingAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEuros = new System.Windows.Forms.Label();
            this.lbRubles = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.edRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSellingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBuyingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edSellingAmount);
            this.panel1.Controls.Add(this.edBuyingAmount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbEuros);
            this.panel1.Controls.Add(this.lbRubles);
            this.panel1.Controls.Add(this.btCalculate);
            this.panel1.Controls.Add(this.edRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 118);
            this.panel1.TabIndex = 0;
            // 
            // edSellingAmount
            // 
            this.edSellingAmount.Location = new System.Drawing.Point(347, 81);
            this.edSellingAmount.Name = "edSellingAmount";
            this.edSellingAmount.Size = new System.Drawing.Size(120, 20);
            this.edSellingAmount.TabIndex = 10;
            // 
            // edBuyingAmount
            // 
            this.edBuyingAmount.Location = new System.Drawing.Point(347, 56);
            this.edBuyingAmount.Name = "edBuyingAmount";
            this.edBuyingAmount.Size = new System.Drawing.Size(120, 20);
            this.edBuyingAmount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Продать Евро";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Купить Евро";
            // 
            // lbEuros
            // 
            this.lbEuros.AutoSize = true;
            this.lbEuros.Location = new System.Drawing.Point(28, 80);
            this.lbEuros.Name = "lbEuros";
            this.lbEuros.Size = new System.Drawing.Size(96, 13);
            this.lbEuros.TabIndex = 6;
            this.lbEuros.Text = "Евро на счете     :";
            // 
            // lbRubles
            // 
            this.lbRubles.AutoSize = true;
            this.lbRubles.Location = new System.Drawing.Point(28, 58);
            this.lbRubles.Name = "lbRubles";
            this.lbRubles.Size = new System.Drawing.Size(122, 13);
            this.lbRubles.TabIndex = 5;
            this.lbRubles.Text = "Рублей на счете : 1000";
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(571, 56);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(126, 45);
            this.btCalculate.TabIndex = 4;
            this.btCalculate.Text = "Следующий день";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // edRate
            // 
            this.edRate.DecimalPlaces = 2;
            this.edRate.Location = new System.Drawing.Point(122, 15);
            this.edRate.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.edRate.Name = "edRate";
            this.edRate.Size = new System.Drawing.Size(72, 20);
            this.edRate.TabIndex = 1;
            this.edRate.Value = new decimal(new int[] {
            8953,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий курс    :";
            // 
            // chart1
            // 
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Minimum = 50D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 118);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "f2";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(758, 332);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSellingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBuyingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.NumericUpDown edRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbRubles;
        private System.Windows.Forms.NumericUpDown edSellingAmount;
        private System.Windows.Forms.NumericUpDown edBuyingAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEuros;
    }
}

