using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60,MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Release Date")]//ьеняем отображение имени таб
        [DataType(DataType.Date)] //отображается только дата не надо вводить
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }

        [Range(100,10000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]//коректно сопост прайс с бд кол-во сим, после запятой
        public decimal Price { get; set; }
    }
}
