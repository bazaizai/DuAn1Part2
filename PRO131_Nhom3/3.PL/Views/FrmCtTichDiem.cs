using _1.DAL.DomainClass;
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
    public partial class FrmCtTichDiem : Form
    {
        private ICtTichDiemServices _iCtTichDiem;
        private CtTinhDiemView _cttd;
        public FrmCtTichDiem()
        {
            InitializeComponent();
            _iCtTichDiem = new CtTichDiemServices();
            rdb_hoatdong.Checked = false;
            LoadData();
        }
        public void LoadData()
        {
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 3;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Hệ số tích";
            dtg_show.Columns[2].Name = "Trạng thái";
            var lstCttd = _iCtTichDiem.GetAll();
            foreach (var item in lstCttd)
            {
                dtg_show.Rows.Add(item.Id, item.HeSoTich, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public CtTinhDiemView GetData()
        {
            CtTinhDiemView cvv = new CtTinhDiemView()
            {
                Id = new Guid(),
                HeSoTich = Convert.ToInt32(tb_HeSoTich.Text),
                TrangThai = rdb_hoatdong.Checked ? 0 : 1,
            };
            return cvv;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            CtTinhDiemView cvv = new CtTinhDiemView()
            {
                Id = Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString()),
                HeSoTich = Convert.ToInt32(tb_HeSoTich.Text),
                TrangThai = rdb_hoatdong.Checked ? 0 : 1,
            };
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _iCtTichDiem.Update(cvv);
                MessageBox.Show("sửa thành công");
            }
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_cttd == null)
                {
                    MessageBox.Show("vui lòng chọn");
                }
                _iCtTichDiem.Delete(_cttd);
                MessageBox.Show("xóa thành công");
            }
            LoadData();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_HeSoTich.Text = "";
            rdb_hoatdong.Checked = false;
            rdb_khonghd.Checked = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _iCtTichDiem.Add(GetData());
                MessageBox.Show("thêm thành công");
            }
            LoadData();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _cttd = _iCtTichDiem.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dtg_show.CurrentRow.Cells[0].Value.ToString()));
            tb_HeSoTich.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            rdb_khonghd.Checked = _cttd.TrangThai == 1;
            rdb_hoatdong.Checked = _cttd.TrangThai == 0;
        }
    }
}
