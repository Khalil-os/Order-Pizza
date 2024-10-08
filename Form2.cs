using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class OrderPizza : Form
    {
        int Toppings = 0;

        public OrderPizza()
        {
            InitializeComponent();

            Image backgroundImage = Image.FromFile(@"C:\Users\HP\source\repos\Pizza\Order-Pizza.jpeg");

            this.BackgroundImage = backgroundImage;

            this.ClientSize = new Size(backgroundImage.Width, backgroundImage.Height);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            rbEatIn.Checked = true;
            rbThin.Checked = true;
            UpdatePrice();
        }

        private void UpdateToppingsLabel()
        {
            lbToppings.Text = ""; // نمسحو النص القديم

            if (cbCheese.Checked)
            {
                lbToppings.Text += "Extra Cheese ,\n";
            }

            if (cbMushrooms.Checked)
            {
                lbToppings.Text += "Mushrooms ,\n";
            }

            if (chTomatoes.Checked)
            {
                lbToppings.Text += "Tomatoes ,\n";
            }

            if (cbOlives.Checked)
            {
                lbToppings.Text += "Olives ,\n";
            }

            if (cbOnion.Checked)
            {
                lbToppings.Text += "Onion ,\n";
            }

            if (cbGreenPeppers.Checked)
            {
                lbToppings.Text += "Green Peppers ,\n";
            }
        }

        private void UpdatePrice()
        {
            int PriceSize = Convert.ToInt32(gbSize.Tag);
            int PriceToppings = Toppings;
            int PriceCrustType = Convert.ToInt32(gbCrustType.Tag);
            int Price = PriceSize + PriceToppings + PriceCrustType;
            lbPrice.Text = "$" + Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gbSize.Tag = rbSmall.Tag;
            lbSize.Text = "Small";
            UpdatePrice();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            gbSize.Tag = rbMeduim.Tag;
            lbSize.Text = "Meduim";
            UpdatePrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            gbSize.Tag = rbLarge.Tag;
            lbSize.Text = "Large";
            UpdatePrice();
        }

        private void cbCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheese.Checked)
            {
                Toppings += Convert.ToInt32(cbCheese.Tag);
            }
            else
            {
                Toppings -= Convert.ToInt32(cbCheese.Tag);
            }
            UpdatePrice();
            UpdateToppingsLabel();
        }

        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMushrooms.Checked)
            {
                Toppings += Convert.ToInt32(cbMushrooms.Tag);
            }
            else
            {
                Toppings -= Convert.ToInt32(cbMushrooms.Tag);
            }
            UpdatePrice();
            UpdateToppingsLabel();
        }

        private void chTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chTomatoes.Checked)
            {
                Toppings += Convert.ToInt32(chTomatoes.Tag);
            }
            else
            {
                Toppings -= Convert.ToInt32(chTomatoes.Tag);
            }
            UpdatePrice();
            UpdateToppingsLabel();
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOlives.Checked)
            {
                Toppings += Convert.ToInt32(cbOlives.Tag);
            }
            else
            {
                Toppings -= Convert.ToInt32(cbOlives.Tag);
            }
            UpdatePrice();
            UpdateToppingsLabel();
        }

        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnion.Checked)
            {
                Toppings += Convert.ToInt32(cbOnion.Tag);
            }
            else
            {
                Toppings -= Convert.ToInt32(cbOnion.Tag);
            }
            UpdatePrice();
            UpdateToppingsLabel();
        }

        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGreenPeppers.Checked)
            {
                Toppings += Convert.ToInt32(cbGreenPeppers.Tag);
            }
            else
            {
                Toppings -= Convert.ToInt32(cbGreenPeppers.Tag);
            }
            UpdatePrice();
            UpdateToppingsLabel();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            gbCrustType.Tag = rbThick.Tag;
            lbCrustType.Text = "Think Crust";

            UpdatePrice();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            gbCrustType.Tag = rbThin.Tag;
            lbCrustType.Text = "Thin Crust";
            UpdatePrice();

        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lbWhereEat.Text = "Eat In";
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            lbWhereEat.Text = "Take Out";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Succesfuly" , "Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereEat.Enabled = false;
                btOrderPizza.Enabled = false;
            }
        }
    }
}
