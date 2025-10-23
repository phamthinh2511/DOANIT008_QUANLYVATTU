using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTu
{
    /// <summary>
    /// Đại diện cho một phiếu nhập kho.
    /// </summary>
    public class PhieuNhapKho
    {
        /// <summary>
        /// Mã định danh duy nhất cho phiếu nhập (VD: "PNK-20251015-001"). Primary Key.
        /// </summary>
        public string MaPhieuNhap { get; set; }

        /// <summary>
        /// Ngày giờ thực hiện nhập kho.
        /// </summary>
        public DateTime NgayNhap { get; set; }

        /// <summary>
        /// Mã kho nơi vật tư được nhập vào (Foreign Key).
        /// </summary>
        public string MaKho { get; set; }

        /// <summary>
        /// Mã nhà cung cấp đã giao hàng (Foreign Key).
        /// </summary>
        public string MaNhaCungCap { get; set; }

        /// <summary>
        /// Ghi chú cho phiếu nhập.
        /// </summary>
        public string GhiChu { get; set; }

        /// <summary>
        /// Tên người dùng đã tạo phiếu này.
        /// </summary>
        public string NguoiTao { get; set; }

        /// <summary>
        /// Danh sách các vật tư được nhập trong phiếu này (Quan hệ Một - Nhiều).
        /// </summary>
        public List<ChiTietPhieuNhap> DanhSachVatTu { get; set; } = new List<ChiTietPhieuNhap>();
    }

    /// <summary>
    /// Đại diện cho một dòng chi tiết trong phiếu nhập kho.
    /// </summary>
    public class ChiTietPhieuNhap
    {
        /// <summary>
        /// Mã vật tư được nhập (Foreign Key).
        /// </summary>
        public string MaVatTu { get; set; }

        /// <summary>
        /// Số lượng vật tư nhập.
        /// </summary>
        public double SoLuong { get; set; }

        /// <summary>
        /// Đơn giá của vật tư tại thời điểm nhập.
        /// </summary>
        public decimal DonGia { get; set; }

        /// <summary>
        /// Thuộc tính tính toán, không lưu trong CSDL.
        /// </summary>
        public decimal ThanhTien => (decimal)SoLuong * DonGia;
    }
}
