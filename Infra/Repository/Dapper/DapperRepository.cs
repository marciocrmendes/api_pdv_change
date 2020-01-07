using Dapper.Contrib.Extensions;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Infra.IRepository;
using Infra.Mappings.DapperMap;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Infra.Repository.Dapper
{
    public abstract class DapperRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly NpgsqlConnection _connection;

        protected DapperRepository()
        {
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
            _connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=apitest;User Id=postgres;Password=postgres;");
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
