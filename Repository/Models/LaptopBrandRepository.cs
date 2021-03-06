using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<LaptopBrand>> GetAllLaptopBrands(bool trackChanges)
        {
            throw new System.NotImplementedException();
        }
    }
}