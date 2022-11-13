using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace _3.PL.Views
{
    public partial class frmQLChiTietSp : Form
    {
        IAnhServices _IAnhServices;
        int x;
        IChiTietSpServices _IChiTietSpServices;
        ISanPhamServices _ISanPhamServices;
        IMauSacServices _IMauSacServices;
        ITeamServices _ITeamServices;
        IChatLieuServices _IChatLieuServices;
        IKichCoServices _ISizeServices;
        Guid _SelectID;
        public frmQLChiTietSp()
        {
            InitializeComponent();
            _ISanPhamServices = new SanPhamServices();
            _IChiTietSpServices = new ChiTietSpServices();
            _IMauSacServices = new MauSacServices();
            _ITeamServices = new TeamServices();
            _IChatLieuServices = new ChatLieuServices();
            _ISizeServices = new KichCoServices();
            _IAnhServices = new AnhServices();
            _SelectID = new Guid();
            LoadCbb();
            LoadData();
            x = 0;
            AnChucNang();
        }
        private void HideChucNang()
        {
            pnlChucNang.Visible = true;
            btnExit.Visible = true;
            btnExit1.Visible = true;
            pnlSanPham.Visible = false;
        }
        private void AnChucNang()
        {
            pnlChucNang.Visible = false;
            btnExit.Visible = false;
            btnExit1.Visible = false;
            pnlSanPham.Visible = true;
        }


        private void LoadCbb()
        {
            cbbSP1.Items.Clear();
            foreach (var item in _ISanPhamServices.GetAll())
            {
                cbbSP1.Items.Add(item.Ten);
            }
            cbbsize1.Items.Clear();
            foreach (var item in _ISizeServices.GetAll())
            {
                cbbsize1.Items.Add(item.Size);
            }
            cbbChatLieu1.Items.Clear();
            foreach (var item in _IChatLieuServices.GetAll())
            {
                cbbChatLieu1.Items.Add(item.Ten);
            }
            cbbms1.Items.Clear();
            foreach (var item in _IMauSacServices.GetAll())
            {
                cbbms1.Items.Add(item.Ten);
            }
            cbbTeam1.Items.Clear();
            foreach (var item in _ITeamServices.GetAll())
            {
                cbbTeam1.Items.Add(item.Ten);
            }
        }
        private void FakeData()
        {
            for (int i = 1; i < 5; i++)
            {
                _IChatLieuServices.Add(new ChatLieuViews()
                {
                    Ma = "CL" + i.ToString(),
                    Ten = "Chất liệu " + i.ToString()
                });
                _ISizeServices.Add(new KichCoViews()
                {
                    Ma = "KC" + i.ToString(),
                    Size = "L" + i.ToString()
                });
                _IMauSacServices.Add(new MauSacView()
                {
                    Ma = "Ms" + i.ToString(),
                    Ten = "Màu sắc " + i.ToString()
                });
                _ITeamServices.Add(new TeamView()
                {
                    Ma = "Team" + i.ToString(),
                    Ten = "Team " + i.ToString()
                });
                _ISanPhamServices.Add(new SanPhamViews()
                {
                    Ma = "SP" + i.ToString(),
                    Ten = "Sản Phẩm " + i.ToString()
                });

            }
        }
        private void LoadData()
        {
            int stt = 1;
            var _lst = _IChiTietSpServices.GetAll();
            dtgView.Columns.Clear();
            dtgView.ColumnCount = 11;
            dtgView.Columns[0].Name = "ID";
            dtgView.Columns[0].Visible = false;
            dtgView.Columns[1].Name = "STT";
            dtgView.Columns[2].Name = "Sản phẩm";
            dtgView.Columns[3].Name = "Chất liệu";
            dtgView.Columns[4].Name = "Team";
            dtgView.Columns[5].Name = "Màu sắc";
            dtgView.Columns[6].Name = "Size";
            dtgView.Columns[7].Name = "Giá bán";
            dtgView.Columns[8].Name = "Giá nhập";
            dtgView.Columns[9].Name = "Số lượng tồn";
            dtgView.Columns[10].Name = "Trạng Thái";

            foreach (var x in _lst)
            {
                dtgView.Rows.Add(x.Id, stt++, x.TenSP, x.TenChatLieu, x.TenTeam, x.TenMauSac, x.Size, x.GiaBan, x.GiaNhap, x.SoLuongTon, x.TrangThai == 0 ? "Đang bán" : "Dừng Bán");
            }
            resest();
        }

        private Guid IdSp() => _ISanPhamServices.GetAll().Find(x => x.Ten == cbbSP1.Text).Id;
        private Guid IdMs() => _IMauSacServices.GetAll().Find(x => x.Ten == cbbms1.Text).Id;
        private Guid IdCL() => _IChatLieuServices.GetAll().Find(x => x.Ten == cbbChatLieu1.Text).Id;
        private Guid IdTeam() => _ITeamServices.GetIdByName(cbbTeam1.Text);
        private Guid IdSize() => _ISizeServices.GetAll().Find(x => x.Size == cbbsize1.Text).Id;
        private List<AnhViews> GetListAnh(Guid? Id) => _IAnhServices.GetAll().Where(x => x.IdChiTietSp == Id).ToList();

        private string Cell(int x) => dtgView.CurrentRow.Cells[x].Value.ToString();


        private void dtgView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            _SelectID = Guid.Parse(Cell(0));
            AnhExit.Image = Image.FromStream(new MemoryStream((byte[])GetListAnh(_SelectID)[0].DuongDan));
            AnhExit1.Image = Image.FromStream(new MemoryStream((byte[])GetListAnh(_SelectID)[1].DuongDan));
            anhtt.Image = Image.FromStream(new MemoryStream((byte[])GetListAnh(_SelectID)[0].DuongDan));
            anhtt.SizeMode = PictureBoxSizeMode.StretchImage;
            Anhtt1.Image = Image.FromStream(new MemoryStream((byte[])GetListAnh(_SelectID)[1].DuongDan));
            Anhtt1.SizeMode = PictureBoxSizeMode.StretchImage;
            anhthongtin.Image = Image.FromStream(new MemoryStream((byte[])GetListAnh(_SelectID)[0].DuongDan));
            lblTenSP.Text = Cell(2);
            lblGia.Text = "Giá: " + double.Parse(Cell(7)).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + " đ";
            lblChatlieu.Text = Cell(3);
            lblSize.Text = Cell(6);
            lblSoluong.Text = Cell(9);
            lblMauSac.Text = Cell(5);
            lblteam.Text = Cell(4);
        }

        private bool CheckTrungSP(Guid idsp, Guid idmausac, Guid Idsize, Guid idteam, Guid idClieu)
        {
            for (int i = 0; i < _IChiTietSpServices.GetAll().Count; i++)
            {
                if (_IChiTietSpServices.GetAll()[i].IdSp == idsp && _IChiTietSpServices.GetAll()[i].IdMauSac == idmausac && _IChiTietSpServices.GetAll()[i].IdSize == Idsize && _IChiTietSpServices.GetAll()[i].IdTeam == idteam && _IChiTietSpServices.GetAll()[i].IdChatLieu == idClieu)
                {
                    return true;
                }
            }
            return false;
        }

        private void TabAll_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            x++;
            if (x % 2 != 0)
            {
                HideChucNang();
            }
            else
            {
                AnChucNang();
                resest();
            }
        }
        private void resest()
        {
            txtBaoHanh1.Texts = "";
            txtGiaBan1.Texts = "";
            txtGiaNhap1.Texts = "";
            txtSLton.Texts = "";
            txtMoTa1.Texts = "";
            cbbChatLieu1.SelectedIndex = -1;
            cbbms1.SelectedIndex = -1;
            cbbsize1.SelectedIndex = -1;
            cbbSP1.SelectedIndex = -1;
            cbbTeam1.SelectedIndex = -1;
            cbbTrangThai1.SelectedIndex = -1;
            rdoApDung1.Checked = false;
            rdoKhongApDung1.Checked = false;
            AnhExit.Image = null;
            AnhExit1.Image = null;
            _SelectID = new Guid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file:| *.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn chọn ảnh không?",
               "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AnhExit.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private void btnExit1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file:| *.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn chọn ảnh không?",
               "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AnhExit1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void dtgView_DoubleClick(object sender, EventArgs e)
        {
            _SelectID = Guid.Parse(Cell(0));
            TabAll.SelectedTab = TabThongTin;
            cbbSP1.Text = Cell(2);
            cbbChatLieu1.Text = Cell(3);
            cbbTeam1.Text = Cell(4);
            cbbms1.Text = Cell(5);
            cbbsize1.Text = Cell(6);
            txtGiaBan1.Texts = Cell(7);
            txtGiaNhap1.Texts = Cell(8);
            txtSLton.Texts = Cell(9);
            cbbTrangThai1.Text = Cell(10);
            txtBaoHanh1.Texts = _IChiTietSpServices.GetById(_SelectID).BaoHanh;
            txtMoTa1.Text = _IChiTietSpServices.GetById(_SelectID).MoTa;
            if (_IChiTietSpServices.GetById(_SelectID).TrangThaiKhuyenMai == 0) rdoApDung1.Checked = true;
            if (_IChiTietSpServices.GetById(_SelectID).TrangThaiKhuyenMai == 1) rdoKhongApDung.Checked = true;
            cbbTrangThai1.Text = _IChiTietSpServices.GetById(_SelectID).TrangThai == 0 ? "Đang bán" : "Dừng bán";
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            if (!CheckTrungSP(IdSp(), IdMs(), IdSize(), IdTeam(), IdCL()))
            {
                try
                {
                    var x = new ChiTietSpViews()
                    {
                        Id = Guid.NewGuid(),
                        IdChatLieu = IdCL(),
                        IdSp = IdSp(),
                        IdMauSac = IdMs(),
                        IdSize = IdSize(),
                        IdTeam = IdTeam(),
                        BaoHanh = txtBaoHanh1.Texts,
                        SoLuongTon = int.Parse(txtSLton.Texts),
                        GiaBan = decimal.Parse(txtGiaBan1.Texts),
                        GiaNhap = decimal.Parse(txtGiaNhap1.Texts),
                        TrangThai = cbbTrangThai1.Text == "Bán" ? 0 : 1,
                        TrangThaiKhuyenMai = rdoApDung1.Checked ? 0 : 1
                    };
                    _IChiTietSpServices.Add(x);

                    var Anh = new AnhViews()
                    {
                        IdChiTietSp = x.Id,
                        TenAnh = String.Concat(cbbSP1.Text + cbbTeam1.Text + "Show"),
                        DuongDan = (byte[])(new ImageConverter().ConvertTo(AnhExit.Image, typeof(Byte[]))),
                        TrangThai = 0
                    };
                    _IAnhServices.Add(Anh);
                    var Anh1 = new AnhViews()
                    {
                        IdChiTietSp = x.Id,
                        TenAnh = String.Concat(cbbSP1.Text + cbbTeam1.Text),
                        DuongDan = (byte[])(new ImageConverter().ConvertTo(AnhExit1.Image, typeof(Byte[]))),
                        TrangThai = 0
                    };
                    MessageBox.Show(_IAnhServices.Add(Anh1));
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Sản phẩm này đã tồn tại");
            }
        }
        private ChiTietSpViews Obj() => _IChiTietSpServices.GetById(_SelectID);
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckTrungSP(IdSp(), IdMs(), IdSize(), IdTeam(), IdCL()) || (Obj().IdChatLieu == IdCL() && Obj().IdMauSac == IdMs() && Obj().IdTeam == IdTeam() && Obj().IdSp == IdSp() && Obj().IdSize == IdSize()))
            {
                try
                {
                    if (Obj() != null)
                    {
                        _IChiTietSpServices.Update(new ChiTietSpViews(_SelectID, IdSp(), IdMs(), IdSize(), IdTeam(), IdCL(), txtBaoHanh1.Texts, txtMoTa1.Texts, int.Parse(txtSLton.Texts), decimal.Parse(txtGiaNhap1.Texts), int.Parse(txtGiaBan1.Texts), cbbTrangThai1.Text == "Đang bán" ? 0 : 1, rdoApDung1.Checked ? 0 : 1));
                        var Anh = new AnhViews()
                        {
                            Id = GetListAnh(_SelectID)[0].Id,
                            TenAnh = String.Concat(cbbSP1.Text + cbbTeam1.Text + "Show"),
                            DuongDan = (byte[])(new ImageConverter().ConvertTo(AnhExit.Image, typeof(Byte[]))),
                            TrangThai = 0
                        };
                        _IAnhServices.Update(Anh);
                        var Anh1 = new AnhViews()
                        {
                            Id = GetListAnh(_SelectID)[1].Id,
                            TenAnh = String.Concat(cbbSP1.Text + cbbTeam1.Text),
                            DuongDan = (byte[])(new ImageConverter().ConvertTo(AnhExit1.Image, typeof(Byte[]))),
                            TrangThai = 0
                        };
                        _IAnhServices.Update(Anh1);
                        MessageBox.Show("Update thành công");
                        LoadData();
                    }else
                    {
                        MessageBox.Show("Vui lòng chọn sản phẩm để update");
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Sản phẩm này đã tồn tại");
            }
        }

    }
}
