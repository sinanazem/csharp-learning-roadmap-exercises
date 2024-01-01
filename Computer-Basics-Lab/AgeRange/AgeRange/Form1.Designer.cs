namespace AgeRange
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
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(133, 60);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(133, 110);
            label2.Name = "label2";
            label2.Size = new Size(164, 28);
            label2.TabIndex = 1;
            label2.Text = "Enter Your Age: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Plum;
            textBox1.Location = new Point(322, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Plum;
            textBox3.Location = new Point(322, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 27);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(322, 219);
            label3.Name = "label3";
            label3.Size = new Size(27, 28);
            label3.TabIndex = 5;
            label3.Text = "...";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Location = new Point(466, 158);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 6;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Location = new Point(547, 158);
            button2.Name = "button2";
            button2.Size = new Size(75, 38);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.BlueViolet;
            button3.Location = new Point(322, 158);
            button3.Name = "button3";
            button3.Size = new Size(138, 38);
            button3.TabIndex = 8;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.cool_colors_wallpaper;
            ClientSize = new Size(916, 388);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Age Range App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}