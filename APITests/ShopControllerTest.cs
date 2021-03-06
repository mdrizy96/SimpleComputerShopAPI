using System;
using System.Collections.Generic;
using System.Diagnostics;
using APITests.Helpers;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects.LaptopBrand;
using Entities.DataTransferObjects.LaptopConfigurationItem;
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

            mockRepo.Setup(repo => repo.LaptopConfigurationItem.GetLaptopConfigurationItems(false))
                .ReturnsAsync(testData.GetLaptopConfigurationItems());

            return new ShopController(mockRepo.Object, mockLogger.Object, _mapper);
        }

        public ShopController NewConfigurationCostsShopController(int configurationItemId)
        {
            var testData = new TestData();
            TestsAutomapperInitialize();
            // Arrange
            var mockRepo = new Mock<IRepositoryManager>();
            var mockLogger = new Mock<ILoggerManager>();

            mockRepo.Setup(repo => repo.LaptopConfigurationItem.GetSingleLaptopConfigurationItem(configurationItemId, false))
                .ReturnsAsync(testData.GetSingleLaptopConfigurationItem(configurationItemId));

            mockRepo.Setup(repo => repo.ConfigurationCost.GetAllConfigurationCostsOfItem(configurationItemId, false))
                .ReturnsAsync(testData.GetAllConfigurationCostsOfItem(configurationItemId));

            return new ShopController(mockRepo.Object, mockLogger.Object, _mapper);
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

        // [Theory(DisplayName = "Add New Learning Resource")]
        [Fact(DisplayName = "2. Get laptop brands returns list of all laptop brands")]
        // [Trait("Learning Resource Tests", "Adding LR")]
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
                Assert.NotNull(items);
                Assert.Equal(3, items.Count);
            }
        }

        [Fact(DisplayName = "3. Get laptop configuration items returns Ok result")]
        public async void Get_WhenCalled_LaptopConfigurationItem_ReturnsOkResult()
        {
            // Arrange
            var controller = NewLaptopConfigurationItemShopController();

            // Act
            var okResult = await controller.GetLaptopConfigurationItems();

            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }
        
        [Fact(DisplayName = "4. Get laptop configuration items returns list of all possible config items")]
        public async void Get_WhenCalled_LaptopConfigurationItem_ReturnsAllLaptopConfigurationItems()
        {
            // Arrange
            var controller = NewLaptopConfigurationItemShopController();

            // Act
            var okResult = await controller.GetLaptopConfigurationItems() as OkObjectResult;

            // Assert
            if (okResult != null)
            {
                var items = Assert.IsType<List<LaptopConfigurationItemDto>>(okResult.Value);
                Assert.NotNull(items);
                Assert.NotEmpty(items);
                Assert.Equal(3, items.Count);
            }
        }
    }
}