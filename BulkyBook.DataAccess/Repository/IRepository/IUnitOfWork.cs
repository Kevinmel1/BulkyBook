using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICoverTypeRepository CoverType { get; }
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
        void Save();
    }
}
