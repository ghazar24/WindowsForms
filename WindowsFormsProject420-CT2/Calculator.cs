using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace WindowsFormsProject420_CT2
{
    public partial class Calculator : Form
    {
        Cal obj= new Cal();
       
        public Calculator()
        {
            InitializeComponent();
        }


        
        private void button13_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal = Convert.ToByte(MessageBox.Show("Do you want to Exit?", "Calculator", MessageBoxButtons.OKCancel));

            if (btnVal == 1)
            {
                this.Close();
            }
        }

 


        private void button_click(object sender, EventArgs e)
        {
            

            Button b = (Button)sender;
            result.Text =result.Text + b.Text;
        
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result.Clear();
            obj.CurrentValue = 0;
            label.Text = "";
        }

        private void op_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            obj.Op = b.Text;
            try
            {
                obj.Operand1 = double.Parse(result.Text);
            }
            catch(Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                result.Text = "";
            }
            label.Text =result.Text+ obj.Op;

            result.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            try { obj.Operand2 = double.Parse(result.Text); }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                result.Text = "";
            }
            
            switch (obj.Op)
            {
                case "+":
                    result.Text = obj.Add();
                     
                    break;
                case"-":
                    result.Text = obj.Sub();
                    break;
                case "*":
                    result.Text = obj.Mult();
                    break;
                case "/":
                    result.Text = obj.Div();
                    break;
                default:
                    break;
                    
            }

            label.Text = "";
            result.Text =obj.CurrentValue.ToString();
            obj.Display();
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.History(),"History");
        }

        
    }
}
