using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Models;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models
{
    public class LaptopConfigurationItemRepository : RepositoryBase<LaptopConfigurationItem>, ILaptopConfigurationItemRepository
    {
        public LaptopConfigurationItemRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<LaptopConfigurationItem>> GetLaptopConfigurationItems(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(lci => lci.ItemName)
                .ToListAsync();
        }

        public async Task<LaptopConfigurationItem> GetSingleLaptopConfigurationItem(int configurationItemId, bool trackChanges)
        {
            return await FindByCondition(lci => lci.ConfigurationItemId.Equals(configurationItemId), trackChanges)
                .SingleOrDefaultAsync();
        }
    }
}