using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class Decentralization
    {
        public Decentralization() { }

        private string ma_nhom, ma_chuc_nang;

        public string MaNhom { get { return ma_nhom; } set { ma_nhom = value; } }
        public string MaChucNang { get { return ma_chuc_nang; } set { ma_chuc_nang = value; } }
    }
}
