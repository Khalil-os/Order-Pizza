using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Image backgroundImage = Image.FromFile(@"C:\Users\HP\source\repos\Pizza\Pizza-Login3.png");

            this.BackgroundImage = backgroundImage;

            this.ClientSize = new Size(backgroundImage.Width, backgroundImage.Height);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form OrderPIZZA = new OrderPizza();
            OrderPIZZA.ShowDialog();
        }
    }
}
