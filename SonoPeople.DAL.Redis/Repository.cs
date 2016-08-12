using SonoPeople.Infrastructure.Domain;
using SonoPeople.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonoPeople.DAL.Redis
{
    public abstract class Repository<T, TEntityKey> where T : IAggregateRoot
    {
        private IUnitOfWork _uow;

        public Repository(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Add(T entity)
        {
            
        }

        public void Remove(T entity)
        {
           
        }

        public void Save(T entity)
        {
           
        }

        public T GetBy(TEntityKey id)
        {
            return default(T);
        }

        public IEnumerable<T> GetAll()
        {       
            return null;
        }

        public IEnumerable<T> FindAll(int index, int count)
        {
            return null;
        }     

        
    }

}
