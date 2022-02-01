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
    public partial class MoneyEx : Form
    {
        string path = @".\MoneyExchange.txt";
        DateTime currentDateTime = DateTime.Now;
        FileStream fs = null;
        string fromchoice ="";
        string tochoice ="";
        public MoneyEx()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          MessageBox.Show("Do you want to Exit?", "Calculator", MessageBoxButtons.OKCancel);
            
            
        }
        private void Convert_Click(object sender, EventArgs e)
        {

            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            
            //IF THE USER WANTS TO EXCHANGE FROM CANADIAN DOLLOR
            if (fromchoice == "CAD")
            {
                switch (tochoice)
                {
                    case "USD":
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 0.75).ToString() + "$";


                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }
                        break;
                    case "EUR":
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 0.64).ToString() + " €";

                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }

                        break;
                    case "GBP":
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 0.58).ToString() + " £";
                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }

                        break;
                    case "CAD":
                        MessageBox.Show("Can not convert to the same currency", "Error");
                        break;
                    default:
                        break;
                }
            }
            //IF THE USER WANTS TO EXCHANGE FROM US DOLLAR
            else if (fromchoice == "USD")
            {
                switch (tochoice)
                {
                    
                    case "USD":
                        
                            MessageBox.Show("Can not convert to the same currency", "Error");

                        break;
                    case "EUR":
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 0.86).ToString() + " €";

                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }

                        break;
                    case "GBP":
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 0.78).ToString() + " £";
                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }

                        break;
                    case "CAD":
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 1.34).ToString() + " $";
                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }
                        break;
                    default:
                        break;
                }
            }
            //IF THE USER WANTS TO EXCHANGE FROM EURO
            else if (fromchoice == "EUR")
            {
                switch (tochoice)
                {
                    case "USD":
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 1.17).ToString() + "$";


                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }
                        break;
                    case "EUR":
                        MessageBox.Show("Can not convert to the same currency", "Error");

                        break;
                    case "GBP":
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 0.91).ToString() + " £";
                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }

                        break;
                    case "CAD":
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 1.56).ToString() + " £";
                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }
                        break;
                    default:
                        break;
                }
            }
            //IF THE USER WANTS TO EXCHANGE FROM POUND STERLING
            else if (fromchoice == "GBP")
            {
                switch (tochoice)
                {
                    case "USD":
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 1.28).ToString() + "$";


                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }
                        break;
                    case "EUR":
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 1.10).ToString() + " €";

                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }

                        break;
                    case "GBP":
                        MessageBox.Show("Can not convert to the same currency", "Error");
                        textboxfrom.Text = "";
                        break;
                    case "CAD":
                       
                        try
                        {
                            textboxto.Text = (double.Parse(textboxfrom.Text) * 1.72).ToString() + " £";
                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                            textboxfrom.Text = "";
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (fromchoice == "DD")
            {

            }
            textOut.Write(textboxfrom.Text + "|");
            textOut.Write(fromchoice +" = "+ "|");
            textOut.Write(textboxto.Text + "|");
            textOut.Write(tochoice + "|");
            textOut.WriteLine("  " + currentDateTime);
            textOut.Close();
        }
            
    

        private void from_click(object sender, EventArgs e)
        {
            if(btnFromCAD.Checked)
            {
                fromchoice = btnFromCAD.Text;
               
            }
            else if(btnFromEUR.Checked)
            {
                fromchoice = btnFromEUR.Text;
              
            }
            else if (btnFromGBP.Checked)
            {
                fromchoice = btnFromGBP.Text;
            }
            else
            {
                fromchoice = btnFromUSD.Text;
            }
        }

        private void to_check(object sender, EventArgs e)
        {
            if (btnToCAD.Checked)
            {
                tochoice = btnToCAD.Text;
            }
            else if (btnToEUR.Checked)
            {
                tochoice = btnToEUR.Text;
            }
            else if (btnToGBP.Checked)
            {
                tochoice = btnToGBP.Text;
            }
            else
            {
                tochoice = btnToUSD.Text;
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
                textToPrint += columns[0] + columns[1] + columns[2] + columns[3]+ columns[4]+ "\n";

            }
            MessageBox.Show(textToPrint,"Exchanges made");
            // close the input stream for the text file   
            textIn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string btn;
            btn = MessageBox.Show("Do you want to Exit?", "lotto649", MessageBoxButtons.OKCancel).ToString();

            if (btn == "OK")
            {
                this.Close();
            }
        }
    }
}
