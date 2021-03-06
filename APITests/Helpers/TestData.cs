using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APITests.Helpers
{
    public class TestData
    {
        private List<LaptopBrand> _brands;
        private List<LaptopConfigurationItem> _laptopConfigurationItems;
        private List<ConfigurationCost> _configurationCosts;
        public TestData()
        {
            _brands = new List<LaptopBrand>
            {
                new LaptopBrand
                {
                    BrandId = 1,
                    BrandName = "Dell",
                    Cost = Convert.ToInt64(349.87 * 100)
                },
                new LaptopBrand
                {
                    BrandId = 2,
                    BrandName = "Toshiba",
                    Cost = Convert.ToInt64(345.67 * 100)
                },
                new LaptopBrand
                {
                    BrandId = 3,
                    BrandName = "HP",
                    Cost = Convert.ToInt64(456.76 * 100)
                }
            };

            _laptopConfigurationItems = new List<LaptopConfigurationItem>
            {
                new LaptopConfigurationItem
                {
                    ConfigurationItemId = 1,
                    ItemName = "Ram"
                },
                new LaptopConfigurationItem
                {
                    ConfigurationItemId = 2,
                    ItemName = "HDD"
                },
                new LaptopConfigurationItem
                {
                    ConfigurationItemId = 3,
                    ItemName = "Colour"
                }
            };

            _configurationCosts = new List<ConfigurationCost>
            {
                new ConfigurationCost
                {
                    ConfigurationCostId = 1,
                    ConfigurationItemId = 1,
                    Option = "8 GB",
                    Cost = Convert.ToInt64(45.67 * 100)
                },
                new ConfigurationCost
                {
                    ConfigurationCostId = 2,
                    ConfigurationItemId = 1,
                    Option = "16 GB",
                    Cost = Convert.ToInt64(87.88 * 100)
                },
                new ConfigurationCost
                {
                    ConfigurationCostId = 3,
                    ConfigurationItemId = 2,
                    Option = "500 GB",
                    Cost = Convert.ToInt64(123.34 * 100)
                },
                new ConfigurationCost
                {
                    ConfigurationCostId = 4,
                    ConfigurationItemId = 2,
                    Option = "1 TB",
                    Cost = Convert.ToInt64(200.00 * 100)
                },
                new ConfigurationCost
                {
                    ConfigurationCostId = 5,
                    ConfigurationItemId = 3,
                    Option = "Red",
                    Cost = Convert.ToInt64(50.76 * 100)
                },
                new ConfigurationCost
                {
                    ConfigurationCostId = 6,
                    ConfigurationItemId = 3,
                    Option = "Blue",
                    Cost = Convert.ToInt64(34.56 * 100)
                }
            };
        }

        internal LaptopConfigurationItem GetSingleLaptopConfigurationItem(int configurationItemId)
        {
            return _laptopConfigurationItems.Find(lci => lci.ConfigurationItemId.Equals(configurationItemId));
        }

        public List<LaptopBrand> GetLaptopBrands()
        {
            return _brands;
        }

        public List<LaptopConfigurationItem> GetLaptopConfigurationItems()
        {
            return _laptopConfigurationItems;
        }

        public List<ConfigurationCost> GetAllConfigurationCostsOfItem(int configurationItemId)
        {
            return _configurationCosts.FindAll(cc => cc.ConfigurationItemId.Equals(configurationItemId)).ToList();
        }
    }
}