using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantRatingModeling
{
    public partial class Form1 : Form
    {
        bool buttonValue;
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonValue = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        int negativeRev, positiveRev, enemiesNum;
        int month;
        double foodQua = 0.5, foodPrice = 0.5, serviceQua = 0.5, advert = 0.5;
        double sanNorm, groceriesPrice;

        const double k = 0.1; //коэффициент, задаём сами. нужен, чтобы на меньшее число после рандома менялось
        Random rnd = new Random(); //от 0 до 1
        private void btStart_Click(object sender, EventArgs e)
        {
            month = 0;
            buttonValue = true;
            negativeRev = (int)numericNegativeReviews.Value;
            positiveRev = (int)numericPositiveReviews.Value;
            enemiesNum = (int)numericEnemies.Value;
            sanNorm = ((double)trackBarSanitariya.Value) / 10.0;
            groceriesPrice = ((double)trackBarProductsPrice.Value) / 10.0;
            for (int i = 0; i < 4; i++)
            {
                chart1.Series[i].Points.Clear();
            }
            chart1.Series[0].Points.AddXY(0, foodQua);
            chart1.Series[1].Points.AddXY(0, foodPrice);
            chart1.Series[2].Points.AddXY(0, serviceQua);
            chart1.Series[3].Points.AddXY(0, advert);

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (buttonValue)
            {
                month++;
                //место для изменения переменных
                advertChange();
                serviceQuaAndRevChange();

                chart1.Series[0].Points.AddXY(month, foodQua);
                chart1.Series[1].Points.AddXY(month, foodPrice);
                chart1.Series[2].Points.AddXY(month, serviceQua);
                chart1.Series[3].Points.AddXY(month, advert);
            }

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            buttonValue = false;
            timer1.Stop();
        }

        public void advertChange()
        {
            const double PositiveRevFactor = 0.1;
            const double NegativeRevFactor = -0.05;
            const double enemiesFactor = 0.01;

            advert += positiveRev * PositiveRevFactor;
            advert += negativeRev * NegativeRevFactor;
            advert += enemiesNum * enemiesFactor;
        }

        public void serviceQuaAndRevChange()
        {
            const double ServiceQuaFactor = 0.03; // фактор увеличения качества сервиса
            const double NegativeRevFactor = -0.1; // фактор уменьшения отрицательных отзывов
            const double PositiveRevFactor = 0.3; // фактор увеличения положительных отзывов

            serviceQua += negativeRev * ServiceQuaFactor;
            if (negativeRev > 1) // вычитание определенной части отрицательных отзывов, пропорциональной качеству сервиса
                negativeRev += (int)(serviceQua * NegativeRevFactor);
            numericNegativeReviews.Value = negativeRev;

            positiveRev += (int)(serviceQua * PositiveRevFactor);
            if (positiveRev <= 100)
                numericPositiveReviews.Value = positiveRev;
        }

    }
}
