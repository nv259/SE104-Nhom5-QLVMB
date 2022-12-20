using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class BookingDetail
    {
        public BookingDetail() { }

        private string ma_chuyen_bay, ma_nguoi_dat, ma_hang_ve, tinh_trang;
        private DateTime ngay_lap;
        
        public string MaChuyenBay { get; set; }
        public string MaNguoiDat { get; set; }
        public string MaHangVe { get; set; }
        public string TinhTrang { get; set; }
        public DateTime NgayLap { get; set; }

    }
}
