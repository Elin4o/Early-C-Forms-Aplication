using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTheWolfOfWallStreet
{
    public partial class BuySellForm : Form
    {
        public BuySellForm()
        {
            InitializeComponent();
            TimerRandom.Start();
            TimeValues.Start();
        }

        public int ticksvalue;
        public int ticks;
        public int sharesprice;
        public int pensprice;
        public double ifNegative;

        private void TimerRandom_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 100)
            {
                Random rnd = new Random();
                sharesprice = rnd.Next(200, 300);
                pensprice = rnd.Next(300, 400);
                LblPenPrice.Text = pensprice + " лв";
                LblSharesPrice.Text = sharesprice + " лв";
                int getmoney = rnd.Next(1,15);
                if (getmoney == 3)
                {
                    GameForm.money += 100;
                    MessageBox.Show("You're lucky.You received 100 currency.That 1/15 chance.");
                }
                TimerRandom.Stop();
                ticks = 0;
                TimerRandom.Start();
            }
        }

        private void BuySellForm_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sharesprice = rnd.Next(200, 300);
            pensprice = rnd.Next(300, 400);
            LblPenPrice.Text = pensprice + " лв";
            LblSharesPrice.Text = sharesprice + " лв";
            LblPens.Text = GameForm.amountPen.ToString();
            LblShares.Text = GameForm.amountShare.ToString();
        }

        private void NUDToBuySell_ValueChanged(object sender, EventArgs e)
        {
            int myInt = Convert.ToInt32(NUDToBuySell.Value);
            if (myInt < 0)
            {
                MessageBox.Show("Warning, your number must be 1 or greater");
            }
            if (myInt + GameForm.sumOfItems > 15 - GameForm.sumOfItems)
            {
                BtnBuyPen.Enabled = false;
                BtnBuyShares.Enabled = false;
            }
        }

        private void BtnBuyPen_Click(object sender, EventArgs e)
        {
            int myInt = Convert.ToInt32(NUDToBuySell.Value);         
            ifNegative = GameForm.money - myInt * pensprice;

            if (ifNegative < 0)
            {
                MessageBox.Show("Not enough money to buy desired amount!");
                return;
            }
            else if (GameForm.money > pensprice)
            {
                GameForm.money = ifNegative;
                GameForm.amountPen += myInt;
                LblPens.Text = GameForm.amountPen.ToString();
            }

            if (GameForm.garagespace == GameForm.sumOfItems || GameForm.sumOfItems > 15)
            {
                MessageBox.Show("Your garage is full.You can't buy anymore items until you sell something");
            }
            else if (GameForm.amountShare > 15 || Convert.ToInt32(NUDToBuySell.Value) > GameForm.garagespace)
            {
                MessageBox.Show("You will have no space left. Choose a smaller number.");
                return;
            }
        }

        private void BtnBuyShares_Click(object sender, EventArgs e)
        {
            int myInt = Convert.ToInt32(NUDToBuySell.Value);
            ifNegative = GameForm.money - myInt * sharesprice;

            if (ifNegative < 0)
            {
                MessageBox.Show("Not enough money to buy desired amount!");
                return;
            }
            else if (GameForm.money > sharesprice)
            {
                GameForm.money = ifNegative;
                GameForm.amountShare += myInt;
                LblShares.Text = GameForm.amountShare.ToString();
            }
        }

        private void BtnSellPen_Click(object sender, EventArgs e)
        {
            int myInt = Convert.ToInt32(NUDToBuySell.Value);
            ifNegative = GameForm.amountPen - myInt;
            if (myInt < 1)
            {
                MessageBox.Show("Can't sell zeroes");
                return;
            }
            else if (GameForm.amountPen > 0)
            {
                GameForm.amountPen = ifNegative;
                GameForm.money += pensprice * myInt;
            }
            else if (GameForm.amountPen == 0)
            {
                MessageBox.Show("You dont have this item.");
            }
        }

        private void BtnSellShares_Click(object sender, EventArgs e)
        {
            int myInt = Convert.ToInt32(NUDToBuySell.Value);
            ifNegative = GameForm.amountShare - myInt;
            if (myInt < 1)
            {
                MessageBox.Show("Can't sell zeroes");
                return;
            }
            else if (GameForm.amountShare > 0)
            {
                GameForm.amountShare = ifNegative;
                int sumtest = sharesprice * myInt;
                GameForm.money += sumtest;
            }
            else if (GameForm.amountShare == 0)
            {
                MessageBox.Show("You dont have this item.");
            }
        }

        private void BuySellForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerRandom.Stop();
        }

        private void TimeValues_Tick(object sender, EventArgs e)
        {
            ticksvalue++;
            LblMoney.Text = GameForm.money.ToString();
            LblSpace.Text = GameForm.garagespace.ToString();
            LblPens.Text = GameForm.amountPen.ToString();
            LblShares.Text = GameForm.amountShare.ToString();
            LblSpace.Text = GameForm.sumOfItems + "/" + 15;
            GameForm.sumOfItems = GameForm.amountShare + GameForm.amountPen;

            if (GameForm.garagespace == GameForm.sumOfItems || GameForm.sumOfItems > 15)
            {
                //MessageBox.Show("Your garage is full.You can't buy anymore items until you sell something");
                BtnBuyPen.Enabled = false;
                BtnBuyShares.Enabled = false;
            }
            else if (GameForm.amountShare > 15 || Convert.ToInt32(NUDToBuySell.Value) > GameForm.garagespace)
            {
                //MessageBox.Show("You will have no space left. Choose a smaller number.");
                return;
            }

            if (GameForm.money == 0)
            {
                BtnBuyPen.Enabled = false;
                BtnBuyShares.Enabled = false;
            }
            else if (GameForm.money > 0 && GameForm.sumOfItems <= 15 - Convert.ToInt32(NUDToBuySell.Value))
            {
                BtnBuyPen.Enabled = true;
                BtnBuyShares.Enabled = true;
            }
        }
    }
}
