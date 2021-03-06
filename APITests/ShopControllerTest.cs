using System;
using System.Collections.Generic;
using System.Diagnostics;
using APITests.Helpers;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects.LaptopBrand;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SimpleComputerShopAPI.Controllers;
using SimpleComputerShopAPI.Profiles;
using Xunit;

namespace APITests
{
    public class ShopControllerTest
    {
        private IMapper _mapper;

        public ShopController NewLaptopBrandsShopController()
        {
            var testData = new TestData();
            TestsAutomapperInitialize();
            // Arrange
            var mockRepo = new Mock<IRepositoryManager>();
            var mockLogger = new Mock<ILoggerManager>();

            mockRepo.Setup(repo => repo.LaptopBrand.GetAllLaptopBrands(false))
                .ReturnsAsync(testData.GetLaptopBrands());

            return new ShopController(mockRepo.Object, mockLogger.Object, _mapper);
        }

        public ShopController NewLaptopConfigurationItemShopController()
        {
            var testData = new TestData();
            TestsAutomapperInitialize();
            // Arrange
            var mockRepo = new Mock<IRepositoryManager>();
            var mockLogger = new Mock<ILoggerManager>();
            var mockMapper = new Mock<IMapper>();

            mockRepo.Setup(repo => repo.LaptopConfigurationItem.GetLaptopConfigurationItems(false))
                .ReturnsAsync(testData.GetLaptopConfigurationItems());

            return new ShopController(mockRepo.Object, mockLogger.Object, mockMapper.Object);
        }

        public ShopController NewConfigurationCostsShopController(int configurationItemId)
        {
            var testData = new TestData();
            TestsAutomapperInitialize();
            // Arrange
            var mockRepo = new Mock<IRepositoryManager>();
            var mockLogger = new Mock<ILoggerManager>();
            var mockMapper = new Mock<IMapper>();

            mockRepo.Setup(repo => repo.LaptopConfigurationItem.GetSingleLaptopConfigurationItem(configurationItemId, false))
                .ReturnsAsync(testData.GetSingleLaptopConfigurationItem(configurationItemId));

            mockRepo.Setup(repo => repo.ConfigurationCost.GetAllConfigurationCostsOfItem(configurationItemId, false))
                .ReturnsAsync(testData.GetAllConfigurationCostsOfItem(configurationItemId));

            return new ShopController(mockRepo.Object, mockLogger.Object, mockMapper.Object);
        }
        public void TestsAutomapperInitialize()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MappingProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        [Fact(DisplayName = "1. Get laptop brands returns Ok result")]
        public async void Get_WhenCalled_LaptopBrands_ReturnsOkResult()
        {
            // Arrange
            var controller = NewLaptopBrandsShopController();

            // Act
            var okResult = await controller.GetAllLaptopBrands();

            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact(DisplayName = "2. Get laptop brands returns list of all laptop brands")]
        public async void Get_WhenCalled_LaptopBrands_ReturnsAllLaptopBrands()
        {
            // Arrange
            var controller = NewLaptopBrandsShopController();

            // Act
            var okResult = await controller.GetAllLaptopBrands() as OkObjectResult;

            // Assert
            if (okResult != null)
            {
                var items = Assert.IsType<List<LaptopBrandDto>>(okResult.Value);
                Trace.WriteLine(items.ToString());
                Assert.NotNull(items);
                Assert.Equal(3, items.Count);
            }
        }
    }
}