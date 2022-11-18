namespace _3.PL.Views
{
    partial class FrmQuenMatKhau
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
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(131, 165);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(387, 31);
            this.tb_email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vui lòng nhập Email";
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xacNhan.Location = new System.Drawing.Point(266, 251);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(112, 34);
            this.btn_xacNhan.TabIndex = 3;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = true;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // FrmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 658);
            this.Controls.Add(this.btn_xacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_email);
            this.Name = "FrmQuenMatKhau";
            this.Text = "FrmQuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xacNhan;
    }
}