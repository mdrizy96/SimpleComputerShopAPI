using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class ConfigurationCost
    {
        [Column("ConfigurationCostId")]
        public int ConfigurationCostId { get; set; }

        [Required]
        public int ConfigurationItemId { get; set; }

        [Required]
        public string Option { get; set; }

        [Required]
        public long Cost { get; set; }
    }
}