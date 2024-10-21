using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BenhNhanDAL
    {
        private Model1 _context;

        public BenhNhanDAL()
        {
            _context = new Model1();
        }

        public List<TinhTrang> GetAllTinhTrang()
        {
            return _context.TinhTrangs.ToList();
        }

        public List<BenhNhan> GetBenhNhanLayNhiemTuNguoiKhac()
        {
            return _context.BenhNhans.Where(bn => bn.BNTXG != null).ToList();
        }
        public List<BenhNhan> GetAllBenhNhan()
        {
            return _context.BenhNhans.ToList();
        }
        public void ThemBenhNhan(BenhNhan benhNhan)
        {
            _context.BenhNhans.Add(benhNhan);
            _context.SaveChanges(); // Lưu thay đổi vào CSDL
        }

        // Cập nhật bệnh nhân hiện có trong cơ sở dữ liệu
        public void CapNhatBenhNhan(BenhNhan benhNhan)
        {
            var existingBenhNhan = _context.BenhNhans.FirstOrDefault(bn => bn.MaBN == benhNhan.MaBN);
            if (existingBenhNhan != null)

            {
                // Cập nhật các thông tin bệnh nhân
                existingBenhNhan.TenBN = benhNhan.TenBN;
                existingBenhNhan.MaTT = benhNhan.MaTT;
                existingBenhNhan.GhiChu = benhNhan.GhiChu;
                existingBenhNhan.BNTXG = benhNhan.BNTXG;

                _context.SaveChanges(); // Lưu thay đổi vào CSDL
            }
        }
        public List<BenhNhan> GetBenhNhanLayNhiemTu(string maBN)
        {
            return _context.BenhNhans.Where(bn => bn.BNTXG == maBN).ToList();
        }


    }
}
