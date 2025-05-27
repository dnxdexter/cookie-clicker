using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cookie_clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double money = 1, multiplyer = 1,clickspeed=1000,amountofclickers=0,price1 = 10,price2 = 10,price3 = 10;
        bool isRunning = true;

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Text = price3.ToString();
            linkLabel2.Text = price1.ToString();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (money >= price3)
            {
                money = money - price3;
                amountofclickers++;
                linkLabel3.Text = "Purchase complete";
                await Task.Delay(500);
                price3 = price3 * 2;
                Text = price3.ToString();
                linkLabel3.Text = price3.ToString();
            }
            else
            {
                Text = "Unsufficient ballence";
                linkLabel3.Text = "Unsufficient ballence";
                await Task.Delay(500);
                Text = price3.ToString();
                linkLabel3.Text = price3.ToString();
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            while (isRunning)
            {
                money = money +(((multiplyer))*amountofclickers)/5;
                lblmoney.Text = $"Money: ${money}";
                await Task.Delay(Convert.ToInt32(clickspeed));
                Text = multiplyer + "X";
                linkLabel4.Text = multiplyer + "X";
                Text = (clickspeed / 1000).ToString() + "s";
                linkLabel5.Text = (clickspeed / 1000).ToString() + "s";
                Text = amountofclickers.ToString();
                linkLabel6.Text = amountofclickers.ToString();
            }

        }
       

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Text = multiplyer+"X";
            linkLabel4.Text = multiplyer+"X";
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Text = (clickspeed/1000).ToString()+"s";
            linkLabel5.Text = (clickspeed / 1000).ToString() + "s";
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Text = amountofclickers.ToString();
            linkLabel6.Text = amountofclickers.ToString();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Text = price2.ToString();
            linkLabel2.Text = price2.ToString();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (money >= price2)
            {
                money = money - price2;
                clickspeed = clickspeed - (clickspeed * 0.05);
                linkLabel2.Text = "Purchase complete";
                await Task.Delay(500);
                price2 = price2 * 2;
                Text = price2.ToString();
                linkLabel2.Text = price1.ToString();
            }
            else
            {
                Text = "Unsufficient ballence";
                linkLabel2.Text = "Unsufficient ballence";
                await Task.Delay(500);
                Text = price2.ToString();
                linkLabel2.Text = price1.ToString();
            }
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Text = price1.ToString();
            linkLabel1.Text = price1.ToString();

        }    
        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (money >= price1)
            {
                money = money - price1;
                lblmoney.Text = "Money: $" + money;
                multiplyer = multiplyer + (price1 * 5);
                linkLabel1.Text = "Purchase complete";
                await Task.Delay(500);
                price1 = price1 * 2;
                Text = price1.ToString();
                linkLabel1.Text = price1.ToString();
            }
            else
            {
                Text = "Unsufficient ballence";
                linkLabel1.Text = "Unsufficient ballence";
                await Task.Delay(500);
                Text = price1.ToString();
                linkLabel1.Text = price1.ToString();
            }
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Text = "Money: $ " + money;
            lblmoney.Text = "Money: $" + money;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Cookie.Enabled=false;
            money = money + (1 * multiplyer);
            lblmoney.Text = "Money: $" + money;
            await Task.Delay(Convert.ToInt32(clickspeed));
            Cookie.Enabled = true;
        }
    }
}
