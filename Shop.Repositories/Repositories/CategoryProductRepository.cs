﻿using Shop.Entities.Enities;
using Shop.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repositories.Repositories
{
    public class CategoryProductRepository : GenericRepository<CategoryProduct>, ICategoryProductRepository
    {
        private readonly ShopContext _dbContext;
        public CategoryProductRepository(ShopContext shopContext) : base(shopContext)
        {
            _dbContext = shopContext;
        }

        public IQueryable<CategoryProduct> SelectByIDMenu(long idMenu)
        {
            var model = _dbContext.CategoryProducts.Where(c => c.IDMenu == idMenu);
            return model;
        }
        public IQueryable<CategoryProduct> SelectAllByStatus()
        {
            try
            {
                var model = _dbContext.CategoryProducts.Where(x => x.Status == true);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public IQueryable<CategoryProduct> SelectAllByDelete()
        {   
            try
            {
                var model = _dbContext.CategoryProducts.Where(x => x.IsDelete == false);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public long GetTotal()
        {
            return _dbContext.CategoryProducts.Where(x => x.IsDelete == false).Count();
        }
        public IQueryable<CategoryProduct> SelectByQuantityItem(int page, int pageSize)
        {
            var model = _dbContext.CategoryProducts.Where(x => x.IsDelete == false).Skip((page - 1) * pageSize).Take(pageSize);
            return model;
        }
    }
}
