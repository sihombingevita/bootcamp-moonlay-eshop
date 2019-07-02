using ExtCore.Data.Abstractions;
using Inventories.Controllers;
using Moq;
using System;
using Xunit;

namespace Backend.WebApp.UnitTests.Controllers
{
    public class InventoryControllerTests : IDisposable
    {
        private readonly MockRepository _mockRepository;

        private readonly Mock<IStorage> _mockStorage;

        public InventoryControllerTests()
        {
            this._mockRepository = new MockRepository(MockBehavior.Strict);

            this._mockStorage = this._mockRepository.Create<IStorage>();
        }

        public void Dispose()
        {
            this._mockRepository.VerifyAll();
        }

        private InventoryController CreateInventoryController()
        {
            return new InventoryController(
                this._mockStorage.Object);
        }

        [Fact]
        public void Index_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateInventoryController();

            // Act
            var result = unitUnderTest.Index();

            // Assert
            Assert.True(false);
        }
    }
}