using Microsoft.EntityFrameworkCore;
using MyBlogApp.Core.Entities.Common;
using MyBlogApp.DAL.Context;
using MyBlogApp.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogApp.DAL.Repositories.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        readonly BlogDbContext _context;

        public Repository(BlogDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public IQueryable<TEntity> GetAll()
        {
            return Table;
        }

        public TEntity GetById(int id)
        {
            return Table.FirstOrDefault(x => x.Id == id);
        }
    }
}
