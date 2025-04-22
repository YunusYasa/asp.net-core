using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace View_Models.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        [StringLength(50,MinimumLength =5,ErrorMessage = "En az 5 en fazla 50 karakter olabilir")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Director { get; set; }
        public string[] Players { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string ImgUrl { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int? GenreId { get; set; } //int alan null olmaz 0 olur bu yüzden requiredi görmez o yüzden nullıbıl atıyoz.

    }
}
