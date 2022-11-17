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
    public partial class FrmChiTietSale : Form
    {
        private IChiTietSaleServices _IchiTietSaleServices;
        private ISaleServices _SaleServices;
        private List<ChiTietSaleView> _lstCtsle;
        private Guid IDCtsle;
        public FrmChiTietSale()
        {
            InitializeComponent();
            _IchiTietSaleServices = new ChiTietSaleServices();
            _SaleServices = new SaleServices();
            _lstCtsle = new List<ChiTietSaleView>();
          
        }
        private void loadKM()
        {

        }
       
    }
}
