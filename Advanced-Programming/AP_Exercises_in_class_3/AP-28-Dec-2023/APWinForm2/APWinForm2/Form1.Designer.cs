namespace APWinForm2
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
            txt_num1 = new TextBox();
            txt_num3 = new TextBox();
            txt_num2 = new TextBox();
            txt_num4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(228, 94);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(247, 27);
            txt_num1.TabIndex = 0;
            // 
            // txt_num3
            // 
            txt_num3.Location = new Point(228, 187);
            txt_num3.Name = "txt_num3";
            txt_num3.Size = new Size(247, 27);
            txt_num3.TabIndex = 1;
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(228, 141);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(247, 27);
            txt_num2.TabIndex = 2;
            // 
            // txt_num4
            // 
            txt_num4.Location = new Point(228, 233);
            txt_num4.Name = "txt_num4";
            txt_num4.Size = new Size(247, 27);
            txt_num4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(126, 95);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 4;
            label1.Text = "Number 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(126, 145);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 5;
            label2.Text = "Number 2: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(126, 191);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 6;
            label3.Text = "Number 3:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(126, 237);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 7;
            label4.Text = "Number 4:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(246, 304);
            button1.Name = "button1";
            button1.Size = new Size(171, 46);
            button1.TabIndex = 8;
            button1.Text = "Mean";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(302, 373);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 9;
            label5.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(623, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_num4);
            Controls.Add(txt_num2);
            Controls.Add(txt_num3);
            Controls.Add(txt_num1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_num1;
        private TextBox txt_num3;
        private TextBox txt_num2;
        private TextBox txt_num4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}