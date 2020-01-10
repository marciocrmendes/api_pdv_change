using Infra.IRepository.Dapper;
using Infra.Repository.Dapper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraTests.Dapper
{
    public class BanknoteDapperRepositoryTests
    {
        private IBanknoteDapperRepository _banknoteDapperRepository;

        [SetUp]
        public void Setup()
        {
            _banknoteDapperRepository = new BanknoteDapperRepository();
        }

        [Test]
        public void Find_A_Especified_Banknote()
        {
            var banknote = _banknoteDapperRepository.GetById(1);

            Assert.IsTrue(banknote != null && banknote.Id == 1);

        }

        public void Return_All_Banknotes()
        {
            var banknotes = _banknoteDapperRepository.GetAll();

            Assert.IsTrue(banknotes.Any());

        }
    }
}
