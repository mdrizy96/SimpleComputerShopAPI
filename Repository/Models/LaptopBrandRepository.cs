using Contracts.Models;
using Entities;
using Entities.Models;

namespace Repository.Models
{
    public class LaptopBrandRepository : RepositoryBase<LaptopBrand>, ILaptopBrandRepository
    {
        public LaptopBrandRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}