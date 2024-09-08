using System.ComponentModel.DataAnnotations;

namespace HotelierProject.WebUI.Dtos.HotelServiceDto
{
    public class CreateHotelServiceDto
    {
        [Required(ErrorMessage ="Lütfen hizmet için bir ikon linki giriniz.")]
        public string Icon { get; set; }

        [Required(ErrorMessage = "Lütfen hizmet için bir başlık giriniz.")]
        [MaxLength(50,ErrorMessage = "Lütfen en fazla 50 karakter kullanınız.")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
