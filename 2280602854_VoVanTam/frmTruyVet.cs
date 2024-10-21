using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2280602854_VoVanTam
{
    public partial class frmTruyVet : Form
    {
        private BenhNhanBUS _benhNhanBus;

        public frmTruyVet()
        {
            InitializeComponent();
            _benhNhanBus = new BenhNhanBUS(); // Khởi tạo đối tượng BenhNhanBUS

        }

        private void cmbBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBenhNhan.SelectedValue != null)
            {
                string maBN = cmbBenhNhan.SelectedValue.ToString();

                // Lấy danh sách bệnh nhân bị lây nhiễm từ bệnh nhân đã chọn
                var benhNhansLayNhiem = _benhNhanBus.LayDanhSachBenhNhanLayNhiemTu(maBN);

                // Xóa các hàng hiện tại trong DataGridView
                dgvTruyVet.Rows.Clear();

                // Hiển thị danh sách bệnh nhân bị lây nhiễm trong DataGridView
                foreach (var bn in benhNhansLayNhiem)
                {
                    int rowIndex = dgvTruyVet.Rows.Add();
                    dgvTruyVet.Rows[rowIndex].Cells["MaBN"].Value = bn.MaBN;
                    dgvTruyVet.Rows[rowIndex].Cells["TenBN"].Value = bn.TenBN;
                    dgvTruyVet.Rows[rowIndex].Cells["TinhTrang"].Value = bn.MaTT;
                    dgvTruyVet.Rows[rowIndex].Cells["CapDoLayNhiem"].Value = "F" + GetFLevel(bn.MaBN);
                }
            }
        }
        private int GetFLevel(string maBN)
        {
            int level = 0;
            var current = maBN;
            while (!string.IsNullOrEmpty(current))
            {
                var benhNhan = _benhNhanBus.LayDanhSachBenhNhan().FirstOrDefault(bn => bn.MaBN == current);
                if (benhNhan == null || string.IsNullOrEmpty(benhNhan.BNTXG)) break;
                current = benhNhan.BNTXG;
                level++;
            }
            return level;
        }

        private void frmTruyVet_Load(object sender, EventArgs e)
        {
            var danhSachBenhNhan = _benhNhanBus.LayDanhSachBenhNhan();

            cmbBenhNhan.DataSource = danhSachBenhNhan;
            cmbBenhNhan.DisplayMember = "MaVaTenBN"; 
            cmbBenhNhan.ValueMember = "MaBN";
            cmbBenhNhan.SelectedIndex = -1;
        }
    }
}
