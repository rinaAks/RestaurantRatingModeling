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
        double rating = 5.0;

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
            rating = 5.0;
            foodQua = 0.5; foodPrice = 0.5; serviceQua = 0.5; advert = 0.5;
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

                ratingChange();

                if (foodQua > 1) { foodQua = 1; label7.Visible = true; }
                else label7.Visible = false;
                if (foodQua < 0) foodQua = 0;

                if (foodPrice > 1) { foodPrice = 1; label8.Visible = true; }
                else label8.Visible = false;
                if (foodPrice < 0) foodPrice = 0;

                if (serviceQua > 1) { serviceQua = 1; label9.Visible = true; }
                else label9.Visible = false;
                if (serviceQua < 0) serviceQua = 0;

                if (advert > 1) { advert = 1; label10.Visible = true; }
                else label10.Visible = false;
                if (advert < 0) advert = 0;
                
                chart1.Series[0].Points.AddXY(month, foodQua);
                chart1.Series[1].Points.AddXY(month, foodPrice);
                chart1.Series[2].Points.AddXY(month, serviceQua);
                chart1.Series[3].Points.AddXY(month, advert);

                if (rating < 10) lbRating.Text = Math.Round(rating, 2) + "/10";
                else lbRating.Text = rating + "/10";
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
            if (groceriesPrice < 0.5) foodPrice -= groceriesPrice / 10;
            else foodPrice += groceriesPrice / 10;
        }

        //качество сервиса зависит от кол-ва отриц. отзывов,
        //т.е. от negativeRev
        //влияет на полож отзывы, отриц отзывы, сам рейтинг ресторана
        //т.е. positiveRev, negativeRev, rating

        //негативные отзывы зависят от качества сервиса
        //влияют на качество сервиса (учтено в качестве сервиса), маркетинг и рекламу, и рейтинг ресторана

        //положительные отзывы зависят от качества сервиса
        //влияют на маркетинг и рекламу, и рейтинг ресторана
        public void serviceQuaAndRevChange()
        {
            serviceQua += (double)negativeRev / 1000;

            if (serviceQua > 0.6 && serviceQua < 0.8) { 
                positiveRev += 1; 
                numericPositiveReviews.Value += 1;
                advert += 0.01;
            }
            if (serviceQua >= 0.8) { 
                positiveRev += 2; 
                numericPositiveReviews.Value += 2;
                advert += 0.02;
            }

            if (serviceQua < 0.6) { 
                negativeRev += 1; 
                numericNegativeReviews.Value += 1;
                advert -= 0.06;
            }
        }

        //маркетинг и реклама зависят от отриц. (учтено), полож. отзывов (учтено) и кол-ва конкурентов
        //влияют на сам рейтинг (с задержкой)
        public void advertChange()
        {
            if (enemiesNum > 5) advert += (double)enemiesNum / 100;
        }

        public void ratingChange()
        {
            if (negativeRev / positiveRev > 1) rating -= (double)negativeRev * ((double)negativeRev / (double)positiveRev) / 1000;
            else rating += (double)positiveRev * ((double)positiveRev / (double)negativeRev) / 1000;
            
            if (serviceQua > 0.8) rating += serviceQua / 100;
            if(serviceQua < 0.4) rating -= serviceQua / 100;

            if (sanNorm > 0.8) rating += sanNorm / 1000;
            if (sanNorm < 0.3) rating -= (1-sanNorm) / 10;

            if (foodPrice > 0.8) rating -= 0.05;
            if (foodPrice < 0.3) rating += 0.05;

            if (foodQua > 0.8) rating += foodQua / 100;
            if (foodQua < 0.4) rating -= foodQua / 100;

            if (advert > 0.8) rating += advert / 1000;
            if (advert < 0.4) rating -= advert / 1000;
            //tbDebug.Text = rating.ToString();
        }
    }
}
