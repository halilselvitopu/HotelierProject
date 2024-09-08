using System.ComponentModel.DataAnnotations;

namespace HotelierProject.WebUI.Dtos.HotelServiceDto
{
    public class UpdateHotelServiceDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen hizmet için bir ikon linki giriniz.")]
        public string Icon { get; set; }

        [Required(ErrorMessage = "Lütfen hizmet için bir başlık giriniz.")]
        [StringLength(50, ErrorMessage = "Lütfen en fazla 50 karakter kullanınız.")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Lütfen hizmet için bir açıklama giriniz.")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karakter kullanınız.")]
        public string Description { get; set; }
    }
}
