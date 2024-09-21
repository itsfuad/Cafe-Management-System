namespace Cafe_Management_System.UI
{
    partial class logInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logInPage));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 9);
            label1.Name = "label1";
            label1.Size = new Size(382, 75);
            label1.TabIndex = 0;
            label1.Text = "USER LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 150);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 1;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(111, 234);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(270, 150);
            textBox1.MaximumSize = new Size(294, 40);
            textBox1.MinimumSize = new Size(294, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 40);
            textBox1.TabIndex = 3;
            textBox1.Text = "Enter Username";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Click += textBox1_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(270, 234);
            textBox2.MaximumSize = new Size(294, 40);
            textBox2.MinimumSize = new Size(294, 40);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(294, 40);
            textBox2.TabIndex = 4;
            textBox2.Text = "Enter Password";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Click += textBox2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(307, 294);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 5;
            button1.Text = "OK!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(181, 386);
            label4.Name = "label4";
            label4.Size = new Size(450, 19);
            label4.TabIndex = 6;
            label4.Text = "Don't have any account? Simply create an account!";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(421, 294);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 7;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(327, 347);
            label5.Name = "label5";
            label5.Size = new Size(153, 19);
            label5.TabIndex = 8;
            label5.Text = "Forgot Password?";
            // 
            // logInPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "logInPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private Button button2;
        private Label label5;
    }
}