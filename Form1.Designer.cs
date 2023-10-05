using System.Reflection;

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
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.LightGray;
            Btn1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn1.ForeColor = Color.Black;
            Btn1.Location = new Point(12, 12);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(75, 36);
            Btn1.TabIndex = 0;
            Btn1.Text = "+";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += Btn1_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.LightGray;
            Btn2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn2.ForeColor = Color.Black;
            Btn2.Location = new Point(87, 12);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(75, 36);
            Btn2.TabIndex = 1;
            Btn2.Text = "-";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += Btn2_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.LightGray;
            Btn3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn3.ForeColor = Color.Black;
            Btn3.Location = new Point(162, 12);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(75, 36);
            Btn3.TabIndex = 2;
            Btn3.Text = "reset";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += Btn3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 33);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enabled = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            
            ClientSize = new Size(263, 128);
            Controls.Add(textBox1);
            Controls.Add(Btn3);
            Controls.Add(Btn1);
            Controls.Add(Btn2);
            Name = "Form1";
            Text = "Contador";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private TextBox textBox1;
    }
}