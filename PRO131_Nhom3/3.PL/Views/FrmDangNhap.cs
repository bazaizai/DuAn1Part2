using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmDangNhap : Form
    {
        private INhanVienServices _iNhanVienServices;
        public FrmDangNhap()
        {
            InitializeComponent();
            this.CenterToScreen();
            _iNhanVienServices = new NhanVienServices();
            //Rectangle r = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            //Region rg = new Region(gp);
            //pictureBox1.Region = rg;
            tb_TK.Text = Properties.Settings.Default.tk;
            tb_MK.Text = Properties.Settings.Default.mk;
        }

       
        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            var login = _iNhanVienServices.GetAll().Where(p => p.TaiKhoan == tb_TK.Text && p.MatKhau == tb_MK.Text).FirstOrDefault();
            if (login != null)
            {              
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");

            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void saveInfor()
        {
            if (cb_save.Checked == true)
            {
                Properties.Settings.Default.tk = tb_TK.Text;
                Properties.Settings.Default.mk = tb_MK.Text;
                Properties.Settings.Default.TKdaLogin = tb_TK.Text;
                Properties.Settings.Default.MKdaLogin = tb_MK.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.tk = "";
                Properties.Settings.Default.mk = "";
                Properties.Settings.Default.TKdaLogin = tb_TK.Text;
                Properties.Settings.Default.MKdaLogin = tb_MK.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void tb_TK_MouseClick(object sender, MouseEventArgs e)
        {
            tb_TK.Text = "";
        }

        private void tb_MK_MouseClick(object sender, MouseEventArgs e)
        {
            tb_MK.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FrmForgotPW frmForgotPW = new FrmForgotPW();
            //frmForgotPW.ShowDialog();
        }
    }
}
