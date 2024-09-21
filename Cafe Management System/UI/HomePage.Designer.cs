namespace Cafe_Management_System
{
    partial class homePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            label1 = new Label();
            btn1 = new Button();
            btn2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Consolas", 25F);
            label1.ForeColor = SystemColors.ControlText;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(437, 42);
            label1.TabIndex = 0;
            label1.Text = "Cafe Management System";
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.Hand;
            btn1.FlatAppearance.BorderColor = Color.Black;
            btn1.Font = new Font("Consolas", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(152, 153);
            btn1.Name = "btn1";
            btn1.Size = new Size(136, 44);
            btn1.TabIndex = 1;
            btn1.Text = "Admin";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += login_Click;
            // 
            // btn2
            // 
            btn2.Cursor = Cursors.Hand;
            btn2.Font = new Font("Consolas", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(152, 261);
            btn2.Name = "btn2";
            btn2.Size = new Size(136, 44);
            btn2.TabIndex = 2;
            btn2.Text = "Customer";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(455, -4);
            label2.MaximumSize = new Size(340, 480);
            label2.MinimumSize = new Size(340, 480);
            label2.Name = "label2";
            label2.Size = new Size(340, 480);
            label2.TabIndex = 0;
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(label2);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "homePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn1;
        private Button btn2;
        private Label label2;
    }
}
