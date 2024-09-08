using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DtoLayer.Dtos.RoomDto
{
    public class CreateRoomDto 
    {
        [Required(ErrorMessage ="Lütfen oda numarası giriniz.")]
        public string Number { get; set; }
        public string Image { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen başlık giriniz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisi giriniz.")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisi giriniz.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
