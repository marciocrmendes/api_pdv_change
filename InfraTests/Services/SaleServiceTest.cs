using Infra.Config;
using Infra.Interfaces.IServices;
using Infra.Repository.Dapper;
using Infra.Repository.EFCore;
using Infra.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraTests.Services
{
    public class SaleServiceTest
    {
        private ISaleService _service;

        [SetUp]
        public void Setup()
        {
            TestHelper.Init();
            _service = new SaleService(new SaleRepository(new ApiContext()), new SaleDapperRepository());
        }

        [Test]
        public void GetAll()
        {
            Assert.IsTrue(_service.GetAll().Any());
        }
    }
}
