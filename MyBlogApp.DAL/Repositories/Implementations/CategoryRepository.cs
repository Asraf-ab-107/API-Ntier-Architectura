using MyBlogApp.Core.Entities;
using MyBlogApp.DAL.Context;
using MyBlogApp.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogApp.DAL.Repositories.Implementations
{
    public class CategoryRepository:Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(BlogDbContext dbContext) : base(dbContext) { }    
    }
}
