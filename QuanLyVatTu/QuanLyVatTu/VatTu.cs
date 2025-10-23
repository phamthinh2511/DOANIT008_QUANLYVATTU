using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatTu
{
    /// <summary>
    /// Đại diện cho một loại vật tư trong kho.
    /// </summary>
    public class VatTu
    {
        /// <summary>
        /// Mã định danh duy nhất cho vật tư (VD: "VT-001"). Primary Key.
        /// </summary>
        public string MaVatTu { get; set; }

        /// <summary>
        /// Tên gọi của vật tư (VD: "Thép ống D21").
        /// </summary>
        public string TenVatTu { get; set; }

        /// <summary>
        /// Mô tả chi tiết về vật tư.
        /// </summary>
        public string MoTa { get; set; }

        /// <summary>
        /// Đơn vị tính của vật tư (VD: "Cái", "Mét", "Kg", "Lít").
        /// </summary>
        public string DonViTinh { get; set; }

        /// <summary>
        /// Số lượng vật tư hiện có trong tất cả các kho.
        /// Giá trị này sẽ được cập nhật sau mỗi lần nhập/xuất kho.
        /// </summary>
        public double SoLuongTon { get; set; }

        /// <summary>
        /// Ngưỡng tồn kho tối thiểu. Dùng để cảnh báo khi vật tư sắp hết.
        /// </summary>
        public double TonKhoToiThieu { get; set; }

        /// <summary>
        /// Mã nhà cung cấp chính cho vật tư này (Foreign Key).
        /// </summary>
        public string MaNhaCungCap { get; set; }
    }
}
