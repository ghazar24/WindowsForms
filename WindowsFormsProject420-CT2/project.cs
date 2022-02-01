using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject420_CT2
{
    public partial class Ghazar : Form
    {
        public Ghazar()
        {
            InitializeComponent();
        }

        private void picmax_Click(object sender, EventArgs e)
        {
            LottoMax form = new LottoMax();
             form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Lotto649 form = new Lotto649();
            form.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Calculator form = new Calculator();
            form.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MoneyEx form = new MoneyEx();
            form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Temperature form = new Temperature();
            form.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            IP_Validator form = new IP_Validator();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AboutMe form = new AboutMe();
            form.ShowDialog();
        }
    }
}
