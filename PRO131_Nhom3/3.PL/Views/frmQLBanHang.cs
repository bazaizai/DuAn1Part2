using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class frmQLBanHang : Form
    {
        IAnhServices _IanhServices;
        IChiTietSpServices _IChiTietSpServices;
        ISanPhamServices _ISanPhamServices;
        IMauSacServices _IMauSacServices;
        ITeamServices _ITeamServices;
        IChatLieuServices _IChatLieuServices;
        IKichCoServices _ISizeServices;
        int count;
        public frmQLBanHang()
        {
            InitializeComponent();
            _IChiTietSpServices = new ChiTietSpServices();
            _ISanPhamServices = new SanPhamServices();
            _IMauSacServices = new MauSacServices();
            _ITeamServices = new TeamServices();
            _IChatLieuServices = new ChatLieuServices();
            _ISizeServices = new KichCoServices();
            _IanhServices = new AnhServices();
            //LoadItem();
            count = 1;
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage(NamrTabTS());
            TabHoaDon.TabPages.Add(tabPage);
        }

        //private void btnRemovetab_Click(object sender, EventArgs e)
        //{
        //    if (tabHoaDon.SelectedTab != null)
        //    {
        //        tabHoaDon.TabPages.Remove(tabHoaDon.SelectedTab);
        //    }
        //}

        private string NamrTabTS()
        {
            return "Hóa Đơn " + (count++).ToString();
        }

        private void LoadItem()
        {
            //foreach (var x in _anhServices.GetAll().GroupBy(x=>x.IdChiTietSp).Select(sp=>sp.First()).ToList())
            //{
            //MessageBox.Show(_ISanPhamServices.GetAll().Find(sp => sp.Id == x.IdSp).Ten);
            //ListAnh.Controls.Add(new Hats(_ISanPhamServices.GetAll().Find(sp => sp.Id == x.IdSp).Ten, _IChatLieuServices.GetAll().Find(cl => cl.Id == x.IdChatLieu).Ten, _IMauSacServices.GetAll().Find(ms => ms.Id == x.IdMauSac).Ten, _ISizeServices.GetAll().Find(s => s.Id == x.IdKichCo).Size, x.SoLuongTon.ToString(), Image.FromStream(new MemoryStream((byte[])x.DuongDan)), Convert.ToDouble(x.GiaBan)));
            //for (int i = 0; i < 5; i++)
            //{
            //    Hats[] TEST = new Hats[1];
            //    TEST[0] = new Hats();
            //    TEST[0].TenSP1 = 1.ToString();
            //    TEST[0].ChatLieuSP = 1.ToString();
            //    TEST[0].MauSacSP = 1.ToString();
            //    TEST[0].Sizesp = 1.ToString();
            //    TEST[0].SoLuongSP = 9000000.ToString();
            //    TEST[0].Price = 900000;
            //    ListItem.Controls.Add(TEST[0]);
            //}
            Hats[] TEST = new Hats[_IanhServices.GetAll().GroupBy(x => x.IdChiTietSp).Select(sp => sp.First()).ToList().Count];
            List<AnhViews> ListAnh = _IanhServices.GetAll().GroupBy(x => x.IdChiTietSp).Select(sp => sp.First()).ToList();
            for (int i = 0; i < ListAnh.Count; i++)
            {
                TEST[i] = new Hats();
                TEST[i].TenSP1 = _ISanPhamServices.GetAll().Find(sp => sp.Id == ListAnh[i].IdSp).Ten;
                TEST[i].ChatLieuSP = _IChatLieuServices.GetAll().Find(sp => sp.Id == ListAnh[i].IdChatLieu).Ten;
                TEST[i].MauSacSP = _IMauSacServices.GetAll().Find(sp => sp.Id == ListAnh[i].IdMauSac).Ten;
                TEST[i].Sizesp = _ISizeServices.GetAll().Find(sp => sp.Id == ListAnh[i].IdKichCo).Size;
                TEST[i].Icon = Image.FromStream(new MemoryStream((byte[])ListAnh[i].DuongDan));
                TEST[i].SoLuongSP = ListAnh[i].SoLuongTon.ToString();
                TEST[i].Price = Convert.ToDouble(ListAnh[i].GiaBan);
                ListItem.Controls.Add(TEST[i]);
            }
        }
    }
}
