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
        public void Returning_All_Sales()
        {
            Assert.IsTrue(_saleDapperRepository.GetAll().Any());
        }

        [Test]
        public void Returning_Banknotes_From_Especified_Sale()
        {
            var sale = _saleDapperRepository.GetById(1);

            
        }
    }
}
