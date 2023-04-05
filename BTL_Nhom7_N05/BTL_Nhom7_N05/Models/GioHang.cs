using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_Nhom7_N05.Models
{
    public class GioHang
    {
        BTL_WebEntities1 db = new BTL_WebEntities1();
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string Anh { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public int Max { get; set; }
        public int ThanhTien1 { get; set; }
        public int ThanhTien3 { get; set; }
        public double ThanhTien
        {
            get { return DonGia * SoLuong; }
            set { }
        }
        public GioHang(string MaThietBi)
        {
            this.MaThietBi = MaThietBi;
            ThietBiYTe sanpham = db.ThietBiYTes.Single(n => n.MaThietBi == MaThietBi);
            TenThietBi = sanpham.TenThietBi;
            Anh = sanpham.Anh;
            DonGia = (double)sanpham.GiaBan;
            if ((int)sanpham.SoLuong == 0)
            {
                SoLuong = 0;
            }
            else
            {
                SoLuong = 1;
            }
            Max = (int)sanpham.SoLuong;
        }
    }
}