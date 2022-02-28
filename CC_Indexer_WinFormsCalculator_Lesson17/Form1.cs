using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Indexer_WinFormsCalculator_Lesson17
{
    public partial class CalcForm : Form
    {
        public Calculator Calculator { get; set; }
        private void WorkWithIndexer()
        {

            Calculator = new Calculator();

            //Get Value From Indexer And Method
            double num1FromIndexer = Calculator["Number1"];
            double num2FromIndexer = Calculator["Number2"];
            double num1FromMethod = Calculator.GetPropValue(nameof(Calculator.Number1));
            double num2FromMethod = Calculator.GetPropValue("Number2");

            //Set Value With Indexer And Method
            Calculator["Number1"] = 4.2;//value = 4.2
            Calculator["Number2"] = 13.13;//value = 13.13
            Calculator.SetPropValue(nameof(Calculator.Number1), 5.6);
            Calculator.SetPropValue("Number2", 21);

            Calculator.Number1 = 14;//Property
            Calculator["Number1"] = 14;//Indexer
            Calculator.SetPropValue("Number1", 14);//Method

            //Parameters In Indexer
            double num3FromIndexer = Calculator["Number2", 4];//Get
            Calculator["Number1",2] = 11;//Set

            double ee = Calculator[2];

            int x;
            WorkWithOut(out x);
            //Console.WriteLine(x);

            int.TryParse("4", out x);//0 => x = 0;
            Console.WriteLine(x);

        }
        private void WorkWithOut(out int x)
        {
            x = 0;
        }
        private void UpdateNumberAsDouble()
        {
            double number;
            if(ActiveTextBox.Name == "txb_Num1")
            {
                //double d = Calculator["Number1"];
                string curString = ActiveTextBox.Text;
                if (double.TryParse(txb_Num1.Text, out number))
                {
                    Calculator["Number1"] = number;
                }
            }
            if (ActiveTextBox.Name == "txb_Num2")
            {
                //double d = Calculator["Number1"];
                string curString = ActiveTextBox.Text;
                if (double.TryParse(txb_Num2.Text, out number))
                {
                    Calculator["Number2"] = number;
                }
            }
        }

        public TextBox ActiveTextBox { get; set; }
        //private double number1;
        //private double number2;

        public CalcForm()
        {
            InitializeComponent();
            ActiveTextBox = this.txb_Num1;

            WorkWithIndexer();
        }



        private void txb_Num1_Enter(object sender, EventArgs e)
        {
            ActiveTextBox = sender as TextBox;
        }

        private void TextNumber2Enter(object sender, EventArgs e)
        {
            ActiveTextBox = sender as TextBox;
        }

        private void btn_Nmb1_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "1";
            UpdateNumberAsDouble();
        }

        private void btn_Nmb2_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "2";
            UpdateNumberAsDouble();
        }

        private void btn_Nmb3_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "3";
            UpdateNumberAsDouble();
        }

        private void btn_Nmb4_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "4";
            UpdateNumberAsDouble();
        }

        private void btn_Nmb5_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "5";
            UpdateNumberAsDouble();
        }

        private void btn_Nmb6_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "6";
            UpdateNumberAsDouble();
        }

        private void btn_Nmb7_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "7";
            UpdateNumberAsDouble();
        }

        private void btn_Nmb8_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "8";
            UpdateNumberAsDouble();
        }

        private void btn_Nmb9_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "9";
            UpdateNumberAsDouble();
        }

        private void btn_Nmb0_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += "0";
            UpdateNumberAsDouble();
        }

        private void btn_Dot_Click(object sender, EventArgs e)
        {
            ActiveTextBox.Text += ".";
            UpdateNumberAsDouble();
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            this.lblOper.Text = "+";
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            this.lblOper.Text = "-";
        }

        private void btn_Multpl_Click(object sender, EventArgs e)
        {
            this.lblOper.Text = "*";

        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            this.lblOper.Text = "/";

        }

        private void btn_Eql_Click(object sender, EventArgs e)
        {
            //if (!double.TryParse(txb_Num1.Text, out number1))
            //{
            //    MessageBox.Show("יש להכניס מספר בלבד גדול מ0 לשדה 1");
            //    return;
            //}
            //if (!double.TryParse(txb_Num2.Text, out number2))
            //{
            //    MessageBox.Show("יש להכניס מספר בלבד גדול מ0 לשדה 2");
            //    return;
            //}
            double number1 = Calculator["Number1"];
            double number2 = Calculator["Number2"];
            switch (lblOper.Text)
            {
                case "+":
                    txb_Res.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txb_Res.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txb_Res.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txb_Res.Text = (number1 / number2).ToString();
                    break;
            }
        }
    }
}
