namespace MultiplicationTable
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
            listView1 = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.RoyalBlue;
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.ForeColor = Color.DarkBlue;
            listView1.Location = new Point(107, 93);
            listView1.Name = "listView1";
            listView1.Size = new Size(567, 546);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(226, 35);
            button1.Name = "button1";
            button1.Size = new Size(341, 43);
            button1.TabIndex = 2;
            button1.Text = "Multiplication Table (10x10)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(756, 731);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Multiplication Table";
            ResumeLayout(false);
        }

        #endregion
        private ListView listView1;
        private Button button1;
    }
}