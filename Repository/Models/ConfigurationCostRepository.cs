using Contracts.Models;
using Entities;
using Entities.Models;

namespace Repository.Models
{
    public class ConfigurationCostRepository : RepositoryBase<ConfigurationCost>, IConfigurationCostRepository
    {
        public ConfigurationCostRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}