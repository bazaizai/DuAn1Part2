using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Size = System.Drawing.Size;

namespace _3.PL.Components
{
    public partial class Hats : UserControl
    {
        private double price;
        private string Ten;
        private string ChatLieuview;
        private string MauSacView;
        private string Sizeview;
        private String SoLuongView;
        private Image _Icon;
        private Guid _Idspct;
        public event EventHandler Onselect = null;


        public Hats()
        {
            InitializeComponent();
        }

        public string TenSP1 { get => Ten; set { Ten = value; TenSP.Text = value; } }
        public string ChatLieuSP { get => ChatLieuview; set { ChatLieuview = value; ChatLieu.Text = "Chất liệu: " + value; }}
        public string MauSacSP { get => MauSacView; set { MauSacView = value; MauSac.Text = "Màu sắc: " + value; } }
        public string Sizesp { get => Sizeview; set { Sizeview = value; SizeHat.Text = "Size: " + value; }  }
        public string SoLuongSP { get => SoLuongView; set { SoLuongView = value; SoLuong.Text ="Số lượng: " + value; }   }
        public Image Icon { get => _Icon; set { _Icon = value; Anh.Image = value; } }
        public double Price { get => price; set { price = value; Gia.Text = double.Parse(price.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat) + "đ"; } }
        public Guid IdSPCTSP { get => _Idspct; set { _Idspct = value; IdSPCT.Text = value.ToString(); } }


        private void Add_Click(object sender, EventArgs e)
        {
            Onselect?.Invoke(this, e);
        }
    }
}
