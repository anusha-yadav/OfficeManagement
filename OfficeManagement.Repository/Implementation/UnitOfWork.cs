using OfficeManagement.Data.Entities;
using OfficeManagement.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Repository.Implementation
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly OfficeDbContext Context;

        public UnitOfWork(OfficeDbContext context)
        {
            Context = context;
            Employee = new EmployeeRepository(context);
        }

        public IEmployeeRepository Employee
        {
            get;
            private set;
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
