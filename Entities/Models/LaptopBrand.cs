using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class LaptopBrand
    {
        [Column("BrandId")]
        public int BrandId { get; set; }

        [Required(ErrorMessage = "BrandName is a required field.")]
        public string BrandName { get; set; }
        [Required]
        public long Cost { get; set; }
    }
}