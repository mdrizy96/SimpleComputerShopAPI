using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class LaptopConfigurationItem
    {
        [Column("ConfigurationItemId")]
        public int ConfigurationItemId { get; set; }

        [Required(ErrorMessage = "ItemName is a required field.")]
        public string ItemName { get; set; }
    }
}