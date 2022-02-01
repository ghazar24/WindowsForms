using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsProject420_CT2
{
    public partial class LottoMax : Form
    {
        DateTime currentDateTime = DateTime.Now;
        FileStream fs = null;
        string path = @".\lotto.txt";
        public LottoMax()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            Random random = new Random();
            int value;
            string[] g = new string[8];
            //int count = 0;
            int i;
            for (i = 0; i < 8; i++)
            {
                value = random.Next(1, 49);
                MaxBox.Text += value.ToString() + "\r\n";
                g[i] = value.ToString();

            }

            textOut.Write("Max"+"\t" + "|");
            for (i = 0; i < 7; i++)
            {
                textOut.Write(g[i] + ",");
            }

            textOut.Write("  Extra (" + g[7] + ")" + "|");
            textOut.WriteLine("  " + currentDateTime);

            textOut.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal = Convert.ToByte(MessageBox.Show("Do you want to Exit?", "lotto649", MessageBoxButtons.OKCancel));

            if (btnVal == 1)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string textToPrint = "";
            fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(fs);
            // read the data from the file and store it in the list   
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                textToPrint += columns[0] +columns[1] + columns[2] + "\n";
            
            }
            MessageBox.Show(textToPrint,"All Winning Numbers");
            // close the input stream for the text file   
            textIn.Close();
        }
    }
}
