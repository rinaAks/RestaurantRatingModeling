namespace RestaurantRatingModeling
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRating = new System.Windows.Forms.Label();
            this.numericNegativeReviews = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericPositiveReviews = new System.Windows.Forms.NumericUpDown();
            this.trackBarSanitariya = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarProductsPrice = new System.Windows.Forms.TrackBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.numericEnemies = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericNegativeReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPositiveReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSanitariya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProductsPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnemies)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(39, 453);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(167, 66);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Начать моделирование";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(281, 453);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(167, 66);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Остановить моделирование";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(825, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Рейтинг:";
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRating.Location = new System.Drawing.Point(952, 541);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(91, 37);
            this.lbRating.TabIndex = 3;
            this.lbRating.Text = "5 / 10";
            this.lbRating.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericNegativeReviews
            // 
            this.numericNegativeReviews.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericNegativeReviews.Location = new System.Drawing.Point(360, 41);
            this.numericNegativeReviews.Name = "numericNegativeReviews";
            this.numericNegativeReviews.Size = new System.Drawing.Size(71, 30);
            this.numericNegativeReviews.TabIndex = 4;
            this.numericNegativeReviews.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество отрицательных отзывов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество положительных отзывов";
            // 
            // numericPositiveReviews
            // 
            this.numericPositiveReviews.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericPositiveReviews.Location = new System.Drawing.Point(360, 101);
            this.numericPositiveReviews.Name = "numericPositiveReviews";
            this.numericPositiveReviews.Size = new System.Drawing.Size(71, 30);
            this.numericPositiveReviews.TabIndex = 7;
            this.numericPositiveReviews.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // trackBarSanitariya
            // 
            this.trackBarSanitariya.Location = new System.Drawing.Point(327, 289);
            this.trackBarSanitariya.Name = "trackBarSanitariya";
            this.trackBarSanitariya.Size = new System.Drawing.Size(134, 56);
            this.trackBarSanitariya.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Соответствие санитарным нормам";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(35, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Стоимость продуктов";
            // 
            // trackBarProductsPrice
            // 
            this.trackBarProductsPrice.Location = new System.Drawing.Point(231, 361);
            this.trackBarProductsPrice.Name = "trackBarProductsPrice";
            this.trackBarProductsPrice.Size = new System.Drawing.Size(134, 56);
            this.trackBarProductsPrice.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.BorderColor = System.Drawing.Color.Silver;
            legend1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(497, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Качество еды";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Цена блюд";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea2";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Качество сервиса";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Маркетинг и реклама";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(846, 507);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(35, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Количество конкурентов";
            // 
            // numericEnemies
            // 
            this.numericEnemies.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericEnemies.Location = new System.Drawing.Point(261, 219);
            this.numericEnemies.Name = "numericEnemies";
            this.numericEnemies.Size = new System.Drawing.Size(71, 30);
            this.numericEnemies.TabIndex = 14;
            this.numericEnemies.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 598);
            this.Controls.Add(this.numericEnemies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.trackBarProductsPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarSanitariya);
            this.Controls.Add(this.numericPositiveReviews);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericNegativeReviews);
            this.Controls.Add(this.lbRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Моделирование рейтинга ресторана";
            ((System.ComponentModel.ISupportInitialize)(this.numericNegativeReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPositiveReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSanitariya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProductsPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnemies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.NumericUpDown numericNegativeReviews;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericPositiveReviews;
        private System.Windows.Forms.TrackBar trackBarSanitariya;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarProductsPrice;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericEnemies;
        private System.Windows.Forms.Timer timer1;
    }
}

