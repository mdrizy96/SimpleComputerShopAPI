namespace Entities.DataTransferObjects.ConfigurationCost
{
    public class ConfigurationCostDto
    {
        public int ConfigurationCostId { get; set; }
        public int ConfigurationItemId { get; set; }
        public string Option { get; set; }
        public decimal Cost { get; set; }
    }
}