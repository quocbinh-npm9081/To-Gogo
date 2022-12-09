using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wf_quanLyHoaDon
{
    public partial class Form_HangHoa : Form
    {
        private C_XuLYHangHoa xl;
        public Form_HangHoa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void hienthi(List<C_HangHoa> ds)
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = ds;
            dgv.DataSource = ds;
        }
        private void Form_HangHoa_Load(object sender, EventArgs e)
        {
            xl = new C_XuLYHangHoa();
            hienthi(xl.getDSHangHoa());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            C_HangHoa newHangHoa = new C_HangHoa();
            newHangHoa.mahang = txtMaHang.Text;
            newHangHoa.tenhang = txtTenHang.Text;
            newHangHoa.dvt = txtDvt.Text;
            newHangHoa.dongia = double.Parse(txtDonGia.Text);
            xl.them(newHangHoa);
            hienthi(xl.getDSHangHoa());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgv.SelectedRows)
            {
                string maHang = r.Cells[0].Value.ToString();
                xl.xoa(maHang);
            }
            hienthi(xl.getDSHangHoa());
        }
    }
}
