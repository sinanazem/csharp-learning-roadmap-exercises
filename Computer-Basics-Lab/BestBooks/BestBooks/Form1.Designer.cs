namespace BestBooks
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(36, 40);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 0;
            label1.Text = "Book genre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(36, 150);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 1;
            label2.Text = "Science Fiction :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(36, 112);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 2;
            label3.Text = "Romance :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(36, 188);
            label4.Name = "label4";
            label4.Size = new Size(183, 23);
            label4.TabIndex = 3;
            label4.Text = "Mystery and Thriller :";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SandyBrown;
            textBox1.Location = new Point(239, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.SaddleBrown;
            button1.Location = new Point(627, 101);
            button1.Name = "button1";
            button1.Size = new Size(124, 32);
            button1.TabIndex = 7;
            button1.Text = "Store";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.SaddleBrown;
            button2.Location = new Point(627, 141);
            button2.Name = "button2";
            button2.Size = new Size(124, 32);
            button2.TabIndex = 8;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.SaddleBrown;
            button3.Location = new Point(627, 179);
            button3.Name = "button3";
            button3.Size = new Size(124, 32);
            button3.TabIndex = 9;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.SandyBrown;
            textBox4.Location = new Point(239, 146);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(328, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.SandyBrown;
            textBox5.Location = new Point(239, 184);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(328, 27);
            textBox5.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(809, 280);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Best Books App ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}