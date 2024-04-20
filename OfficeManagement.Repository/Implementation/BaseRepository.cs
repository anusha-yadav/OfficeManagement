using Microsoft.EntityFrameworkCore;
using OfficeManagement.Data.Entities;
using OfficeManagement.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly OfficeDbContext Context;

        public BaseRepository(OfficeDbContext context)
        {
            Context = context;
        }

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        /// <summary>
        /// GetById Method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(object id)
        {
            return Context.Set<T>().Find(id);
        }

        /// <summary>
        ///  Insert Method
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        /// <summary>
        /// Update Method
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }
        /// <summary>
        /// Delete Method
        /// </summary>
        /// <param name="id"></param>
        public void Delete(object id)
        {
            var entityToDelete = Context.Set<T>().Find(id);
            if (entityToDelete != null)
            {
                Context.Set<T>().Remove(entityToDelete);
            }
        }

        /// <summary>
        /// Save Method
        /// </summary>
        public void SaveChanges()
        {
            Context.SaveChanges();
        }

    }
}
