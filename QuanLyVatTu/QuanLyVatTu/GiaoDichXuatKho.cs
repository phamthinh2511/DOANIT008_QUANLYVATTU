using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTu
{
    /// <summary>
    /// Đại diện cho một phiếu xuất kho.
    /// </summary>
    public class PhieuXuatKho
    {
        /// <summary>
        /// Mã định danh duy nhất cho phiếu xuất (VD: "PXK-20251015-001"). Primary Key.
        /// </summary>
        public string MaPhieuXuat { get; set; }

        /// <summary>
        /// Ngày giờ thực hiện xuất kho.
        /// </summary>
        public DateTime NgayXuat { get; set; }

        /// <summary>
        /// Mã kho nơi vật tư được xuất đi (Foreign Key).
        /// </summary>
        public string MaKho { get; set; }

        /// <summary>
        /// Người hoặc bộ phận nhận vật tư.
        /// </summary>
        public string NguoiNhan { get; set; }

        /// <summary>
        /// Lý do xuất kho (VD: "Sản xuất đơn hàng XYZ", "Bảo trì thiết bị").
        /// </summary>
        public string LyDoXuat { get; set; }

        /// <summary>
        /// Tên người dùng đã tạo phiếu này.
        /// </summary>
        public string NguoiTao { get; set; }

        /// <summary>
        /// Danh sách các vật tư được xuất trong phiếu này (Quan hệ Một - Nhiều).
        /// </summary>
        public List<ChiTietPhieuXuat> DanhSachVatTu { get; set; } = new List<ChiTietPhieuXuat>();
    }

    /// <summary>
    /// Đại diện cho một dòng chi tiết trong phiếu xuất kho.
    /// </summary>
    public class ChiTietPhieuXuat
    {
        /// <summary>
        /// Mã vật tư được xuất (Foreign Key).
        /// </summary>
        public string MaVatTu { get; set; }

        /// <summary>
        /// Số lượng vật tư xuất.
        /// </summary>
        public double SoLuong { get; set; }
    }
}
