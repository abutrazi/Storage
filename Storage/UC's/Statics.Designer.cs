namespace Storage.UC_s
{
    partial class Statics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblmost = new System.Windows.Forms.Label();
            this.btnmostapp = new System.Windows.Forms.Button();
            this.firstdate = new System.Windows.Forms.DateTimePicker();
            this.seconddate = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblsat1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(89, 112);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Qty";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(335, 304);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lblmost
            // 
            this.lblmost.AutoSize = true;
            this.lblmost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmost.Location = new System.Drawing.Point(31, 502);
            this.lblmost.Name = "lblmost";
            this.lblmost.Size = new System.Drawing.Size(350, 20);
            this.lblmost.TabIndex = 16;
            this.lblmost.Text = "Products That Have Most Appearance  Between";
            // 
            // btnmostapp
            // 
            this.btnmostapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostapp.ForeColor = System.Drawing.Color.Blue;
            this.btnmostapp.Location = new System.Drawing.Point(783, 499);
            this.btnmostapp.Name = "btnmostapp";
            this.btnmostapp.Size = new System.Drawing.Size(86, 23);
            this.btnmostapp.TabIndex = 12;
            this.btnmostapp.Text = "Save PDF";
            this.btnmostapp.UseVisualStyleBackColor = true;
            this.btnmostapp.Click += new System.EventHandler(this.btnmostapp_Click);
            // 
            // firstdate
            // 
            this.firstdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstdate.CustomFormat = "MM/yyyy";
            this.firstdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.firstdate.Location = new System.Drawing.Point(416, 502);
            this.firstdate.Name = "firstdate";
            this.firstdate.Size = new System.Drawing.Size(86, 22);
            this.firstdate.TabIndex = 17;
            // 
            // seconddate
            // 
            this.seconddate.CustomFormat = "MM/yyyy";
            this.seconddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.seconddate.Location = new System.Drawing.Point(537, 502);
            this.seconddate.Name = "seconddate";
            this.seconddate.Size = new System.Drawing.Size(106, 22);
            this.seconddate.TabIndex = 18;
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.CustomFormat = "MM/yyyy";
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(209, 84);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(87, 22);
            this.date.TabIndex = 19;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(537, 112);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "prod";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(383, 303);
            this.chart2.TabIndex = 20;
            this.chart2.Text = "chart2";
            // 
            // lblsat1
            // 
            this.lblsat1.AutoSize = true;
            this.lblsat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsat1.ForeColor = System.Drawing.Color.Blue;
            this.lblsat1.Location = new System.Drawing.Point(149, 53);
            this.lblsat1.Name = "lblsat1";
            this.lblsat1.Size = new System.Drawing.Size(200, 20);
            this.lblsat1.TabIndex = 21;
            this.lblsat1.Text = "Quntity of products in order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(620, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quntity of products in Storage";
            // 
            // Statics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsat1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.seconddate);
            this.Controls.Add(this.firstdate);
            this.Controls.Add(this.btnmostapp);
            this.Controls.Add(this.lblmost);
            this.Controls.Add(this.chart1);
            this.Name = "Statics";
            this.Size = new System.Drawing.Size(1000, 650);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblmost;
        private System.Windows.Forms.Button btnmostapp;
        private System.Windows.Forms.DateTimePicker firstdate;
        private System.Windows.Forms.DateTimePicker seconddate;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblsat1;
        private System.Windows.Forms.Label label1;
    }
}
