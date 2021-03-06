using Models.Entities;
using Clappon;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Clappon.Services
{
    public class BrandService : IBrandService
    {
        private ClapponContext _dbContext;

        public BrandService(ClapponContext ClapponContext)
        {
            _dbContext = ClapponContext;
        }
        public List<Brand>  GetAll()
        {
            return _dbContext.Brands.OrderBy(x => x.BrandName).ToList();
         
        }   
         public Brand GetBrandById(int id)

        {
            return _dbContext.Brands.Where(o => o.BrandId==id).FirstOrDefault();
         
        } 
        public bool DeleteBrand(Brand brand)
        {
            if (brand != null)
            {              
                _dbContext.Brands.Remove(brand);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                throw new ArgumentNullException("Brand");
            }
         
        }    
        public Brand SaveBrand(Brand brand)
        {
            if (brand != null)
            {
                if (brand.BrandId == 0)
                {
                    brand.Timestamp = DateTime.UtcNow;
                    brand.CreatedTime = DateTime.UtcNow;
                    _dbContext.Brands.Add(brand);
                }
                else
                {
                    brand.Timestamp = DateTime.UtcNow;
                     _dbContext.Brands.Update(brand);
                }
                _dbContext.SaveChanges();
                return brand;
            }
            else
            {
                throw new ArgumentNullException("Brand");
            }
            
        }
    }
}
