using System.ComponentModel.DataAnnotations;

namespace WebPhim.Models
{
    public class RegisterViewModel
    {
        [Required, StringLength(100)]
        public required string UserName { get; set; }

        [Required, EmailAddress, StringLength(255)]
        public required string Email { get; set; }

        [Required, DataType(DataType.Password), StringLength(255, MinimumLength = 6)]
        public required string Password { get; set; }

        [Required, DataType(DataType.Password), Compare("Password", ErrorMessage = "Mật khẩu nhập lại không khớp")]
        public required string ConfirmPassword { get; set; }
    }
}
