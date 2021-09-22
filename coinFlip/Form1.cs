using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coinFlip
{
    public partial class Form1 : Form
    {
        Coin[] coins = new Coin[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_flipCoin_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            // displays labels
            label1.Text = "";
            for (int i = 0; i < coins.Length; i++) 
            {
                label1.Text += coins[i].isHeads + ",";
                coins[i].flipCoin(r);

            }

            // sets pictures based on true or false ternary operator

            pictureBox1.Image = coins[0].isHeads ? Properties.Resources.quarterHeads : Properties.Resources.quaterTails;
            pictureBox2.Image = coins[1].isHeads ? Properties.Resources.quarterHeads : Properties.Resources.quaterTails;
            pictureBox3.Image = coins[2].isHeads ? Properties.Resources.quarterHeads : Properties.Resources.quaterTails;
            pictureBox4.Image = coins[3].isHeads ? Properties.Resources.quarterHeads : Properties.Resources.quaterTails;
            pictureBox5.Image = coins[4].isHeads ? Properties.Resources.quarterHeads : Properties.Resources.quaterTails;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <coins.Length;i++)
            {
                coins[i] = new Coin(false);
            }
        }
    }
}
