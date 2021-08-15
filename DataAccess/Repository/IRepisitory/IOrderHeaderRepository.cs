using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository.IRepisitory
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader obj);

    }
}
