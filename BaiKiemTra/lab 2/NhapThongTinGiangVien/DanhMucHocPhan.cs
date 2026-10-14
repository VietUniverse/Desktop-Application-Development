using System.Collections.Generic;

namespace NhapThongTinGiangVien
{
    public class DanhMucHocPhan
    {
        public List<HocPhan> ds { get; set; }

        public DanhMucHocPhan()
        {
            ds = new List<HocPhan>();
        }

        public void Them(HocPhan hp)
        {
            ds.Add(hp);
        }

        public override string ToString()
        {
            string s = "";
            foreach (HocPhan hp in ds)
            {
                s += hp.TenHP + "; ";
            }
            return s;
        }
    }
}
