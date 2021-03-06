using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Models
{
    public interface IConfigurationCostRepository
    {
        Task<IEnumerable<ConfigurationCost>> GetAllConfigurationCostsOfItem(int configurationItemId, bool trackChanges);
    }
}