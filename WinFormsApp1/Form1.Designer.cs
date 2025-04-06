namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            textBoxResult = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button0 = new Button();
            buttonMS = new Button();
            buttonAdd = new Button();
            buttonSub = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button9 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonSum = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            buttonClear = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = Color.White;
            textBoxResult.BorderStyle = BorderStyle.None;
            textBoxResult.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxResult.ForeColor = Color.Black;
            textBoxResult.Location = new Point(37, 76);
            textBoxResult.Margin = new Padding(2);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.RightToLeft = RightToLeft.Yes;
            textBoxResult.Size = new Size(482, 76);
            textBoxResult.TabIndex = 1;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(37, 242);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(117, 74);
            button7.TabIndex = 2;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(158, 242);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(115, 74);
            button8.TabIndex = 3;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.White;
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button0.ForeColor = Color.Black;
            button0.Location = new Point(37, 506);
            button0.Margin = new Padding(2);
            button0.Name = "button0";
            button0.Size = new Size(357, 70);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button_Click;
            // 
            // buttonMS
            // 
            buttonMS.BackColor = Color.Transparent;
            buttonMS.FlatAppearance.BorderSize = 0;
            buttonMS.FlatStyle = FlatStyle.Flat;
            buttonMS.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMS.ForeColor = Color.Black;
            buttonMS.Location = new Point(37, 165);
            buttonMS.Margin = new Padding(2);
            buttonMS.Name = "buttonMS";
            buttonMS.Size = new Size(237, 57);
            buttonMS.TabIndex = 12;
            buttonMS.Text = "MS";
            buttonMS.UseVisualStyleBackColor = false;
            buttonMS.Click += buttonMS_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.Black;
            buttonAdd.Location = new Point(409, 242);
            buttonAdd.Margin = new Padding(2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(102, 90);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSub
            // 
            buttonSub.BackColor = Color.White;
            buttonSub.FlatAppearance.BorderSize = 0;
            buttonSub.FlatStyle = FlatStyle.Flat;
            buttonSub.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSub.ForeColor = Color.Black;
            buttonSub.Location = new Point(409, 344);
            buttonSub.Margin = new Padding(2);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(102, 90);
            buttonSub.TabIndex = 14;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = false;
            buttonSub.Click += buttonSub_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.FlatAppearance.BorderColor = Color.White;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(278, 242);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(115, 74);
            button9.TabIndex = 15;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(278, 330);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(115, 74);
            button6.TabIndex = 18;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(158, 330);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(115, 74);
            button5.TabIndex = 17;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(37, 330);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(117, 74);
            button4.TabIndex = 16;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(278, 417);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(115, 74);
            button3.TabIndex = 21;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(158, 417);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(115, 74);
            button2.TabIndex = 20;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(37, 417);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(117, 74);
            button1.TabIndex = 19;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // buttonSum
            // 
            buttonSum.BackColor = Color.White;
            buttonSum.FlatAppearance.BorderSize = 0;
            buttonSum.FlatStyle = FlatStyle.Flat;
            buttonSum.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSum.ForeColor = Color.Black;
            buttonSum.Location = new Point(409, 449);
            buttonSum.Margin = new Padding(2);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(102, 127);
            buttonSum.TabIndex = 22;
            buttonSum.Text = "=";
            buttonSum.UseVisualStyleBackColor = false;
            buttonSum.Click += buttonSum_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Transparent;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.ForeColor = Color.Black;
            buttonClear.Location = new Point(281, 165);
            buttonClear.Margin = new Padding(2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(230, 57);
            buttonClear.TabIndex = 23;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(553, 36);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(299, 540);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(886, 684);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonClear);
            Controls.Add(buttonSum);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button9);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(buttonMS);
            Controls.Add(button0);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBoxResult);
            ForeColor = Color.White;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Maral's Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxResult;
        private Button button7;
        private Button button8;
        private Button button0;
        private Button buttonMS;
        private Button buttonAdd;
        private Button buttonSub;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button9;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonSum;
        private ContextMenuStrip contextMenuStrip1;
        private Button buttonClear;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
