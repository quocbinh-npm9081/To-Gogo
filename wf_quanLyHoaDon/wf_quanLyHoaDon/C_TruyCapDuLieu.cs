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

    class C_TruyCapDuLieu
    {
        private static C_TruyCapDuLieu m_data = null;
        private List<C_HangHoa> dsHH;
        public C_TruyCapDuLieu()
        {
            dsHH = new List<C_HangHoa>();
        }
        public static C_TruyCapDuLieu khoiTao()
        {
            if (m_data == null) m_data = new C_TruyCapDuLieu();
            return m_data;
        }
        public List<C_HangHoa> getDsHangHoa()
        {
            return dsHH;
        }
        public bool ghiFile(string tenFile)
        {
            try {
                FileStream file = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, m_data);
                file.Close();
                return true;
            } 
            catch (Exception) {            
                return false;
            }
        }
        public bool docFile(string tenFile)
        {
            try {
                FileStream file = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter()
;               dsHH = bf.Deserialize(file) as List<C_HangHoa>;
                file.Close();
                return true;
            }
            catch (Exception){
                return false;
            }
        }
    }
}
