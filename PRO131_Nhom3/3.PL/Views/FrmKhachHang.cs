﻿using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmKhachHang : Form
    {
        public IKhachHangServices _iKhachHangServices;
        public ITichDiemServices _itichDiemServices;
        public KhachHangView _khachHangView;
        public TichDiemView _tichDiemView;
        public FrmKhachHang()
        {
            InitializeComponent();
            _iKhachHangServices = new KhachHangServices();
            _itichDiemServices = new TichDiemServices();
            _khachHangView = new KhachHangView();
            _tichDiemView = new TichDiemView();
            LoadData();
        }
        private string _message;
        public FrmKhachHang(string Message) : this()
        {
            _message = Message;
            tb_sdt.Text = _message;
        }
        public void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 10;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã";
            dtg_show.Columns[3].Name = "Họ và Tên";
            dtg_show.Columns[4].Name = "Ngày Sinh";
            dtg_show.Columns[5].Name = "SDT";
            dtg_show.Columns[6].Name = "Địa chỉ";
            dtg_show.Columns[7].Name = "Email";
            dtg_show.Columns[8].Name = "Số điểm";
            dtg_show.Columns[9].Name = "Trạng thái";
            tb_sodiem.Enabled = false;
            tb_ma.Enabled = false;
            tb_ma.Text = MaTS();

            dtg_show.Rows.Clear();
            var lst = _iKhachHangServices.GetAll();
            if (tb_timkiem.Text != "")
            {
                lst = lst.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var item in lst)
            {
                dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.FullName, item.NgaySinh.ToString(), item.Sdt, item.DiaChi, item.Email, item.SoDiem, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }

        public void ClearForm()
        {
            LoadData();
            _khachHangView.Id = Guid.Empty;
            tb_ma.Text = MaTS();
            tb_ten.Text = "";
            tb_tendem.Text = "";
            tb_ho.Text = "";
            tb_diachi.Text = "";
            tb_email.Text = "";
            tb_sdt.Text = "";
            tb_sodiem.Text = "";
            dtp_ngaysinh.Value = DateTime.Now;
            rdb_hd.Checked = false;
            rdb_khd.Checked = false;
        }
        private string MaTS()
        {
            if (_iKhachHangServices.GetAll().Count > 0)
            {
                return "KH" + Convert.ToString(_iKhachHangServices.GetAll().Max(c => Convert.ToInt32(c.Ma.Substring(2, c.Ma.Length - 2)) + 1));
            }
            else return "KH1";
        }
            private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //if (tb_ma.Text == "")
                //{
                //    MessageBox.Show("Không được để trống mã!");
                //}
                if (_iKhachHangServices.GetAll().Any(c => c.Ma == tb_ma.Text))
                {
                    MessageBox.Show("Mã bị trùng");
                }
                else if (tb_ten.Text == "")
                {
                    MessageBox.Show("Không được để trống tên!");
                }
                else if (tb_tendem.Text == "")
                {
                    MessageBox.Show("Không được để trống tên đệm!");
                }
                else if (tb_ho.Text == "")
                {
                    MessageBox.Show("Không được để trống tên họ!");
                }
                else if (dtp_ngaysinh.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!");
                }
                else if (DateTime.Now.Year - dtp_ngaysinh.Value.Year < 18)
                {
                    MessageBox.Show("Bạn chưa đủ tuổi!");
                }
                else if (tb_sdt.Text == "")
                {
                    MessageBox.Show("Không được để trống số điện thoại!");
                }
                else if (_iKhachHangServices.GetAll().Any(c => c.Sdt == tb_sdt.Text))
                {
                    MessageBox.Show("Số điện thoại bị trùng");
                }
                else if (!CheckValidate.IsValidVietNamPhoneNumber(tb_sdt.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                }
                else if (tb_diachi.Text == "")
                {
                    MessageBox.Show("Không được để trống địa chỉ!");
                }
                else if (!CheckValidate.IsValidEmail(tb_email.Text))
                {
                    MessageBox.Show("Email không hợp lệ");
                }
                else if (_iKhachHangServices.GetAll().Any(c => c.Email == tb_email.Text))
                {
                    MessageBox.Show("Email bị trùng");
                }
                else if (rdb_hd.Checked == false && rdb_khd.Checked == false)
                {
                    MessageBox.Show("Không được để trống trạng thái!");
                }
                else
                {
                    var tichdiem = new TichDiemView()
                    {
                        Id = Guid.NewGuid(),
                        SoDiem = 0,
                        TrangThai = 0
                    };
                    MessageBox.Show(_itichDiemServices.Add(tichdiem));
                    var y = _itichDiemServices.GetAll().FirstOrDefault(c => c.Id == _tichDiemView.Id);
                    var x = new KhachHangView()
                    {
                        Id = new Guid(),
                        IdtichDiem = tichdiem.Id,
                        Ma = tb_ma.Text,
                        Ten = tb_ten.Text,
                        TenDem = tb_tendem.Text,
                        Ho = tb_ho.Text,
                        DiaChi = tb_diachi.Text,
                        Email = tb_email.Text,
                        Sdt = tb_sdt.Text,
                        NgaySinh = dtp_ngaysinh.Value,
                        TrangThai = rdb_hd.Checked ? 1 : 0
                    };
                    
                    MessageBox.Show(_iKhachHangServices.Add(x));
                    ClearForm();
                }           
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lựa chọn");
            }          
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (tb_ma.Text == "")
                {
                    MessageBox.Show("Không được để trống mã!");
                }
                //else if (_iKhachHangServices.GetAll().Any(c => c.Ma == tb_ma.Text))
                //{
                //    MessageBox.Show("Mã bị trùng");
                //}
                else if (tb_ten.Text == "")
                {
                    MessageBox.Show("Không được để trống tên!");
                }
                else if (tb_tendem.Text == "")
                {
                    MessageBox.Show("Không được để trống tên đệm!");
                }
                else if (tb_ho.Text == "")
                {
                    MessageBox.Show("Không được để trống tên họ!");
                }
                else if (dtp_ngaysinh.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!");
                }
                else if (tb_sdt.Text == "")
                {
                    MessageBox.Show("Không được để trống số điện thoại!");
                }
                //else if (_iKhachHangServices.GetAll().Any(c => c.Sdt == tb_sdt.Text))
                //{
                //    MessageBox.Show("Số điện thoại bị trùng");
                //}
                else if (!CheckValidate.IsValidVietNamPhoneNumber(tb_sdt.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                }
                else if (tb_diachi.Text == "")
                {
                    MessageBox.Show("Không được để trống địa chỉ!");
                }
                else if (tb_email.Text == "")
                {
                    MessageBox.Show("Không được để trống email!");
                }
                else if (!CheckValidate.IsValidEmail(tb_email.Text))
                {
                    MessageBox.Show("Email không hợp lệ");
                }
                //else if (_iKhachHangServices.GetAll().Any(c => c.Email == tb_email.Text))
                //{
                //    MessageBox.Show("Email bị trùng");
                //}
                else if (rdb_hd.Checked == false && rdb_khd.Checked == false)
                {
                    MessageBox.Show("Không được để trống trạng thái!");
                }
                else
                {
                    _khachHangView.Ma = tb_ma.Text;
                    _khachHangView.Ten = tb_ten.Text;
                    _khachHangView.TenDem = tb_tendem.Text;
                    _khachHangView.Ho = tb_ho.Text;
                    _khachHangView.DiaChi = tb_diachi.Text;
                    _khachHangView.Email = tb_email.Text;
                    _khachHangView.Sdt = tb_sdt.Text;
                    _khachHangView.SoDiem = Convert.ToInt32(tb_sodiem.Text);
                    _khachHangView.NgaySinh = dtp_ngaysinh.Value;
                    _khachHangView.TrangThai = rdb_hd.Checked ? 1 : 0;
                    MessageBox.Show(_iKhachHangServices.Update(_khachHangView));
                    ClearForm();
                }              
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lựa chọn");
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if(_khachHangView.Id == Guid.Empty)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                }
                else
                {
                    MessageBox.Show(_iKhachHangServices.Delete(_khachHangView));
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Bạn đã hủy lựa chọn");
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _khachHangView = _iKhachHangServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = _khachHangView.Ma;
                tb_ten.Text = _khachHangView.Ten;
                tb_tendem.Text = _khachHangView.TenDem;
                tb_ho.Text = _khachHangView.Ho;
                tb_diachi.Text = _khachHangView.DiaChi;
                tb_email.Text = _khachHangView.Email;
                tb_sdt.Text = _khachHangView.Sdt;
                tb_sodiem.Text = Convert.ToString(_khachHangView.SoDiem);
                dtp_ngaysinh.Value = _khachHangView.NgaySinh.Value;
                rdb_hd.Checked = _khachHangView.TrangThai == 1;
                rdb_khd.Checked = _khachHangView.TrangThai == 0;
            }
        }

        //public void TimKiem()
        //{
        //    var lst = _iKhachHangServices.GetAll();
        //    if (tb_timkiem.Text != "")
        //    {
        //        lst = lst.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Sdt.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
        //    }
        //}
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
            _iKhachHangServices.Search(tb_timkiem.Text);
        }

        private void dtg_show_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {               
                    ContextMenuStrip menu = new ContextMenuStrip();
                    int xy = dtg_show.HitTest(e.X, e.Y).RowIndex;


                    if (xy >= 0)
                    {
                        menu.Items.Add("Sửa").Name = "Sửa";
                        menu.Items.Add("Xóa").Name = "Xóa";
                    }

                    menu.Show(dtg_show, new Point(e.X, e.Y));              
            }
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);
        }

        private void tb_ma_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
