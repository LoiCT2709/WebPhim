using System.ComponentModel.DataAnnotations;

namespace WebPhim.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Tên người dùng  là bắt buộc")]
        [StringLength(100, ErrorMessage ="Tên người dùng không được vượt quá 100 kí tự")]
        public required string UserName { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập email!")]
        [EmailAddress(ErrorMessage ="Email không hợp lệ!")]
        [StringLength(255, ErrorMessage ="Email không được vượt quá 255 kí tự!")]
        public required string Email { get; set; }


        [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6 đến 255 ký tự")]

        public required string Password { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu nhập lại không khớp")]

        public required string ConfirmPassword { get; set; }
    }
}
