namespace _3.PL.Views
{
    partial class FrmChiTietSale
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
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_mucgiam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_Sale = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck_all = new System.Windows.Forms.CheckBox();
            this.dtg_sp = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtg_sale = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_locTrangthai = new System.Windows.Forms.ComboBox();
            this.cbb_locKM = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ma = new CustomControls.RJControls.RJTextBox();
            this.tb_ten = new CustomControls.RJControls.RJTextBox();
            this.tb_mucgiam = new CustomControls.RJControls.RJTextBox();
            this.tb_mota = new CustomControls.RJControls.RJTextBox();
            this.cbb_loaiKM = new CustomControls.RJControls.RJComboBox();
            this.cbb_trangthai = new CustomControls.RJControls.RJComboBox();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_timkm = new System.Windows.Forms.Button();
            this.tb_timkiemkm = new System.Windows.Forms.TextBox();
            this.grb_Sale.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sale)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(220, 388);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(238, 23);
            this.dtp_end.TabIndex = 94;
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(220, 336);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(238, 23);
            this.dtp_start.TabIndex = 93;
            this.dtp_start.Value = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(64, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 90;
            this.label9.Text = "Mô tả:";
            // 
            // lb_mucgiam
            // 
            this.lb_mucgiam.AutoSize = true;
            this.lb_mucgiam.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_mucgiam.Location = new System.Drawing.Point(64, 286);
            this.lb_mucgiam.Name = "lb_mucgiam";
            this.lb_mucgiam.Size = new System.Drawing.Size(104, 25);
            this.lb_mucgiam.TabIndex = 89;
            this.lb_mucgiam.Text = "Mức giảm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(64, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 88;
            this.label7.Text = "Loại khuyến mại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(64, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 87;
            this.label6.Text = "Ngày kết thúc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 86;
            this.label5.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "Tên khuyến mại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mã khuyến mại:";
            // 
            // grb_Sale
            // 
            this.grb_Sale.Controls.Add(this.cbb_trangthai);
            this.grb_Sale.Controls.Add(this.cbb_loaiKM);
            this.grb_Sale.Controls.Add(this.tb_mota);
            this.grb_Sale.Controls.Add(this.tb_mucgiam);
            this.grb_Sale.Controls.Add(this.tb_ten);
            this.grb_Sale.Controls.Add(this.tb_ma);
            this.grb_Sale.Controls.Add(this.label4);
            this.grb_Sale.Controls.Add(this.bt_capnhat);
            this.grb_Sale.Controls.Add(this.bt_them);
            this.grb_Sale.Controls.Add(this.label1);
            this.grb_Sale.Controls.Add(this.dtp_end);
            this.grb_Sale.Controls.Add(this.dtp_start);
            this.grb_Sale.Controls.Add(this.label2);
            this.grb_Sale.Controls.Add(this.label3);
            this.grb_Sale.Controls.Add(this.label5);
            this.grb_Sale.Controls.Add(this.label9);
            this.grb_Sale.Controls.Add(this.label6);
            this.grb_Sale.Controls.Add(this.lb_mucgiam);
            this.grb_Sale.Controls.Add(this.label7);
            this.grb_Sale.Location = new System.Drawing.Point(24, 12);
            this.grb_Sale.Name = "grb_Sale";
            this.grb_Sale.Size = new System.Drawing.Size(576, 612);
            this.grb_Sale.TabIndex = 97;
            this.grb_Sale.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(180, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 62);
            this.label4.TabIndex = 100;
            this.label4.Text = "Sale";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ck_all);
            this.groupBox1.Controls.Add(this.dtg_sp);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtg_sale);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbb_locTrangthai);
            this.groupBox1.Controls.Add(this.bt_timkm);
            this.groupBox1.Controls.Add(this.cbb_locKM);
            this.groupBox1.Controls.Add(this.tb_timkiemkm);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(606, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 612);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            // 
            // ck_all
            // 
            this.ck_all.AutoSize = true;
            this.ck_all.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ck_all.Location = new System.Drawing.Point(504, 308);
            this.ck_all.Name = "ck_all";
            this.ck_all.Size = new System.Drawing.Size(59, 19);
            this.ck_all.TabIndex = 16;
            this.ck_all.Text = "Tất cả";
            this.ck_all.UseVisualStyleBackColor = true;
            // 
            // dtg_sp
            // 
            this.dtg_sp.AllowUserToAddRows = false;
            this.dtg_sp.AllowUserToDeleteRows = false;
            this.dtg_sp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_sp.Location = new System.Drawing.Point(24, 345);
            this.dtg_sp.Name = "dtg_sp";
            this.dtg_sp.ReadOnly = true;
            this.dtg_sp.RowTemplate.Height = 25;
            this.dtg_sp.Size = new System.Drawing.Size(539, 228);
            this.dtg_sp.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(337, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Loại SP";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(256, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(337, 304);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(161, 23);
            this.comboBox3.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 23);
            this.textBox1.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(24, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tìm sản phẩm";
            // 
            // dtg_sale
            // 
            this.dtg_sale.AllowUserToAddRows = false;
            this.dtg_sale.AllowUserToDeleteRows = false;
            this.dtg_sale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_sale.Location = new System.Drawing.Point(29, 78);
            this.dtg_sale.Name = "dtg_sale";
            this.dtg_sale.ReadOnly = true;
            this.dtg_sale.RowTemplate.Height = 25;
            this.dtg_sale.Size = new System.Drawing.Size(539, 183);
            this.dtg_sale.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(405, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Trạng thái";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(341, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Loại KM";
            // 
            // cbb_locTrangthai
            // 
            this.cbb_locTrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_locTrangthai.FormattingEnabled = true;
            this.cbb_locTrangthai.Location = new System.Drawing.Point(405, 35);
            this.cbb_locTrangthai.Name = "cbb_locTrangthai";
            this.cbb_locTrangthai.Size = new System.Drawing.Size(163, 23);
            this.cbb_locTrangthai.TabIndex = 4;
            // 
            // cbb_locKM
            // 
            this.cbb_locKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_locKM.FormattingEnabled = true;
            this.cbb_locKM.Location = new System.Drawing.Point(341, 35);
            this.cbb_locKM.Name = "cbb_locKM";
            this.cbb_locKM.Size = new System.Drawing.Size(58, 23);
            this.cbb_locKM.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(28, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm khuyến mại";
            // 
            // tb_ma
            // 
            this.tb_ma.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ma.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_ma.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_ma.BorderRadius = 0;
            this.tb_ma.BorderSize = 1;
            this.tb_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ma.Location = new System.Drawing.Point(220, 123);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ma.Multiline = false;
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_ma.PasswordChar = false;
            this.tb_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ma.PlaceholderText = "";
            this.tb_ma.Size = new System.Drawing.Size(238, 31);
            this.tb_ma.TabIndex = 101;
            this.tb_ma.Texts = "";
            this.tb_ma.UnderlinedStyle = false;
            // 
            // tb_ten
            // 
            this.tb_ten.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ten.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_ten.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_ten.BorderRadius = 0;
            this.tb_ten.BorderSize = 1;
            this.tb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ten.Location = new System.Drawing.Point(220, 168);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ten.Multiline = false;
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_ten.PasswordChar = false;
            this.tb_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ten.PlaceholderText = "";
            this.tb_ten.Size = new System.Drawing.Size(238, 31);
            this.tb_ten.TabIndex = 102;
            this.tb_ten.Texts = "";
            this.tb_ten.UnderlinedStyle = false;
            // 
            // tb_mucgiam
            // 
            this.tb_mucgiam.BackColor = System.Drawing.SystemColors.Window;
            this.tb_mucgiam.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_mucgiam.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_mucgiam.BorderRadius = 0;
            this.tb_mucgiam.BorderSize = 1;
            this.tb_mucgiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mucgiam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_mucgiam.Location = new System.Drawing.Point(220, 286);
            this.tb_mucgiam.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mucgiam.Multiline = false;
            this.tb_mucgiam.Name = "tb_mucgiam";
            this.tb_mucgiam.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_mucgiam.PasswordChar = false;
            this.tb_mucgiam.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_mucgiam.PlaceholderText = "";
            this.tb_mucgiam.Size = new System.Drawing.Size(241, 31);
            this.tb_mucgiam.TabIndex = 103;
            this.tb_mucgiam.Texts = "";
            this.tb_mucgiam.UnderlinedStyle = false;
            // 
            // tb_mota
            // 
            this.tb_mota.BackColor = System.Drawing.SystemColors.Window;
            this.tb_mota.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_mota.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_mota.BorderRadius = 0;
            this.tb_mota.BorderSize = 1;
            this.tb_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_mota.Location = new System.Drawing.Point(220, 436);
            this.tb_mota.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mota.Multiline = false;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tb_mota.PasswordChar = false;
            this.tb_mota.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_mota.PlaceholderText = "";
            this.tb_mota.Size = new System.Drawing.Size(241, 31);
            this.tb_mota.TabIndex = 104;
            this.tb_mota.Texts = "";
            this.tb_mota.UnderlinedStyle = false;
            // 
            // cbb_loaiKM
            // 
            this.cbb_loaiKM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_loaiKM.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbb_loaiKM.BorderSize = 1;
            this.cbb_loaiKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbb_loaiKM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_loaiKM.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_loaiKM.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbb_loaiKM.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_loaiKM.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_loaiKM.Location = new System.Drawing.Point(220, 233);
            this.cbb_loaiKM.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbb_loaiKM.Name = "cbb_loaiKM";
            this.cbb_loaiKM.Padding = new System.Windows.Forms.Padding(1);
            this.cbb_loaiKM.Size = new System.Drawing.Size(241, 30);
            this.cbb_loaiKM.TabIndex = 105;
            this.cbb_loaiKM.Texts = "";
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_trangthai.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbb_trangthai.BorderSize = 1;
            this.cbb_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbb_trangthai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_trangthai.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_trangthai.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbb_trangthai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_trangthai.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_trangthai.Location = new System.Drawing.Point(220, 484);
            this.cbb_trangthai.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Padding = new System.Windows.Forms.Padding(1);
            this.cbb_trangthai.Size = new System.Drawing.Size(241, 30);
            this.cbb_trangthai.TabIndex = 106;
            this.cbb_trangthai.Texts = "";
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_capnhat.Location = new System.Drawing.Point(287, 546);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(107, 42);
            this.bt_capnhat.TabIndex = 98;
            this.bt_capnhat.Text = "Cập nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_them.Location = new System.Drawing.Point(114, 545);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(107, 43);
            this.bt_them.TabIndex = 97;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // bt_timkm
            // 
            this.bt_timkm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_timkm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_timkm.Location = new System.Drawing.Point(260, 36);
            this.bt_timkm.Name = "bt_timkm";
            this.bt_timkm.Size = new System.Drawing.Size(75, 23);
            this.bt_timkm.TabIndex = 3;
            this.bt_timkm.Text = "Tìm";
            this.bt_timkm.UseVisualStyleBackColor = true;
            // 
            // tb_timkiemkm
            // 
            this.tb_timkiemkm.Location = new System.Drawing.Point(29, 37);
            this.tb_timkiemkm.Name = "tb_timkiemkm";
            this.tb_timkiemkm.Size = new System.Drawing.Size(225, 23);
            this.tb_timkiemkm.TabIndex = 1;
            // 
            // FrmChiTietSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_Sale);
            this.Name = "FrmChiTietSale";
            this.Text = "FrmChiTietSale";
            this.grb_Sale.ResumeLayout(false);
            this.grb_Sale.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_mucgiam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_Sale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_sale;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_locTrangthai;
        private System.Windows.Forms.ComboBox cbb_locKM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtg_sp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ck_all;
        private CustomControls.RJControls.RJTextBox tb_mota;
        private CustomControls.RJControls.RJTextBox tb_mucgiam;
        private CustomControls.RJControls.RJTextBox tb_ten;
        private CustomControls.RJControls.RJTextBox tb_ma;
        private CustomControls.RJControls.RJComboBox cbb_trangthai;
        private CustomControls.RJControls.RJComboBox cbb_loaiKM;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_timkm;
        private System.Windows.Forms.TextBox tb_timkiemkm;
    }
}