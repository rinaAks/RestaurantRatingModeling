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

                if (foodQua > 1) { foodQua = 1; label7.Visible = true; }
                else label7.Visible = false;
                if (foodQua < 0) foodQua = 0;

                if (foodPrice > 1) { foodPrice = 1; label8.Visible = true; }
                else label8.Visible = false;
                if (foodPrice < 0) foodPrice = 0;
                //ТЕСТОВОЕ ИЗМЕНЕНИЕ
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

        //качество еды - зависит от санитарных норм и количества конкурентов,
        //т.е. от sanNorm и enemiesNum

        //влияет на количество конкурентов, цену блюд и сам рейтинг ресторана
        //т.е. на enemiesNum (здесь же), foodPrice, rating
        public void foodQuaChange()
        {
            if (sanNorm < 0.5) foodQua -= sanNorm / 50;
            else foodQua += sanNorm / 100;

            if (enemiesNum > 5) foodQua += enemiesNum / 100;
            tbDebug.Text = foodQua.ToString();

            if (foodQua > 0.8 && enemiesNum > 1) { 
                enemiesNum -= 1; 
                numericEnemies.Value -= 1; 
            }

        }

        //цена блюд - зависит от качества еды и стоимости продуктов,
        //т.е. от foodQua и groceriesPrice

        //влияет на сам рейтинг ресторана
        //т.е. на rating
        public void foodPriceChange()
        {
            if (groceriesPrice < 0.5) foodPrice -= groceriesPrice / 50;
            else foodPrice += groceriesPrice / 100;

        }

        /*
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
        /*
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
        }*/


    }
}
