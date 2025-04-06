using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using CalculatorLibrary;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private MainCalculator calculator;
        private double currentValue = 0;
        private char currentOperator = '+';

        private const string registryKeyPath = "Software\\YourCompanyName\\CalculatorApp";

        private Point defaultWindowLocation = new(0, 0);
        private Size defaultWindowSize = new(300, 400);
        private readonly bool defaultDarkMode = false;

        private Point currentWindowLocation;
        private Size currentWindowSize;

        private RegistryKey? calculatorKey;

        public Form1()
        {
            InitializeComponent();
            calculator = new MainCalculator();
            textBoxResult.Text = "0";

            Load += LoadSettings;
            FormClosing += SaveSettings;
        }

        private void button_Click(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            if (textBoxResult.Text == "0" && currentValue == 0)
            {
                textBoxResult.Text = buttonText;
                currentValue = double.Parse(textBoxResult.Text);
            }
            else
            {
                textBoxResult.Text += buttonText;
                currentValue = double.Parse(textBoxResult.Text);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            currentValue = 0;
            currentOperator = '+';
            textBoxResult.Text = "0";
            calculator.Result = 0;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            currentValue = double.Parse(textBoxResult.Text);
            currentOperator = '-';
            textBoxResult.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            currentValue = double.Parse(textBoxResult.Text);
            currentOperator = '+';
            textBoxResult.Clear();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            double newValue = double.Parse(textBoxResult.Text);

            if (currentOperator == '+')
            {
                calculator.Add(newValue);
            }
            else if (currentOperator == '-')
            {
                calculator.Sub(newValue);
            }
            textBoxResult.Text = calculator.Result.ToString();
        }
        private void buttonMS_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxResult.Text, out double valueToSave))
            {
                Memoryitem memitem = calculator.SaveMemory(valueToSave);

                Button MemoryItemSub = new Button();
                Button MemoryAdd = new Button();
                Button MemoryClear = new Button();
                TextBox MemoryTextBox = new TextBox();
                Panel MemoryPanel = new Panel();

                MemoryItemSub.FlatAppearance.BorderSize = 0;
                MemoryItemSub.FlatStyle = FlatStyle.Flat;
                MemoryItemSub.BackColor = Color.FromArgb(224, 224, 224);
                MemoryItemSub.ForeColor = Color.Black;
                MemoryItemSub.Location = new Point(256, 55);
                MemoryItemSub.Name = "MemorySub";
                MemoryItemSub.Size = new Size(112, 34);
                MemoryItemSub.TabIndex = 3;
                MemoryItemSub.Text = "M-";
                MemoryItemSub.UseVisualStyleBackColor = false;
                MemoryItemSub.Click += MemorySub_Click;

                MemoryAdd.FlatAppearance.BorderSize = 0;
                MemoryAdd.FlatStyle = FlatStyle.Flat;
                MemoryAdd.BackColor = Color.FromArgb(224, 224, 224);
                MemoryAdd.ForeColor = Color.Black;
                MemoryAdd.Location = new Point(138, 55);
                MemoryAdd.Name = "MemoryAdd";
                MemoryAdd.Size = new Size(112, 34);
                MemoryAdd.TabIndex = 2;
                MemoryAdd.Text = "M+";
                MemoryAdd.UseVisualStyleBackColor = false;
                MemoryAdd.Click += MemoryAdd_Click;

                MemoryClear.FlatAppearance.BorderSize = 0;
                MemoryClear.FlatStyle = FlatStyle.Flat;
                MemoryClear.BackColor = Color.FromArgb(224, 224, 224);
                MemoryClear.ForeColor = Color.Black;
                MemoryClear.Location = new Point(3, 55);
                MemoryClear.Name = "MemoryClear";
                MemoryClear.Size = new Size(129, 34);
                MemoryClear.TabIndex = 1;
                MemoryClear.Text = "MC";
                MemoryClear.UseVisualStyleBackColor = false;
                MemoryClear.Click += MemoryClear_Click;

                MemoryTextBox.BackColor = Color.White;
                MemoryTextBox.BorderStyle = BorderStyle.None;
                MemoryTextBox.Location = new Point(3, 3);
                MemoryTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
                MemoryTextBox.Multiline = true;
                MemoryTextBox.Name = "MemoryTextBox";
                MemoryTextBox.Size = new Size(365, 46);
                MemoryTextBox.RightToLeft = RightToLeft.Yes;
                MemoryTextBox.ReadOnly = true;
                MemoryTextBox.TabIndex = 0;
                MemoryTextBox.Text = textBoxResult.Text;

                MemoryPanel.Controls.Add(MemoryItemSub);
                MemoryPanel.Controls.Add(MemoryAdd);
                MemoryPanel.Controls.Add(MemoryClear);
                MemoryPanel.Controls.Add(MemoryTextBox);
                MemoryPanel.Location = new Point(3, 3);
                MemoryPanel.Name = "MemoryPanel" + flowLayoutPanel1.Controls.Count;
                MemoryPanel.Size = new Size(371, 101);
                MemoryPanel.TabIndex = 0;
                MemoryPanel.Tag = memitem;
                flowLayoutPanel1.Controls.Add(MemoryPanel);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {
            calculator.ClearMemory();
            Button clearButton = sender as Button;
            Panel panelToRemove = clearButton.Parent as Panel;
            flowLayoutPanel1.Controls.Remove(panelToRemove);
        }

        private void MemoryAdd_Click(object sender, EventArgs e)
        {
            Button addButton = sender as Button;
            Panel memoryPanel = addButton.Parent as Panel;

            Memoryitem memoryItem = memoryPanel.Tag as Memoryitem;

            if (double.TryParse(textBoxResult.Text, out double valueToAdd))
            {
                memoryItem.Add(valueToAdd);
                TextBox memoryTextBox = memoryPanel.Controls["MemoryTextBox"] as TextBox;
                memoryTextBox.Text = memoryItem.SanasanToo.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void MemorySub_Click(object sender, EventArgs e)
        {
            Button subButton = sender as Button;
            Panel memoryPanel = subButton.Parent as Panel;

            Memoryitem memoryItem = memoryPanel.Tag as Memoryitem;

            if (double.TryParse(textBoxResult.Text, out double valueToSubtract))
            {
                memoryItem.Sub(valueToSubtract);
                TextBox memoryTextBox = memoryPanel.Controls["MemoryTextBox"] as TextBox;
                memoryTextBox.Text = memoryItem.SanasanToo.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            calculatorKey = Registry.CurrentUser.OpenSubKey(registryKeyPath, true) ?? Registry.CurrentUser.CreateSubKey(registryKeyPath);

            calculatorKey.SetValue("WindowLocationX", this.Location.X);
            calculatorKey.SetValue("WindowLocationY", this.Location.Y);
            calculatorKey.SetValue("WindowSizeWidth", this.Size.Width);
            calculatorKey.SetValue("WindowSizeHeight", this.Size.Height);
        }

        private void LoadSettings(object sender, EventArgs e)
        {
            calculatorKey = Registry.CurrentUser.OpenSubKey(registryKeyPath, true) ?? Registry.CurrentUser.CreateSubKey(registryKeyPath);

            int windowLocationX = (int)(calculatorKey.GetValue("WindowLocationX") ?? defaultWindowLocation.X);
            int windowLocationY = (int)(calculatorKey.GetValue("WindowLocationY") ?? defaultWindowLocation.Y);
            int windowSizeWidth = (int)(calculatorKey.GetValue("WindowSizeWidth") ?? defaultWindowSize.Width);
            int windowSizeHeight = (int)(calculatorKey.GetValue("WindowSizeHeight") ?? defaultWindowSize.Height);

            currentWindowLocation = new Point(windowLocationX, windowLocationY);
            currentWindowSize = new Size(windowSizeWidth, windowSizeHeight);

            this.Location = currentWindowLocation;
            this.Size = currentWindowSize;
        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
