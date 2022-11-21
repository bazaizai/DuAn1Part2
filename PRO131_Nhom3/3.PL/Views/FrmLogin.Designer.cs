﻿namespace _3.PL.Views
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.tb_tk = new System.Windows.Forms.TextBox();
            this.lb_ForgotPassword = new System.Windows.Forms.Label();
            this.btn_Login = new CustomControls.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.cb_save = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.tb_mk);
            this.panel1.Controls.Add(this.tb_tk);
            this.panel1.Controls.Add(this.lb_ForgotPassword);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rjCircularPictureBox1);
            this.panel1.Controls.Add(this.cb_save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 805);
            this.panel1.TabIndex = 0;
            // 
            // tb_mk
            // 
            this.tb_mk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.tb_mk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_mk.ForeColor = System.Drawing.Color.Black;
            this.tb_mk.Location = new System.Drawing.Point(262, 531);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.PasswordChar = '*';
            this.tb_mk.Size = new System.Drawing.Size(305, 31);
            this.tb_mk.TabIndex = 22;
            this.tb_mk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_mk_MouseClick);
            // 
            // tb_tk
            // 
            this.tb_tk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.tb_tk.ForeColor = System.Drawing.Color.Black;
            this.tb_tk.Location = new System.Drawing.Point(262, 461);
            this.tb_tk.Name = "tb_tk";
            this.tb_tk.Size = new System.Drawing.Size(305, 31);
            this.tb_tk.TabIndex = 21;
            this.tb_tk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_tk_MouseClick);
            // 
            // lb_ForgotPassword
            // 
            this.lb_ForgotPassword.AutoSize = true;
            this.lb_ForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lb_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_ForgotPassword.ForeColor = System.Drawing.Color.Black;
            this.lb_ForgotPassword.Location = new System.Drawing.Point(401, 607);
            this.lb_ForgotPassword.Name = "lb_ForgotPassword";
            this.lb_ForgotPassword.Size = new System.Drawing.Size(166, 25);
            this.lb_ForgotPassword.TabIndex = 20;
            this.lb_ForgotPassword.Text = "Forgot password ?";
            this.lb_ForgotPassword.Click += new System.EventHandler(this.lb_ForgotPassword_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_Login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(157)))));
            this.btn_Login.BorderColor = System.Drawing.Color.HotPink;
            this.btn_Login.BorderRadius = 0;
            this.btn_Login.BorderSize = 0;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.Black;
            this.btn_Login.Location = new System.Drawing.Point(123, 697);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(444, 38);
            this.btn_Login.TabIndex = 19;
            this.btn_Login.Text = "Sign In";
            this.btn_Login.TextColor = System.Drawing.Color.Black;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(284, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sign In ";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(219, 68);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(261, 261);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 15;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // cb_save
            // 
            this.cb_save.AutoSize = true;
            this.cb_save.BackColor = System.Drawing.Color.Transparent;
            this.cb_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_save.ForeColor = System.Drawing.Color.Black;
            this.cb_save.Location = new System.Drawing.Point(123, 607);
            this.cb_save.Name = "cb_save";
            this.cb_save.Size = new System.Drawing.Size(192, 29);
            this.cb_save.TabIndex = 14;
            this.cb_save.Text = "Duy trì đăng nhập";
            this.cb_save.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(123, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(122, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tài khoản";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 805);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_ForgotPassword;
        private CustomControls.RJControls.RJButton btn_Login;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.CheckBox cb_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.TextBox tb_tk;
    }
}