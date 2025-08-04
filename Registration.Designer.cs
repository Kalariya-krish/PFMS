namespace PFMS
{
    partial class Registration
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
            this.register_btn = new System.Windows.Forms.Button();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.register_close = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.reg_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reg_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_dob = new System.Windows.Forms.DateTimePicker();
            this.reg_backtoLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.register_close)).BeginInit();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.White;
            this.register_btn.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.register_btn.Location = new System.Drawing.Point(380, 563);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(188, 56);
            this.register_btn.TabIndex = 84;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // reg_email
            // 
            this.reg_email.BackColor = System.Drawing.Color.White;
            this.reg_email.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_email.Location = new System.Drawing.Point(83, 328);
            this.reg_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(357, 35);
            this.reg_email.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "Email :";
            // 
            // reg_username
            // 
            this.reg_username.BackColor = System.Drawing.Color.White;
            this.reg_username.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_username.Location = new System.Drawing.Point(83, 219);
            this.reg_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(357, 35);
            this.reg_username.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(80, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 79;
            this.label9.Text = "Username :";
            // 
            // register_close
            // 
            this.register_close.Image = global::PFMS.Properties.Resources.close_icon;
            this.register_close.Location = new System.Drawing.Point(887, 12);
            this.register_close.Name = "register_close";
            this.register_close.Size = new System.Drawing.Size(50, 50);
            this.register_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.register_close.TabIndex = 85;
            this.register_close.TabStop = false;
            this.register_close.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(373, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 39);
            this.label14.TabIndex = 86;
            this.label14.Text = "Registration";
            // 
            // reg_address
            // 
            this.reg_address.BackColor = System.Drawing.Color.White;
            this.reg_address.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_address.Location = new System.Drawing.Point(503, 433);
            this.reg_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg_address.Multiline = true;
            this.reg_address.Name = "reg_address";
            this.reg_address.Size = new System.Drawing.Size(357, 79);
            this.reg_address.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(504, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 89;
            this.label1.Text = "Address :";
            // 
            // reg_phone
            // 
            this.reg_phone.BackColor = System.Drawing.Color.White;
            this.reg_phone.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_phone.Location = new System.Drawing.Point(83, 433);
            this.reg_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg_phone.Name = "reg_phone";
            this.reg_phone.Size = new System.Drawing.Size(357, 35);
            this.reg_phone.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 87;
            this.label3.Text = "Phone Number :";
            // 
            // reg_password
            // 
            this.reg_password.BackColor = System.Drawing.Color.White;
            this.reg_password.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_password.Location = new System.Drawing.Point(503, 328);
            this.reg_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg_password.Name = "reg_password";
            this.reg_password.Size = new System.Drawing.Size(357, 35);
            this.reg_password.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(500, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 93;
            this.label4.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(498, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 91;
            this.label5.Text = "DOB :";
            // 
            // reg_dob
            // 
            this.reg_dob.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reg_dob.Location = new System.Drawing.Point(503, 219);
            this.reg_dob.Name = "reg_dob";
            this.reg_dob.Size = new System.Drawing.Size(351, 35);
            this.reg_dob.TabIndex = 95;
            this.reg_dob.Value = new System.DateTime(2025, 8, 27, 0, 0, 0, 0);
            // 
            // reg_backtoLogin
            // 
            this.reg_backtoLogin.AutoSize = true;
            this.reg_backtoLogin.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_backtoLogin.ForeColor = System.Drawing.Color.White;
            this.reg_backtoLogin.Location = new System.Drawing.Point(392, 641);
            this.reg_backtoLogin.Name = "reg_backtoLogin";
            this.reg_backtoLogin.Size = new System.Drawing.Size(162, 25);
            this.reg_backtoLogin.TabIndex = 96;
            this.reg_backtoLogin.Text = "Back to Login";
            this.reg_backtoLogin.Click += new System.EventHandler(this.reg_backtoLogin_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(949, 691);
            this.Controls.Add(this.reg_backtoLogin);
            this.Controls.Add(this.reg_dob);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reg_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reg_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.register_close);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.reg_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.label9);
            this.Name = "Registration";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.register_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox reg_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox register_close;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox reg_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reg_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker reg_dob;
        private System.Windows.Forms.Label reg_backtoLogin;
    }
}