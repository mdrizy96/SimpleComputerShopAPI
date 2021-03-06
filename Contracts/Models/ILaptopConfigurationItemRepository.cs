using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Models
{
    public interface ILaptopConfigurationItemRepository
    {
        Task<IEnumerable<LaptopConfigurationItem>> GetLaptopConfigurationItems(bool trackChanges);
    }
}