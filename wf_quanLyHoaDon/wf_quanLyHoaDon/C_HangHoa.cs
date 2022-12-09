using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace wf_quanLyHoaDon
{
    [Serializable]

    class C_HangHoa
    {
        private string m_mahang;
        private string m_tenhang;
        private string m_dvt;
        private double m_dongia;
        public string mahang
        {
            get { return m_mahang; }
            set { m_mahang = value; }
        }
        public string tenhang
        {
            get { return m_tenhang; }
            set { m_tenhang = value; }
        }
        public string dvt
        {
            get { return m_dvt; }
            set { m_dvt = value; }
        }
        public double dongia
        {
            get { return m_dongia; }
            set { m_dongia = value; }
        }
        public C_HangHoa(string mahang, string tenhang, string dvt, double dongia)
        {
            m_mahang = mahang;
            m_tenhang = tenhang;
            m_dvt = dvt;
            m_dongia = dongia;
        }
        public C_HangHoa()
        {
            m_mahang = "";
            m_tenhang = "";
            m_dvt = "";
            m_dongia = 0.0;
        }
    }
}
