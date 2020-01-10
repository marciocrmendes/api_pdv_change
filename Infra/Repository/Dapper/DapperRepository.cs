using Dapper.Contrib.Extensions;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Infra.Interfaces;
using Infra.IRepository;
using Infra.Mappings.DapperMap;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Infra.Repository.Dapper
{
    public abstract class DapperRepository<T> : IDapperRepository<T> where T : class
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
        public virtual IEnumerable<T> GetAll()
        {
            return _connection.GetAll<T>();
        }

        /// <summary>
        /// Retorna pelo Id
        /// </summary>
        /// <returns></returns>
        public virtual T GetById(int id)
        {
            return _connection.Get<T>(id);
        }


        #region IDisposable Support
        private bool _disposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    GC.SuppressFinalize(this);
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                _connection.Close();
                _connection.Dispose();

                _disposed = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.

        /// <summary>
        /// Destrutor do método
        /// </summary>
        ~DapperRepository()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
