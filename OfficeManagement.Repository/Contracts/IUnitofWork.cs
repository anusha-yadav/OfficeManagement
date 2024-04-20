using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Repository.Contracts
{
    public interface IUnitofWork
    {
        public void Save();
    }
}
