using Contracts.Models;
using Entities;
using Entities.Models;

namespace Repository.Models
{
    public class LaptopConfigurationItemRepository : RepositoryBase<LaptopConfigurationItem>, ILaptopConfigurationItemRepository
    {
        public LaptopConfigurationItemRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}