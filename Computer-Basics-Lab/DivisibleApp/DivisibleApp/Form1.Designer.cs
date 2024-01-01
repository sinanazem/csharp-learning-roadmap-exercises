namespace DivisibleApp
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(83, 50);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 0;
            label1.Text = "Range : ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.IndianRed;
            textBox1.Location = new Point(156, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.IndianRed;
            textBox2.Location = new Point(292, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(259, 53);
            label2.Name = "label2";
            label2.Size = new Size(27, 23);
            label2.TabIndex = 3;
            label2.Text = "to";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightCoral;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(156, 121);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(97, 144);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.LightCoral;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(292, 121);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(97, 144);
            listBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(292, 101);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 6;
            label3.Text = "Divisible by 3 : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RosyBrown;
            label4.Location = new Point(156, 101);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 7;
            label4.Text = "All Numbers : ";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(413, 86);
            button1.Name = "button1";
            button1.Size = new Size(80, 27);
            button1.TabIndex = 8;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkRed;
            button2.Location = new Point(413, 53);
            button2.Name = "button2";
            button2.Size = new Size(80, 27);
            button2.TabIndex = 9;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkRed;
            button3.Location = new Point(413, 238);
            button3.Name = "button3";
            button3.Size = new Size(80, 27);
            button3.TabIndex = 10;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(574, 315);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}