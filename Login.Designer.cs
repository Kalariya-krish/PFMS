namespace PFMS
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.login_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_notaMember = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "FinScope";
            // 
            // login_email
            // 
            this.login_email.BackColor = System.Drawing.Color.White;
            this.login_email.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_email.Location = new System.Drawing.Point(65, 322);
            this.login_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_email.Name = "login_email";
            this.login_email.Size = new System.Drawing.Size(357, 35);
            this.login_email.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(62, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 67;
            this.label9.Text = "Email :";
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.Color.White;
            this.login_password.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(67, 431);
            this.login_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(357, 35);
            this.login_password.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Password :";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.White;
            this.login_btn.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.login_btn.Location = new System.Drawing.Point(158, 541);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(188, 56);
            this.login_btn.TabIndex = 76;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PFMS.Properties.Resources.bar_icon;
            this.pictureBox2.Location = new System.Drawing.Point(170, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PFMS.Properties.Resources.f_logo;
            this.pictureBox1.Location = new System.Drawing.Point(133, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // login_notaMember
            // 
            this.login_notaMember.AutoSize = true;
            this.login_notaMember.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_notaMember.ForeColor = System.Drawing.Color.White;
            this.login_notaMember.Location = new System.Drawing.Point(156, 624);
            this.login_notaMember.Name = "login_notaMember";
            this.login_notaMember.Size = new System.Drawing.Size(195, 25);
            this.login_notaMember.TabIndex = 97;
            this.login_notaMember.Text = "Note a Member ?";
            this.login_notaMember.Click += new System.EventHandler(this.login_notaMember_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(491, 691);
            this.Controls.Add(this.login_notaMember);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox login_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label login_notaMember;
    }
}