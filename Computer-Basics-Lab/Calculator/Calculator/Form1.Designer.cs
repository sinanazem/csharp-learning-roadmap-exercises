namespace Calculator
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button_exit = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(102, 64);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(102, 110);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Second Number : ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Location = new Point(277, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Location = new Point(277, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.LightCoral;
            button_exit.Location = new Point(12, 298);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(105, 29);
            button_exit.TabIndex = 4;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Location = new Point(579, 64);
            button2.Name = "button2";
            button2.Size = new Size(105, 29);
            button2.TabIndex = 5;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(128, 64, 64);
            button3.Location = new Point(424, 187);
            button3.Name = "button3";
            button3.Size = new Size(131, 29);
            button3.TabIndex = 6;
            button3.Text = "Multiply";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.Goldenrod;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(128, 64, 64);
            button4.Location = new Point(277, 151);
            button4.Name = "button4";
            button4.Size = new Size(131, 29);
            button4.TabIndex = 7;
            button4.Text = "Sum";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Goldenrod;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(128, 64, 64);
            button5.Location = new Point(277, 187);
            button5.Name = "button5";
            button5.Size = new Size(131, 29);
            button5.TabIndex = 8;
            button5.Text = "Division";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Goldenrod;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(128, 64, 64);
            button6.Location = new Point(424, 151);
            button6.Name = "button6";
            button6.Size = new Size(131, 29);
            button6.TabIndex = 9;
            button6.Text = "Subtract";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(277, 244);
            label3.Name = "label3";
            label3.Size = new Size(27, 28);
            label3.TabIndex = 10;
            label3.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(783, 339);
            Controls.Add(label3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button_exit);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button_exit;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label3;
    }
}