using Models.Entities;
using Clappon;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Clappon.Services
{
    public class UnitService : IUnitService
    {
        private ClapponContext _dbContext;

        public UnitService(ClapponContext ClapponContext)
        {
            _dbContext = ClapponContext;
        }
        public List<Unit>  GetAll()
        {
           return _dbContext.Units.OrderBy(x => x.UnitName).ToList();
         
        } 
        public Unit GetUnitById(int id)
        {
            return _dbContext.Units.Where(o => o.UnitId==id).FirstOrDefault();        
        }  
        public Unit SaveUnit(Unit unit)
        {
            if (unit != null)
            {
                if (unit.UnitId == 0)
                {
                    unit.Timestamp = DateTime.UtcNow;
                    unit.CreatedTime = DateTime.UtcNow;
                    _dbContext.Units.Add(unit);
                }
                else
                {
                    unit.Timestamp = DateTime.UtcNow;
                     _dbContext.Units.Update(unit);
                }
                _dbContext.SaveChanges();
                return unit;
            }
            else
            {
                throw new ArgumentNullException("Unit");
            }
        }
        
    }
}
