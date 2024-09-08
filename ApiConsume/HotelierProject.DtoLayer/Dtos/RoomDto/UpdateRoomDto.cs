using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarası giriniz.")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Lütfen oda görseli giriniz.")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen başlık giriniz.")]
        [MaxLength(100,ErrorMessage ="Lütfen maksimum 100 karakter giriniz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisi giriniz.")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısı bilgisi giriniz.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen açıklama giriniz.")]
        [MaxLength(250, ErrorMessage = "Lütfen maksimum 250 karakter giriniz.")]
        public string Description { get; set; }
    }
}
