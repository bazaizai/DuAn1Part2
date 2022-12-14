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
    public partial class FrmUuDaiTichDiem : Form
    {
        public IUuDaiTichDiemServices _iUuDaiTichDiemServices;
        public UuDaiTichDiemView _uuDaiTichDiemView;
        public FrmUuDaiTichDiem()
        {
            InitializeComponent();
            _iUuDaiTichDiemServices = new UuDaiTichDiemServices();
            _uuDaiTichDiemView = new UuDaiTichDiemView();
            LoadData();
        }
        public void ClearForm()
        {
            LoadData();
            tb_ma.Text = "";
            cbb_loaihinhkm.Text = "";
            tb_mucUudai.Text = "";
            rdb_hd.Checked = false;
            rdb_khd.Checked = false;
        }
        public void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 6;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "STT";
            dtg_show.Columns[2].Name = "Mã";
            dtg_show.Columns[3].Name = "Loại hình khuyến mãi";
            dtg_show.Columns[4].Name = "Mức ưu đãi";
            dtg_show.Columns[5].Name = "Trạng thái";


            dtg_show.Rows.Clear();
            var lst = _iUuDaiTichDiemServices.GetAll();
            foreach (var item in lst)
            {
                dtg_show.Rows.Add(item.Id, stt++, item.Ma, item.LoaiHinhKm,item.MucUuDai, item.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = new UuDaiTichDiemView()
            {
                Id = new Guid(),
                Ma = tb_ma.Text,
                LoaiHinhKm = cbb_loaihinhkm.Text,
                MucUuDai = Convert.ToDecimal(tb_mucUudai.Text),
                TrangThai = rdb_hd.Checked ? 1 : 0
            };
            MessageBox.Show(_iUuDaiTichDiemServices.Add(x));
            ClearForm();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iUuDaiTichDiemServices.Delete(_uuDaiTichDiemView));
            ClearForm();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            _uuDaiTichDiemView.Ma = tb_ma.Text;
            _uuDaiTichDiemView.LoaiHinhKm = cbb_loaihinhkm.Text;
            _uuDaiTichDiemView.MucUuDai = Convert.ToDecimal(tb_mucUudai.Text);
            _uuDaiTichDiemView.TrangThai = rdb_hd.Checked ? 1 : 0;
            MessageBox.Show(_iUuDaiTichDiemServices.Update(_uuDaiTichDiemView));
            ClearForm();
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
                _uuDaiTichDiemView = _iUuDaiTichDiemServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = _uuDaiTichDiemView.Ma;
                cbb_loaihinhkm.Text = _uuDaiTichDiemView.LoaiHinhKm;
                tb_mucUudai.Text = Convert.ToString(_uuDaiTichDiemView.MucUuDai);
                rdb_hd.Checked = _uuDaiTichDiemView.TrangThai == 1;
                rdb_khd.Checked = _uuDaiTichDiemView.TrangThai == 0;
            }
        }
    }
}
