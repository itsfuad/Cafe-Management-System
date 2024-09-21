namespace Cafe_Management_System.UI
{
    partial class AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(353, 364);
            label5.Name = "label5";
            label5.Size = new Size(153, 19);
            label5.TabIndex = 16;
            label5.Text = "Forgot Password?";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(447, 311);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 15;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(333, 311);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 14;
            button1.Text = "OK!";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(296, 251);
            textBox2.MaximumSize = new Size(294, 40);
            textBox2.MinimumSize = new Size(294, 40);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(294, 40);
            textBox2.TabIndex = 13;
            textBox2.Text = "Enter Password";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(296, 167);
            textBox1.MaximumSize = new Size(294, 40);
            textBox1.MinimumSize = new Size(294, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 40);
            textBox1.TabIndex = 12;
            textBox1.Text = "Enter Username";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 251);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 11;
            label3.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 167);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 10;
            label2.Text = "USERNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 25);
            label1.Name = "label1";
            label1.Size = new Size(417, 75);
            label1.TabIndex = 9;
            label1.Text = "ADMIN LOGIN";
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}