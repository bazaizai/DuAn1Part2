using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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
    public partial class FrmSanPham : Form
    {
        private ISanPhamServices _ISanPhamServices;
        private List<SanPhamViews> _LstSanPham;
        public SanPhamViews? _SanPham;
        public FrmSanPham()
        {
            InitializeComponent();
            _ISanPhamServices = new SanPhamServices();
            _LstSanPham = new List<SanPhamViews>();
            tb_Ma.Enabled = false;
            LoadData();
        }
        public void LoadData()
        {
            dtg_Show.Rows.Clear();
            dtg_Show.ColumnCount = 4;
            dtg_Show.Columns[0].Name = "Id ";
            dtg_Show.Columns[0].Visible = false;
            dtg_Show.Columns[1].Name = "ma";
            dtg_Show.Columns[2].Name = "Tên ";
            dtg_Show.Columns[3].Name = "Trang Thai";
            var lstSanPham = _ISanPhamServices.GetAll();
            if (tb_TimKiem.Text != "")
            {
                lstSanPham = lstSanPham.Where(x => x.Ma.ToLower().Contains(tb_TimKiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_TimKiem.Text.ToLower())).ToList();
            }
            foreach (var item in lstSanPham)
            {
                dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }

        public void resetForm()
        {
            _SanPham = null;
            radioButton1.Checked=false;
            radioButton2.Checked = false;
            foreach (TextBox item in groupBox3.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            tb_TimKiem.Text = "";
            LoadData();
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_Show.Rows[e.RowIndex];
                _SanPham = _ISanPhamServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString() ?? "Unknown message id"));
                tb_Ma.Text = r.Cells[1].Value.ToString();
                tb_Ten.Text = r.Cells[2].Value.ToString();
                radioButton1.Checked= r.Cells[3].Value.ToString()== "Hoạt động";
                radioButton2.Checked = r.Cells[3].Value.ToString() == "Không hoạt động";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_Ten.Text == "")
            {
                MessageBox.Show("Hãy nhập tên");
            }
          
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Hãy chọn trạng thái");
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Bạn có muốn thêm", "Chú ý", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    SanPhamViews a = new SanPhamViews()
                    {
                        Ma = tb_Ma.Text,
                        Ten = tb_Ten.Text,
                        TrangThai = radioButton1.Checked ? 0 : 1
                };
                    _ISanPhamServices.Add(a);
                    MessageBox.Show("Thêm thành công");
                    resetForm();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_SanPham == null)
            {
                MessageBox.Show("Bạn chưa chọn");
            }
            else
            {
                if (tb_Ten.Text == "")
                {
                    MessageBox.Show("Hãy nhập tên ");
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Hãy chọn trạng thái");
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có muốn sửa ", "Chú ý", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        _SanPham.Ma = tb_Ma.Text;
                        _SanPham.Ten = tb_Ten.Text;
                        _SanPham.TrangThai = radioButton1.Checked ? 0 : 1;
                        _ISanPhamServices.Update(_SanPham);
                        MessageBox.Show("Sửa thành công");
                        resetForm();
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_SanPham == null)
            {
                MessageBox.Show("Bạn chưa chọn");
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Bạn có muốn xóa", "Chú ý", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    _ISanPhamServices.Delete(_SanPham);
                    MessageBox.Show("Xóa thành công");
                    resetForm();
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            _SanPham = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            foreach (TextBox item in groupBox2.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            LoadData();
        }
    }
}
