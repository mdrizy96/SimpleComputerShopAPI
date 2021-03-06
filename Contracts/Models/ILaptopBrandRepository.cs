using Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts.Models
{
    public interface ILaptopBrandRepository
    {
        Task<IEnumerable<LaptopBrand>> GetAllLaptopBrands(bool trackChanges);
    }
}