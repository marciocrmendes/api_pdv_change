using Dapper.Contrib.Extensions;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Infra.IRepository;
using Infra.Mappings.DapperMap;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Infra.Repository.Dapper
{
    public abstract class DapperRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IConfiguration _configuration;
        protected readonly SqlConnection _connection;

        public DapperRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            if (FluentMapper.EntityMaps.IsEmpty)
            {
                FluentMapper.Initialize(c =>
                {
                    c.AddMap(new BanknoteDapperMap());
                    c.AddMap(new SaleDapperMap());
                    c.AddMap(new ProductDapperMap());
                    c.ForDommel();
                });
            }
            _connection = new SqlConnection(_configuration.GetConnectionString("PgsqlConnection"));
        }

        /// <summary>
        /// Retorna todos os itens
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _connection.GetAll<TEntity>();
        }

        /// <summary>
        /// Retorna pelo Id
        /// </summary>
        /// <returns></returns>
        public virtual TEntity GetById(int id)
        {
            return _connection.Get<TEntity>(id);
        }

        private bool _disposed = false;

        /// <summary>
        /// Destrutor do método
        /// </summary>
        ~DapperRepository() => Dispose();

        public void Dispose()
        {
            if (!_disposed)
            {
                _connection.Close();
                _connection.Dispose();
                _disposed = true;
            }
            GC.SuppressFinalize(this);
        }

        public bool Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
