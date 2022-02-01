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
    public partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();
        }

        private void AboutMe_Load(object sender, EventArgs e)
        {
            label1.Text = "Info:\n\nCreated by: Ghazar Ghazarian\n Starting Date: 12 / 07 / 2020\n Ending date: 28 / 07 / 2020\n Hourse spent ~24h\n Country: i was born in syria\n to an armenian parents and moved to canada during the war in Syria \n Student ID: 15953";

        }
    }
}
