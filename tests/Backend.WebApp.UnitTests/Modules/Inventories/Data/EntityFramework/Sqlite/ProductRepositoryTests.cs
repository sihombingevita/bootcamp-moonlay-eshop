using ExtCore.Data.Abstractions;
using Inventories.Data.EntityFramework.Sqlite;
using Moq;
using System;
using Xunit;

namespace Backend.WebApp.UnitTests
{
    public class ProductRepositoryTests : IDisposable
    {
        private readonly MockRepository _mockRepository;
        private readonly Mock<IStorageContext> _mockStorageContext;

        public ProductRepositoryTests()
        {
            this._mockRepository = new MockRepository(MockBehavior.Strict);

            this._mockStorageContext = this._mockRepository.Create<IStorageContext>();
        }

        public void Dispose()
        {
            this._mockRepository.VerifyAll();
        }

        private ProductRepository CreateProductRepository()
        {
            var repo = new ProductRepository();
            repo.SetStorageContext(_mockStorageContext.Object);

            return repo;
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var unitUnderTest = this.CreateProductRepository();

            // Act

            // Assert
            Assert.True(false);
        }
    }
}