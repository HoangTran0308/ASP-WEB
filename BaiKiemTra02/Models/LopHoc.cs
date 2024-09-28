using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra02.Models
{
    public class LopHoc
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Năm Nhập Học")]
        [Range(1900, 2100, ErrorMessage = "Vui lòng nhập năm hợp lệ từ 1900 đến 2100")]
        public int NamNhapHoc { get; set; }

        [Required]
        [Display(Name = "Năm Ra Trường")]
        [Range(1900, 2100, ErrorMessage = "Vui lòng nhập năm hợp lệ từ 1900 đến 2100")]
        public int NamRaTruong { get; set; }

        public int SoLuongSinhVien { get; set; }
    }
}
