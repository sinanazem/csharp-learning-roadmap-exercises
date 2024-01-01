namespace SayHello
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
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 52);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter your name:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.Location = new Point(133, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Location = new Point(358, 78);
            button1.Name = "button1";
            button1.Size = new Size(106, 25);
            button1.TabIndex = 2;
            button1.Text = "Say Hello";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 124);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 3;
            label2.Text = "...";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            label2.MouseLeave += label2_MouseLeave;
            label2.MouseMove += label2_MouseMove;
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.Location = new Point(246, 78);
            button2.Name = "button2";
            button2.Size = new Size(106, 25);
            button2.TabIndex = 4;
            button2.Text = "Clean";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Salmon;
            button3.Location = new Point(134, 78);
            button3.Name = "button3";
            button3.Size = new Size(106, 25);
            button3.TabIndex = 5;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(569, 196);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Say Hello App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}