using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
namespace WindowsFormsProject420_CT2
{
    public partial class IP_Validator : Form
    {
        DateTime currentDate = DateTime.Now;
        public IP_Validator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex myObj = new Regex(@"^([0-9]{1,3})\.([0-9]{1,3})\.([0-9]{1,3})\.([0-9]{1,3})$");
            if (myObj.IsMatch(textBox1.Text.Trim()) == true)
            {
                

                MessageBox.Show(textBox1.Text.Trim()+"\n This IP Adress is corrct");
                
            }
            else
            {
                MessageBox.Show(textBox1.Text.Trim() + "\nthis IP adress is wrong\nthe IP should be 4 byts\nInteger between 0 to 255\nseperated by a dot\n(255.255.255.255)");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
        }

        private void IP_Validator_Load(object sender, EventArgs e)
        {


            date.Text = ("Today : "+String.Format("{0:M/d/yy}", currentDate));

           

        }

        
    }
}
