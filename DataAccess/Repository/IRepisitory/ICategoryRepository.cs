using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository.IRepisitory
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
