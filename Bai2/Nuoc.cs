    using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    public class Nuoc:INuoc
    {
        public string Ten { get; set; }
        public string LoaiNuoc { get; set; }
        public string GhiChu { get; set; }
        public double Gia { get; set; }

        public void HTChiTiet()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("\t {0} thuoc loai {1}. ghi chu :{2} voi gia {3}", Ten, LoaiNuoc, GhiChu, Gia);
        }
    }
}
