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
    public partial class Form1 : Form
    {
        private BenhNhanBUS _benhNhanBus;

        public Form1()
        {
            InitializeComponent();
            _benhNhanBus = new BenhNhanBUS();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var benhNhans = _benhNhanBus.LayDanhSachBenhNhan();
            var capDoLayNhiem = _benhNhanBus.TinhToanCapDoLayNhiem();

            foreach (var bn in benhNhans)
            {
                int rowIndex = dgvBenhNhan.Rows.Add();
                dgvBenhNhan.Rows[rowIndex].Cells["MaBN"].Value = bn.MaBN;
                dgvBenhNhan.Rows[rowIndex].Cells["TenBN"].Value = bn.TenBN;
                dgvBenhNhan.Rows[rowIndex].Cells["TinhTrang"].Value = bn.MaTT;
                dgvBenhNhan.Rows[rowIndex].Cells["GhiChu"].Value = bn.GhiChu;
                dgvBenhNhan.Rows[rowIndex].Cells["LayNhiem"].Value = capDoLayNhiem.ContainsKey(bn.MaBN) ? capDoLayNhiem[bn.MaBN] : "N/A";
            }
            var tinhTrangs = _benhNhanBus.LayDanhSachTinhTrang();
            cmbTinhTrang.DataSource = tinhTrangs;
            cmbTinhTrang.DisplayMember = "TenTT";
            cmbTinhTrang.ValueMember = "MaTT";

            cmbLayNhiem.Items.Add(""); 
            foreach (var bn in benhNhans)
            {
                cmbLayNhiem.Items.Add(bn.MaBN);
            }
            cmbLayNhiem.SelectedIndex = 0;
            
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBenhNhan.CurrentRow != null && dgvBenhNhan.CurrentRow.Index != -1)
            {
                txtMaBN.Text = dgvBenhNhan.CurrentRow.Cells["MaBN"].Value.ToString();
                txtTenBN.Text = dgvBenhNhan.CurrentRow.Cells["TenBN"].Value.ToString();
                rtbGhiChu.Text = dgvBenhNhan.CurrentRow.Cells["GhiChu"].Value?.ToString();
                cmbTinhTrang.SelectedValue = dgvBenhNhan.CurrentRow.Cells["TinhTrang"].Value;
                cmbLayNhiem.SelectedItem = dgvBenhNhan.CurrentRow.Cells["LayNhiem"].Value?.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBN.Text) || string.IsNullOrEmpty(txtTenBN.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài của mã bệnh nhân phải là 6 ký tự
            if (txtMaBN.Text.Length != 6)
            {
                MessageBox.Show("Mã bệnh nhân phải có 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra việc đảm bảo bệnh nhân không tự lây nhiễm chính mình
            if (cmbLayNhiem.SelectedItem != null && cmbLayNhiem.SelectedItem.ToString() == txtMaBN.Text)
            {
                MessageBox.Show("Bệnh nhân không thể lây nhiễm từ chính mình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ các điều khiển
            var benhNhan = new BenhNhan
            {
                MaBN = txtMaBN.Text,
                TenBN = txtTenBN.Text,
                MaTT = (int)cmbTinhTrang.SelectedValue,
                GhiChu = rtbGhiChu.Text,
                BNTXG = cmbLayNhiem.SelectedItem != null && cmbLayNhiem.SelectedIndex != 0 ? cmbLayNhiem.SelectedItem.ToString() : null
            };

            // Kiểm tra bệnh nhân đã có trong CSDL chưa
            var existingBenhNhan = _benhNhanBus.LayDanhSachBenhNhan().FirstOrDefault(bn => bn.MaBN == benhNhan.MaBN);
            if (existingBenhNhan == null)
            {
                // Nếu chưa có thì thêm mới
                _benhNhanBus.ThemBenhNhan(benhNhan);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Nếu đã có thì cập nhật
                _benhNhanBus.CapNhatBenhNhan(benhNhan);
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cập nhật lại danh sách bệnh nhân trên DataGridView
            CapNhatDanhSachBenhNhan();
        }
        private void CapNhatDanhSachBenhNhan()
        {
            dgvBenhNhan.Rows.Clear();
            var benhNhans = _benhNhanBus.LayDanhSachBenhNhan();
            var capDoLayNhiem = _benhNhanBus.TinhToanCapDoLayNhiem();

            foreach (var bn in benhNhans)
            {
                int rowIndex = dgvBenhNhan.Rows.Add();
                dgvBenhNhan.Rows[rowIndex].Cells["MaBN"].Value = bn.MaBN;
                dgvBenhNhan.Rows[rowIndex].Cells["TenBN"].Value = bn.TenBN;
                dgvBenhNhan.Rows[rowIndex].Cells["TinhTrang"].Value = bn.MaTT;
                dgvBenhNhan.Rows[rowIndex].Cells["GhiChu"].Value = bn.GhiChu;
                dgvBenhNhan.Rows[rowIndex].Cells["LayNhiem"].Value = capDoLayNhiem.ContainsKey(bn.MaBN) ? capDoLayNhiem[bn.MaBN] : "N/A";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void truyVếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTruyVet frmTruyVet = new frmTruyVet();
            frmTruyVet.ShowDialog();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.T))
            {
                truyVếtToolStripMenuItem_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
