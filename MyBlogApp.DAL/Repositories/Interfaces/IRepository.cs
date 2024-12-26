using Microsoft.EntityFrameworkCore;
using MyBlogApp.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogApp.DAL.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        public DbSet<TEntity> Table { get; }
        public TEntity GetById(int id);
        public IQueryable<TEntity> GetAll();
    }
}
