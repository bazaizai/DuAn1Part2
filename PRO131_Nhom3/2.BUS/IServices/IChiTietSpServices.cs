using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChiTietSpServices
    {
        string Add(ChiTietSpViews Obj);
        string Update(ChiTietSpViews Obj);
        string Delete(ChiTietSpViews Obj);
        ChiTietSpViews GetById(Guid Id);
        List<ChiTietSpViews> GetAll();
    }
}
