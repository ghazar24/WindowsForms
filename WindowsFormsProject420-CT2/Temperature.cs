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
    public partial class Temperature : Form
    {

        string path = @".\Temperature.txt";
        DateTime currentDateTime = DateTime.Now;
        FileStream fs = null;
        double c;
        double f;
        double currentvalue;
        public Temperature()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal = System.Convert.ToByte(MessageBox.Show("Do you want to Exit?", "Temperatue", MessageBoxButtons.OKCancel));

            if (btnVal == 1)
            {
                this.Close();
            }
        }

        private void CtoF_CheckedChanged(object sender, EventArgs e)
        {
            if (CtoF.Checked)
            {
                Ftextbox.ReadOnly = true;
                Ctextbox.ReadOnly = false;
                Ctextbox.Text = "";
                Ftextbox.Text = "";
                Message.Text = "";
            }
        }

        private void FtoC_CheckedChanged(object sender, EventArgs e)
        {
            if (FtoC.Checked)
            {
                Ctextbox.ReadOnly = true;
                Ftextbox.ReadOnly = false;
                Ftextbox.Text = "";
                Ctextbox.Text = "";
                Message.Text = "";
            }
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            try
            {
                if (CtoF.Checked)
                {

                    c = double.Parse(Ctextbox.Text);
                    currentvalue = (c * 9 / 5) + 32;
                    Ftextbox.Text = currentvalue.ToString();
                    textOut.Write(c + " C " + "|");
                    textOut.Write(" = " + Ftextbox.Text + " F " + "," + "|");
                    textOut.WriteLine(currentDateTime);

                }
                else if (FtoC.Checked)
                {


                    f = double.Parse(Ftextbox.Text);
                    currentvalue = (f - 32) * 5 / 9;
                    Ctextbox.Text = currentvalue.ToString();
                    textOut.Write(f + " F " + "|");
                    textOut.Write(" = " + Ctextbox.Text + " C " + "," + "|");
                    textOut.WriteLine(currentDateTime);


                }

                if (currentvalue == 100 || currentvalue == 212)
                {
                    Message.Text = "Water boils";
                }
                else if (currentvalue == 37 || currentvalue == 98.6)
                {
                    Message.Text = "Body temperature";
                }
                else if (currentvalue == 40 || currentvalue == 104)
                {
                    Message.Text = "Hot Bath";
                }
                else if (currentvalue == 30 || currentvalue == 86)
                {
                    Message.Text = "Beach weather";
                }
                else if (currentvalue == 21 || currentvalue == 70)
                {
                    Message.Text = "Room temperature";
                }
                else if (currentvalue == 10 || currentvalue == 50)
                {
                    Message.Text = "Cool Day";
                }
                else if (currentvalue == 0 || currentvalue == 32)
                {
                    Message.Text = "Freezing point of water";

                }
                else if (currentvalue == -18 || currentvalue == 0)
                {
                    Message.Text = "Very Cold Day";
                }
                else if (currentvalue == -40 || currentvalue == -40)
                {
                    Message.Text = "Extremely Cold Day (and the same number!)";
                }
                else
                {
                    Message.Text = "Nothing Special";

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Value Entered", "error");
                Ftextbox.Text = "";
                Ctextbox.Text = "";
                Message.Text = "";
            }
            finally
            {

                textOut.Close();
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
            textToPrint += columns[0] + columns[1] + columns[2] + "\n";

        }
        MessageBox.Show(textToPrint, "Temperature Ghazar");
        // close the input stream for the text file   
        textIn.Close();
    }

        private void Message_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
