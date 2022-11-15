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
    public partial class FrmLogin : Form
    {
        private INhanVienServices _iNhanVien;
        public FrmLogin()
        {
            InitializeComponent();
            _iNhanVien = new NhanVienServices();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
        }
    }
}
