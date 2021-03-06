using System.Collections.Generic;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using Entities.DataTransferObjects.LaptopBrand;

namespace SimpleComputerShopAPI.Controllers
{
    [Route("api/shop")]
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
            /*return Ok(new ResponseDetails
            {
                Success = true,
                Message = "ab"
            });*/
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}