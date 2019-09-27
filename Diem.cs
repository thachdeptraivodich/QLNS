using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github
{
    public class Diem
    {
        public double HoanhDo { get; set; }
        public double TungDo { get; set; }
        public Diem(double x,double y)
        {
            this.HoanhDo = x;
            this.TungDo = y;
        }
        public double TinhKhoangCach(Diem d)
        {
            return Math.Sqrt(Math.Pow(this.HoanhDo - d.HoanhDo, 2) +
                Math.Pow(this.TungDo - d.TungDo, 2));
        }
    }
    public class HCN
    {
        public Diem TrenTrai { get; set; }
        public Diem DuoiPhai { get; set; }
        public HCN(Diem TrenTrai, Diem DuoiPhai)
        {
            if (TrenTrai.HoanhDo > DuoiPhai.HoanhDo || TrenTrai.TungDo < DuoiPhai.TungDo)
                throw new ArgumentException("Input invalid");
            this.TrenTrai = TrenTrai;
            this.DuoiPhai = DuoiPhai;
        }
        public double TinhDienTich()
        {
            double width = this.DuoiPhai.HoanhDo - this.TrenTrai.HoanhDo;
            double height = this.TrenTrai.TungDo - this.DuoiPhai.TungDo;
            return width * height;
        }
    }
}