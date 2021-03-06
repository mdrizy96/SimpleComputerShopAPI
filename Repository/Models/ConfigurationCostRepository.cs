using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Models;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models
{
    public class ConfigurationCostRepository : RepositoryBase<ConfigurationCost>, IConfigurationCostRepository
    {
        public ConfigurationCostRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<ConfigurationCost>> GetAllConfigurationCostsOfItem(int configurationItemId, bool trackChanges)
        {
            return await FindByCondition(cc => cc.ConfigurationItemId.Equals(configurationItemId), trackChanges)
                .OrderBy(cc => cc.ConfigurationCostId)
                .ToListAsync();
        }
    }
}