using System.ComponentModel.DataAnnotations;

namespace HotelierProject.WebUI.Dtos.AppUserDto
{
    public class LoginAppUserDto
    {
        [Required(ErrorMessage = "Lütfen bir kullanıcı adı giriniz.")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Lütfen bir şifre giriniz.")]
        public string Password { get; set; }
    }
}
