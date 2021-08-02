using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository.IRepisitory
{
    public interface IApplicationTypeRepository : IRepository<ApplicationType>
    {
        void Update(ApplicationType obj);
    }
}
