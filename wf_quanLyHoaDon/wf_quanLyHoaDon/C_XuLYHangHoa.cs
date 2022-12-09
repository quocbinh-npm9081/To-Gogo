using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_quanLyHoaDon
{
    class C_XuLYHangHoa
    {
        private List<C_HangHoa> data;
        public C_XuLYHangHoa()
        {
            C_TruyCapDuLieu tc = C_TruyCapDuLieu.khoiTao();
            data = tc.getDsHangHoa();
        }
        public List<C_HangHoa> getDSHangHoa()
        {
            return data;
        }
        public C_HangHoa tim(string maHang)
        {
            foreach(C_HangHoa a in data)
            {
                if(maHang == a.mahang)
                {
                    return a;
                }
            }
            return null;
        }
        public bool them(C_HangHoa a)
        {
            C_HangHoa b = tim(a.mahang);
            if(b == null)
            {
                data.Add(b);
                return true;
            }
            return false;      
        }
        public bool add(C_HangHoa a)
        {
            C_HangHoa b = tim(a.mahang);
            if (b == null)
            {
                data.Add(a);
                return true;
            }
            return false;
        }
        public bool xoa(string mahang)
        {
            C_HangHoa b = tim(mahang);
            if (b != null)
            {
                data.Remove(b);
                return true;
            }
            return false;
        }
        public bool sua(C_HangHoa a)
        {
            C_HangHoa b = tim(a.mahang);
            if (b != null)
            {
                b.tenhang = a.tenhang;
                b.dvt = a.dvt;
                b.dongia = a.dongia;
                return true;
            }
            return false;
        }
    }
}
