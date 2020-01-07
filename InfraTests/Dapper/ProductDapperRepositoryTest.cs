using Infra.Repository.Dapper;
using NUnit.Framework;

namespace InfraTests
{
    public class ProductDapperRepositoryTest
    {
        private ProductDapperRepository _productDapperRepository;

        [SetUp]
        public void Setup()
        {
            _productDapperRepository = new ProductDapperRepository();
        }

        [Test]
        public void GetById()
        {
            Assert.Pass("teste 1 2 3");
        }
    }
}