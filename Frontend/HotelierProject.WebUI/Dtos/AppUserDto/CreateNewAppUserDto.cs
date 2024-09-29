using System.ComponentModel.DataAnnotations;

namespace HotelierProject.WebUI.Dtos.AppUserDto
{
    public class CreateNewAppUserDto
    {
        [Required(ErrorMessage = "Lütfen bir isim giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen bir soyad giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen bir kullanıcı adı giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen bir mail giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen bir şifre giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi tekrar giriniz.")]
        [Compare("Password",ErrorMessage = "Girilen şifreler eşleşmiyor.")]
        public string ConfirmPassword { get; set; }

    }
}
