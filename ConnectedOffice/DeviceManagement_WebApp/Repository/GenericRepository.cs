using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq.Expressions;


namespace DeviceManagement_WebApp.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class  //25903098 Created an interface for Generic Repository where T represents the type
    {
        protected readonly ConnectedOfficeContext _context;  //25903098 We set the overall _context here

        public GenericRepository(ConnectedOfficeContext context)
        {
            _context = context; //25903098 We set the overall _context here
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity); //25903098 Generic Add method
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);  //25903098 Generic Add Range method
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression); //25903098 Generic Find method, where some expression needs to be true
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList(); //25903098 We replace many of the controller Get methods with this Generic method
        }

        public T GetById(Guid? id)
        {
            return _context.Set<T>().Find(id); //25903098 Genereic Get method requiring and ID
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity); //25903098 Generic Remove method
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities); //25903098 Generic Remove by range method
        }

        public void SaveChanges()
        {
            _context.SaveChangesAsync(); //25903098 NEW custom save method (might not be needed but put it in for safety)
        }

    }
}
