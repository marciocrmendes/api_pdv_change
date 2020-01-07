using Dapper;
using Infra.Repository.Dapper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraTests.Dapper
{
    public class SaleDapperRepositoryTest
    {
        private SaleDapperRepository _saleDapperRepository;

        [SetUp]
        public void Setup()
        {
            _saleDapperRepository = new SaleDapperRepository();
        }

        [Test]
        public void RetornandoAlgumaVenda()
        {
            Assert.IsTrue(_saleDapperRepository.GetAll().AsList().Any());
        }
    }
}
