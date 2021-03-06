using AutoMapper;
using Contracts;
using Entities.DataTransferObjects.ConfigurationCost;
using Entities.DataTransferObjects.LaptopBrand;
using Entities.DataTransferObjects.LaptopConfigurationItem;
using Entities.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleComputerShopAPI.Controllers
{
    [Route("api/shop/laptops")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ShopController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("brands")]
        public async Task<IActionResult> GetAllLaptopBrands()
        {
            var brands = await _repository.LaptopBrand.GetAllLaptopBrands(trackChanges: false);
            var brandsToReturn = _mapper.Map<IEnumerable<LaptopBrandDto>>(brands);
            return Ok(brandsToReturn);
        }

        [HttpGet("config_options")]
        public async Task<IActionResult> GetLaptopConfigurationItems()
        {
            var options = await _repository.LaptopConfigurationItem.GetLaptopConfigurationItems(trackChanges: false);
            var optionsToReturn = _mapper.Map<IEnumerable<LaptopConfigurationItemDto>>(options);
            return Ok(optionsToReturn);
        }

        [HttpGet("config_options/{configurationItemId}/costs")]
        public async Task<IActionResult> GetConfigurationCostsOfItem(int configurationItemId)
        {
            var configurationItem =
                await _repository.LaptopConfigurationItem.GetSingleLaptopConfigurationItem(configurationItemId, false);
            if (configurationItem == null)
            {
                _logger.LogError($"Configuration item with id: {configurationItemId} not found in database");
                return NotFound(new ResponseDetails
                {
                    Success = false,
                    Message = "Configuration item not found"
                });
            }

            var configCosts = await _repository.ConfigurationCost.GetAllConfigurationCostsOfItem(configurationItemId, trackChanges: false);
            var configCostsToReturn = _mapper.Map<IEnumerable<ConfigurationCostDto>>(configCosts);
            return Ok(configCostsToReturn);
        }
    }
}