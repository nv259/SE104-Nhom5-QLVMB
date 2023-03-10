using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE104_QLVMB.DTO
{
    public class Account
    {
        public Account(DataRow dr)
        {
            ma_dang_nhap = dr["MaDangNhap"].ToString();
            mat_khau = dr["MatKhau"].ToString();
            ma_nhom = dr["MaNhom"].ToString();
            ten_nguoi_dung = dr["TenNguoiDung"].ToString();
            dinh_danh = dr["DinhDanh"].ToString();
            sdt = dr["Sdt"].ToString();
        }

        private string ma_dang_nhap, mat_khau, ma_nhom, ten_nguoi_dung, dinh_danh, sdt;

        public string MaDangNhap { get { return ma_dang_nhap; } set { ma_dang_nhap = value; } }
        public string MatKhau { get { return mat_khau;  } set { mat_khau = value; } }
        public string MaNhom { get { return ma_nhom; } set { ma_nhom = value; } }
        public string TenNguoiDung { get { return ten_nguoi_dung; } set { ten_nguoi_dung = value; } }
        public string DinhDanh { get { return dinh_danh; } set { dinh_danh = value; } }
        public string Sdt { get { return sdt; } set { sdt = value; } }
    }
}
