using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Models;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models
{
    public class LaptopBrandRepository : RepositoryBase<LaptopBrand>, ILaptopBrandRepository
    {
        public LaptopBrandRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<LaptopBrand>> GetAllLaptopBrands(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(lb => lb.Cost)
                .ToListAsync();
        }
    }
}