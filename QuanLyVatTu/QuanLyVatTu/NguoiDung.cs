using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTu
{
    public class NguoiDung
    {
        /// <summary>
        /// Tên đăng nhập duy nhất. Primary Key.
        /// </summary>
        public string TenDangNhap { get; set; }

        /// <summary>
        /// Mật khẩu đã được mã hóa (Không bao giờ lưu mật khẩu gốc).
        /// </summary>
        public string MatKhauHash { get; set; }

        /// <summary>
        /// Tên đầy đủ của người dùng.
        /// </summary>
        public string HoTen { get; set; }

        /// <summary>
        /// Vai trò của người dùng trong hệ thống (VD: "Admin", "Thủ kho", "Kế toán").
        /// Dùng để phân quyền chức năng.
        /// </summary>
        public string VaiTro { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
