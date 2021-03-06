using Contracts.Models;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        ILaptopBrandRepository LaptopBrand { get; }
        ILaptopConfigurationItemRepository LaptopConfigurationItem { get; }
        IConfigurationCostRepository ConfigurationCost { get; }

        Task SaveAsync();
    }
}