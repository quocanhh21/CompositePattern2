using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Nuoc nuoc1 = new Nuoc { Ten = "Coca", LoaiNuoc = "Nuoc ngot", GhiChu = "nuoc co ga", Gia = 15000 };
            Nuoc nuoc2 = new Nuoc { Ten = "Pepsi", LoaiNuoc = "Nuoc ngot", GhiChu = "nuoc co ga", Gia = 17000 };
            Nuoc nuoc3 = new Nuoc { Ten = "O Long", LoaiNuoc = "Nuoc ngot", GhiChu = "nuoc co ga", Gia = 18000 };
            CompositeNuoc NuocNgot = new CompositeNuoc { Ten = "NuocNgot", LoaiNuoc = "Nuoc ngot", GhiChu = "...", Gia = 16500 };
            NuocNgot.AddNuoc(nuoc1);
            NuocNgot.AddNuoc(nuoc2);
            NuocNgot.AddNuoc(nuoc3);

            //nuoc1.HTChiTiet();

            Nuoc nuocep1 = new Nuoc { Ten = "Dau", LoaiNuoc = "Nuoc ep", GhiChu = "nuoc tu trai cay", Gia = 25000 };
            Nuoc nuocep2 = new Nuoc { Ten = "Chuoi", LoaiNuoc = "Nuoc ep", GhiChu = "nuoc tu trai cay", Gia = 27000 };
            Nuoc nuocep3 = new Nuoc { Ten = "Cam", LoaiNuoc = "Nuoc ep", GhiChu = "nuoc tu trai cay", Gia = 28000 };
            CompositeNuoc NuocEp = new CompositeNuoc { Ten = "NuocEp", LoaiNuoc = "Nuoc ep", GhiChu = "...", Gia = 26500 };
            NuocEp.AddNuoc(nuocep1);
            NuocEp.AddNuoc(nuocep2);
            NuocEp.AddNuoc(nuocep3);

            Nuoc nuockhoang1 = new Nuoc { Ten = "Lavie", LoaiNuoc = "Nuoc khoang", GhiChu = "nuoc tu nhien", Gia = 8000 };
            Nuoc nuockhoang2 = new Nuoc { Ten = "Vinh Hao", LoaiNuoc = "Nuoc khoang", GhiChu = "nuoc tu nhien", Gia = 7000 };
            CompositeNuoc NuocKhoang = new CompositeNuoc { Ten = "NuocKhoang", LoaiNuoc = "Nuoc khoang", GhiChu = "...", Gia = 10500 };
            NuocKhoang.AddNuoc(nuockhoang1);
            NuocKhoang.AddNuoc(nuockhoang2);

            CompositeNuoc MayBanNuoc = new CompositeNuoc { Ten = "May Ban Nuoc", LoaiNuoc = "May", GhiChu = "..." };
            MayBanNuoc.AddNuoc(NuocNgot);
            MayBanNuoc.AddNuoc(NuocEp);
            MayBanNuoc.AddNuoc(NuocKhoang);
            Console.WriteLine("Thong tin chi tiet");
            MayBanNuoc.HTChiTiet();

            Console.WriteLine("thong tin cua nuoc ep 1");
            nuocep1.HTChiTiet();
            Console.WriteLine("Nuoc ep dau ngung ban");
            NuocEp.RemoveNuoc(nuocep1);
            MayBanNuoc.HTChiTiet();
        }
    }
}
