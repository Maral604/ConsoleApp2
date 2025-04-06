using System;
using System.Windows.Forms;
using CalculatorLibrary;

namespace FormCalculator
{
    public partial class Form1 : Form
    {
        MainCalculator calc = new MainCalculator();
        string input = "";
        string currentOperator = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text == "0" && input == "")
            {
                textBox1.Text = btn.Text;
                input = textBox1.Text;
            }
            else
            {
                input += btn.Text;
                textBox1.Text = input;
            }
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (double.TryParse(input, out double value))
            {
                if (currentOperator == "+")
                    calc.Add(value);
                else if (currentOperator == "-")
                    calc.Sub(value);
                else
                    calc.Result = value;

                input = "";
                textBox1.Text = calc.Result.ToString();
            }
            currentOperator = btn.Text;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input, out double value))
            {
                if (currentOperator == "+")
                    calc.Add(value);
                else if (currentOperator == "-")
                    calc.Sub(value);

                textBox1.Text = calc.Result.ToString();
                input = "";
                currentOperator = "";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            calc.Clear();
            input = "";
            currentOperator = "";
            textBox1.Text = "0";
        }

        private void MS_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            if (double.TryParse(textBox1.Text, out double value))
            {
                calc.SaveMemory(value);
            }
        }
        private double memoryValue = 0;
        private void MAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double value))
            {
                memoryValue += value;
                calc.SaveMemory(memoryValue); 
                textBox2.Text = memoryValue.ToString(); 
            }
        }
        private void MMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double value))
            {
                memoryValue -= value;
                calc.SaveMemory(memoryValue);
                textBox2.Text = memoryValue.ToString(); 
            }
        }

        private void MC_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
            calc.ClearMemory();
            textBox1.Text = textBox2.Text;
            textBox2.Text = "0"; // дэлгэц дээрх санах ойг 0 болгоно
        }
    }
}
