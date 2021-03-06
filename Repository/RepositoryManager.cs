using Contracts;
using Contracts.Models;
using Entities;
using Repository.Models;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private ILaptopBrandRepository _laptopBrandRepository;
        private ILaptopConfigurationItemRepository _laptopConfigurationItemRepository;
        private IConfigurationCostRepository _configurationCostRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ILaptopBrandRepository LaptopBrand =>
            _laptopBrandRepository ??= new LaptopBrandRepository(_repositoryContext);

        public ILaptopConfigurationItemRepository LaptopConfigurationItem =>
            _laptopConfigurationItemRepository ??= new LaptopConfigurationItemRepository(_repositoryContext);

        public IConfigurationCostRepository ConfigurationCost =>
            _configurationCostRepository ??= new ConfigurationCostRepository(_repositoryContext);

        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}