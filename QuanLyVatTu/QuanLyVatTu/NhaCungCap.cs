using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTu
{
    /// <summary>
    /// Đại diện cho một nhà cung cấp vật tư.
    /// </summary>
    public class NhaCungCap
    {
        /// <summary>
        /// Mã định danh duy nhất cho nhà cung cấp (VD: "NCC-HPG"). Primary Key.
        /// </summary>
        public string MaNhaCungCap { get; set; }

        /// <summary>
        /// Tên đầy đủ của nhà cung cấp (VD: "Công ty Cổ phần Tập đoàn Hòa Phát").
        /// </summary>
        public string TenNhaCungCap { get; set; }

        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
    }
}
