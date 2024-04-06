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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.tbDebug = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            chartArea5.Name = "ChartArea1";
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.ChartAreas.Add(chartArea6);
            legend3.BackColor = System.Drawing.Color.White;
            legend3.BorderColor = System.Drawing.Color.Silver;
            legend3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(497, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Качество еды";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Цена блюд";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea2";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Качество сервиса";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea2";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Маркетинг и реклама";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
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
            // tbDebug
            // 
            this.tbDebug.Location = new System.Drawing.Point(39, 164);
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.Size = new System.Drawing.Size(100, 22);
            this.tbDebug.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1125, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Качество еды идеальное!";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1102, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Цена блюд неприлично высокая";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1110, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Качество сервиса идеальное";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1133, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ооочень много рекламы";
            this.label10.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 598);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDebug);
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
        private System.Windows.Forms.TextBox tbDebug;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

