using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTu
{
    /// <summary>
    /// Đại diện cho một kho hàng.
    /// </summary>
    public class Kho
    {
        /// <summary>
        /// Mã định danh duy nhất cho kho (VD: "KHO-HN"). Primary Key.
        /// </summary>
        public string MaKho { get; set; }

        /// <summary>
        /// Tên kho (VD: "Kho Tổng Hà Nội").
        /// </summary>
        public string TenKho { get; set; }

        /// <summary>
        /// Địa chỉ của kho.
        /// </summary>
        public string DiaChi { get; set; }

        /// <summary>
        /// Tên người quản lý hoặc liên hệ tại kho.
        /// </summary>
        public string ThuKho { get; set; }
    }
}
