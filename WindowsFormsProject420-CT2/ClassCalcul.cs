using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace WindowsFormsProject420_CT2
{
    
    class Cal
    {
        string path = @".\Calculator.txt";
        FileStream fs = null;
        
        //private fields
        private double currentValue;
        private double operand1,operand2;
        private string op; 

        //public propriety
        public double Operand1
        {
            set { operand1 = value; }
            get { return operand1; }
        }
        public double Operand2
        {
            set { operand2 = value; }
            get { return operand2; }
        }
        public double CurrentValue
        {
            set { currentValue = value; }
            get { return currentValue; }
        }
        public string Op
        {
            set { op = value; }
            get { return op; }
        }
        public string Add()
        {

            return ((currentValue = operand1 + operand2).ToString());
        }
        public string Sub()
        {
            return ((currentValue = operand1 - operand2).ToString());
        }
        public string Mult()
        {
            return ((currentValue = operand1 * operand2).ToString());
        }
        public string Div()
        {
            return ((currentValue = operand1 / operand2).ToString());
        }
        public string Display()
        {
           
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            
           
            
            string f = operand1.ToString();
            string o = op;
            string s = operand2.ToString();
            string c = currentValue.ToString();

            string show = (f + o + s + "=" + c);
            
            textOut.WriteLine(show+"|");
            textOut.Close();
            return (show);
            
        }
        public string History()
        {
            string textToPrint = "";
            fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(fs);
            while (textIn.Peek() != -1)
            {
               string row = textIn.ReadLine();
               
                string[] columns = row.Split('|');
                textToPrint += columns[0]+ "\n";
            }
            textIn.Close();
            return (textToPrint);
        }
    }
}