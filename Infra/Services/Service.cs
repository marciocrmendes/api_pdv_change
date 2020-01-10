using Infra.Interfaces.IServices;
using Infra.IRepository;
using Infra.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Services
{
    public abstract class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _entityRepository;
        private readonly IDapperRepository<T> _dapperRepository;

        protected Service(IRepository<T> entityRepository, IDapperRepository<T> dapperRepository)
        {
            _entityRepository = entityRepository;
            _dapperRepository = dapperRepository;
        }

        public bool Add(T entity)
        {
            return _entityRepository.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            using (_dapperRepository)
            {
                return _dapperRepository.GetAll();
            }
        }

        public T GetById(int id)
        {
            using (_dapperRepository)
            {
                return _dapperRepository.GetById(id);
            }
        }

        public bool Remove(T entity)
        {
            return _entityRepository.Remove(entity);
        }

        public bool Update(T entity)
        {
            return _entityRepository.Update(entity);
        }
    }
}
