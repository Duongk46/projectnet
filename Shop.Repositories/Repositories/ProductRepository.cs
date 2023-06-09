﻿using Shop.Entities.Enities;
using Shop.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repositories.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ShopContext _dbContext;
        public ProductRepository(ShopContext shopContext) : base(shopContext)
        {
            _dbContext = shopContext;
        }
        public IQueryable<Product> SelectByKeyWord(string search)
        {
            try
            {
                var model = _dbContext.Products.Where(x => x.Name.Contains(search) && x.Status == true);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public IQueryable<Product> SelectByKeyWordQuantityItem(int page,int pageSize,string search)
        {
            try
            {
                var model = _dbContext.Products.Where(x => x.Name.Contains(search) && x.Status == true).Skip((page - 1) * pageSize).Take(pageSize);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public IQueryable<Product> SelectAllProduct()
        {
            try
            {
                var model = _dbContext.Products.Where(x => x.Status == true);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public Product GetByID(long id)
        {
            try
            {
                var model = _dbContext.Products.SingleOrDefault(x => x.ID == id);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public IQueryable<Product> SelectRelatedProduct(long IDCategory,long ID)
        {
            try
            {
                var model = _dbContext.Products.Where(x => x.Status && x.IDCategoryProduct == IDCategory && x.ID != ID).OrderByDescending(x => x.CreatedDate).Take(8);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public IQueryable<Product> SelectNewProduct()
        {
            try
            {
                var model = _dbContext.Products.Where(x => x.Status == true);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public long GetTotalByIDCategory(long IDCategory)
        {
            return _dbContext.Products.Where(x => x.IDCategoryProduct == IDCategory && x.Status).Count();
        }
        public IQueryable<Product> SelectByIDCategoryQuantityItem(int page,int pageSize,long IDCategory)
        {
            try
            {
                var model = _dbContext.Products.Where(x => x.IDCategoryProduct == IDCategory && x.Status).Skip((page - 1) * pageSize).Take(pageSize);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public IQueryable<Product> SelectByIDCategory(long IDCategory)
        {
            try
            {
                var model = _dbContext.Products.Where(x => x.IDCategoryProduct == IDCategory);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public IQueryable<Product> SelectByQuantityItem(int page, int pageSize)
        {
            try
            {
                var model = _dbContext.Products.Where(x => x.ID != 0).Skip((page - 1) * pageSize).Take(pageSize);
                return model;
            }
            catch
            {
                return null;
            }
        }
        public long GetTotal()
        {
            return _dbContext.Products.Where(x => x.ID != 0).Count();
        }
    }
}
