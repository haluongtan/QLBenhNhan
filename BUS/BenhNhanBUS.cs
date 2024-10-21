using DAL.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BenhNhanBUS
    {
        private BenhNhanDAL _benhNhanDal;

        public BenhNhanBUS()
        {
            _benhNhanDal = new BenhNhanDAL();
        }

        public List<TinhTrang> LayDanhSachTinhTrang()
        {
            return _benhNhanDal.GetAllTinhTrang();
        }

        public List<BenhNhan> LayDanhSachBenhNhanLayNhiem()
        {
            return _benhNhanDal.GetBenhNhanLayNhiemTuNguoiKhac();
        }
        public List<BenhNhan> LayDanhSachBenhNhan()
        {
            return _benhNhanDal.GetAllBenhNhan();
        }

        public Dictionary<string, string> TinhToanCapDoLayNhiem()
        {
            var benhNhans = _benhNhanDal.GetAllBenhNhan();
            var capDoLayNhiem = new Dictionary<string, string>();

            foreach (var bn in benhNhans)
            {
                if (string.IsNullOrEmpty(bn.BNTXG))
                {
                    capDoLayNhiem[bn.MaBN] = "F0";
                }
                else if (capDoLayNhiem.ContainsKey(bn.BNTXG) && capDoLayNhiem[bn.BNTXG] == "F0")
                {
                    capDoLayNhiem[bn.MaBN] = "F1";
                }
                else if (capDoLayNhiem.ContainsKey(bn.BNTXG) && capDoLayNhiem[bn.BNTXG] == "F1")
                {
                    capDoLayNhiem[bn.MaBN] = "F2";
                }
                else
                {
                    capDoLayNhiem[bn.MaBN] = "F3";
                }
            }

            return capDoLayNhiem;
        }
        public void ThemBenhNhan(BenhNhan benhNhan)
        {
            _benhNhanDal.ThemBenhNhan(benhNhan);
        }

        // Cập nhật bệnh nhân đã có
        public void CapNhatBenhNhan(BenhNhan benhNhan)
        {
            _benhNhanDal.CapNhatBenhNhan(benhNhan);
        }
        public List<BenhNhan> LayDanhSachBenhNhanLayNhiemTu(string maBN)
        {
            return _benhNhanDal.GetBenhNhanLayNhiemTu(maBN);
        }


    }
}
