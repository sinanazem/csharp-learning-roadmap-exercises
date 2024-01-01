namespace APWindowsForm
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
            txt_name = new TextBox();
            txt_family = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_ok = new Button();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.BackColor = SystemColors.InactiveCaption;
            txt_name.Location = new Point(198, 60);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(335, 35);
            txt_name.TabIndex = 0;
            txt_name.TextChanged += textBox1_TextChanged;
            // 
            // txt_family
            // 
            txt_family.BackColor = SystemColors.InactiveCaption;
            txt_family.Location = new Point(198, 122);
            txt_family.Multiline = true;
            txt_family.Name = "txt_family";
            txt_family.Size = new Size(335, 35);
            txt_family.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(117, 72);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(117, 123);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 3;
            label2.Text = "Family:";
            label2.Click += label2_Click;
            // 
            // btn_ok
            // 
            btn_ok.BackColor = Color.Orange;
            btn_ok.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.Location = new Point(282, 209);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(168, 29);
            btn_ok.TabIndex = 4;
            btn_ok.Text = "Enter";
            btn_ok.UseVisualStyleBackColor = false;
            btn_ok.Click += btn_ok_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(713, 417);
            Controls.Add(btn_ok);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_family);
            Controls.Add(txt_name);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_family;
        private Label label1;
        private Label label2;
        private Button btn_ok;
    }
}