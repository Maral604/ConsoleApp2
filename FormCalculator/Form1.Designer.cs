namespace FormCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 158);
            button1.Name = "button1";
            button1.Size = new Size(124, 84);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Number_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 110);
            button2.Name = "button2";
            button2.Size = new Size(245, 51);
            button2.TabIndex = 3;
            button2.Text = "MS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += MS_Click;
            // 
            // button3
            // 
            button3.Location = new Point(244, 110);
            button3.Name = "button3";
            button3.Size = new Size(247, 51);
            button3.TabIndex = 4;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Clear_Click;
            // 
            // button4
            // 
            button4.Location = new Point(125, 158);
            button4.Name = "button4";
            button4.Size = new Size(124, 84);
            button4.TabIndex = 5;
            button4.Text = "8";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Number_Click;
            // 
            // button5
            // 
            button5.Location = new Point(244, 158);
            button5.Name = "button5";
            button5.Size = new Size(124, 84);
            button5.TabIndex = 6;
            button5.Text = "9";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Number_Click;
            // 
            // button6
            // 
            button6.Location = new Point(244, 237);
            button6.Name = "button6";
            button6.Size = new Size(124, 84);
            button6.TabIndex = 9;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Number_Click;
            // 
            // button7
            // 
            button7.Location = new Point(125, 237);
            button7.Name = "button7";
            button7.Size = new Size(124, 84);
            button7.TabIndex = 8;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Number_Click;
            // 
            // button8
            // 
            button8.Location = new Point(3, 237);
            button8.Name = "button8";
            button8.Size = new Size(124, 84);
            button8.TabIndex = 7;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Number_Click;
            // 
            // button9
            // 
            button9.Location = new Point(244, 317);
            button9.Name = "button9";
            button9.Size = new Size(124, 84);
            button9.TabIndex = 12;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Number_Click;
            // 
            // button10
            // 
            button10.Location = new Point(125, 317);
            button10.Name = "button10";
            button10.Size = new Size(124, 84);
            button10.TabIndex = 11;
            button10.Text = "2";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Number_Click;
            // 
            // button11
            // 
            button11.Location = new Point(3, 317);
            button11.Name = "button11";
            button11.Size = new Size(124, 84);
            button11.TabIndex = 10;
            button11.Text = "1";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Number_Click;
            // 
            // button12
            // 
            button12.Location = new Point(3, 399);
            button12.Name = "button12";
            button12.Size = new Size(365, 84);
            button12.TabIndex = 13;
            button12.Text = "0";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Number_Click;
            // 
            // button13
            // 
            button13.Location = new Point(366, 158);
            button13.Name = "button13";
            button13.Size = new Size(124, 126);
            button13.TabIndex = 14;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Operator_Click;
            // 
            // button14
            // 
            button14.Location = new Point(366, 275);
            button14.Name = "button14";
            button14.RightToLeft = RightToLeft.Yes;
            button14.Size = new Size(124, 126);
            button14.TabIndex = 15;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Operator_Click;
            // 
            // button15
            // 
            button15.Location = new Point(365, 399);
            button15.Name = "button15";
            button15.Size = new Size(124, 84);
            button15.TabIndex = 16;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Equal_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.Font = new Font("Segoe UI", 28F);
            textBox1.Location = new Point(4, 37);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(486, 70);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.Location = new Point(510, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 47);
            textBox2.TabIndex = 17;
            textBox2.Text = "0";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // button16
            // 
            button16.Location = new Point(510, 85);
            button16.Name = "button16";
            button16.Size = new Size(81, 35);
            button16.TabIndex = 18;
            button16.Text = "M+";
            button16.UseVisualStyleBackColor = true;
            button16.Click += MAdd_Click;
            // 
            // button17
            // 
            button17.Location = new Point(590, 84);
            button17.Name = "button17";
            button17.Size = new Size(81, 35);
            button17.TabIndex = 19;
            button17.Text = "M-";
            button17.UseVisualStyleBackColor = true;
            button17.Click += MMinus_Click;
            // 
            // button18
            // 
            button18.Location = new Point(670, 84);
            button18.Name = "button18";
            button18.Size = new Size(81, 35);
            button18.TabIndex = 20;
            button18.Text = "MC";
            button18.UseVisualStyleBackColor = true;
            button18.Click += MC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 486);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Maral's Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button16;
        private Button button17;
        private Button button18;
    }
}
