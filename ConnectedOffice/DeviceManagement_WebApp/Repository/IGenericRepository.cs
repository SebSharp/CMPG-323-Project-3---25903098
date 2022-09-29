using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DeviceManagement_WebApp.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(Guid? id); //25903098 References the Get by some ID method
        IEnumerable<T> GetAll(); //25903098 References the generic get everything in a list method
        IEnumerable<T> Find(Expression<Func<T, bool>> expression); //25903098 References the generic find method by some expression that needs to be true
        void Add(T entity); //25903098 References the generic Add method
        void AddRange(IEnumerable<T> entities); //25903098 References the generic Add some range method
        void Remove(T entity); //25903098 References the generic remove method
        void RemoveRange(IEnumerable<T> entities); //25903098 References the generic remove some range method
        public void SaveChanges(); //25903098 NEW Save method for safety


    }
}
