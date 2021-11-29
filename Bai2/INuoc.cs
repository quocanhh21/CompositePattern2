using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    public interface INuoc
    {
        string Ten { get; set; }
        string LoaiNuoc { get; set; }
        string GhiChu { get; set; }
        double Gia { get; set; }
        void HTChiTiet();
    }
}
