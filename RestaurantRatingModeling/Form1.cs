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

        double normFoodQua, normSanNorm, normFoodPrice, normAdvert, normRev, normServiceQua;

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
                foodQuaChange();
                foodPriceChange();
                serviceQuaAndRevChange();
                advertChange();
                double rate = (normFoodQua + normSanNorm + normFoodPrice + normAdvert + normRev + normServiceQua) / 6 * 10;
                int res = (int)rate;
                if (res > 9 && negativeRev > 1) res--;
                if (res > 9 && sanNorm < 8) res -= 2;
                if (res < 10)
                    lbRating.Text = res.ToString();

                chart1.Series[0].Points.AddXY(month, foodQua);
                chart1.Series[1].Points.AddXY(month, foodPrice);
                chart1.Series[2].Points.AddXY(month, serviceQua/10);
                chart1.Series[3].Points.AddXY(month, advert/10);
            }

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            buttonValue = false;
            timer1.Stop();
        }

        public void foodQuaChange()
        {
            const double enemFactor = 0.02;
            const double sanNormFactor = 0.05;
            const double foodQuaFactor = -0.18;

            foodQua += enemiesNum * enemFactor;
            foodQua += sanNorm * sanNormFactor;

            if (foodQua <= 10)
                normFoodQua = foodQua / 10;
            else normFoodQua = foodQua / 100;
            if (enemiesNum > 1)
                enemiesNum += (int)(foodQua * foodQuaFactor);
            numericEnemies.Value = enemiesNum;
        }
        public void foodPriceChange()
        {
            const double foodQuaFactor = 0.05;
            const double grocPriceFactor = 0.05;
            if (foodPrice <= 10)
                normFoodPrice = foodPrice / 10;
            else normFoodPrice = foodPrice / 100; 
            foodPrice += groceriesPrice * grocPriceFactor;
            foodPrice += foodQua * foodQuaFactor;
        }
        
        //изначальная версия Никиты
        public void serviceQuaAndRevChange()
        {
            const double ServiceQuaFactor = 0.03; // фактор увеличения качества сервиса
            const double NegativeRevFactor = -0.1; // фактор уменьшения отрицательных отзывов
            const double PositiveRevFactor = 0.3; // фактор увеличения положительных отзывов

            normRev = negativeRev / positiveRev;
            if (normRev < 0.1) normRev *= 10;

            if (serviceQua <= 10) normServiceQua = serviceQua / 10;
            else normServiceQua = serviceQua / 100; 

            serviceQua += negativeRev * ServiceQuaFactor;
            if (negativeRev > 1) // вычитание определенной части отрицательных отзывов, пропорциональной качеству сервиса
                negativeRev += (int)(serviceQua * NegativeRevFactor);
            numericNegativeReviews.Value = negativeRev;

            positiveRev += (int)(serviceQua * PositiveRevFactor);
            if (positiveRev <= 100)
                numericPositiveReviews.Value = positiveRev;
        }
        

        //версия Иры, работает чуть-чуть багованно
        /*public void serviceQuaAndRevChange()
        {
            double coef = (double)negativeRev / (double)positiveRev; //если негативных больше, то качество сервиса больше меняется
            //coef = coef*(1 + k * (rnd.NextDouble() - 0.5));
            if (coef > 1) coef = 1 - coef / 10;
            double ServiceQuaFactor = 0.1; // фактор увеличения качества сервиса
            double NegativeRevFactor = -1.0 * coef; // фактор уменьшения отрицательных отзывов
            double PositiveRevFactor = coef; // фактор увеличения положительных отзывов
            tbDebug.Text = serviceQua.ToString();
            if (serviceQua < 100)
                serviceQua += negativeRev * ServiceQuaFactor * coef;
            if (negativeRev > 1) // вычитание определенной части отрицательных отзывов, пропорциональной качеству сервиса
                negativeRev += (int)(serviceQua * NegativeRevFactor);
            numericNegativeReviews.Value = negativeRev;

            positiveRev += (int)(serviceQua * PositiveRevFactor);
            if (positiveRev <= 100)
                numericPositiveReviews.Value = positiveRev;
        }*/

        public void advertChange()
        {
            const double PositiveRevFactor = 0.1;
            const double NegativeRevFactor = -0.05;
            const double enemiesFactor = 0.01;
            if (normAdvert <= 10)
                normAdvert = advert / 10;
            else normAdvert = advert / 100; 
            if (advert < 10)
            {
                advert += positiveRev * PositiveRevFactor;
                advert += negativeRev * NegativeRevFactor;
                advert += enemiesNum * enemiesFactor;
            }
        }

        
    }
}
