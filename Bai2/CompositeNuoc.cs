using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    public class CompositeNuoc:INuoc
    {
        public string Ten { get; set; }
        public string LoaiNuoc { get; set; }
        public string GhiChu { get; set; }
        public double Gia { get; set; }
        private List<INuoc> DS = new List<INuoc>();
        public void HTChiTiet()
        {
            Console.WriteLine("\n {0} thuoc loai {1}, ghi chu: {2} voi gia {3}", Ten, LoaiNuoc, GhiChu, Gia);
            foreach (INuoc e in DS)
            {
                e.HTChiTiet();
            }
        }
        public void AddNuoc(INuoc inuoc)
        {
            DS.Add(inuoc);
        }
        public void RemoveNuoc(INuoc inuoc)
        {
            DS.Remove(inuoc);
        }
    }
}
