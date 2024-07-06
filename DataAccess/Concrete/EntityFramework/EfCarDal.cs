using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectDbContext context = new ReCapProjectDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colours
                             on c.ColourId equals cl.ColourId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 ColourName = cl.ColourName,
                                 BrandName = b.BrandName,
                                 Description = c.Description,
                                 ModelYear = (short)c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                             };
                return result.ToList();
            }
        }
    }
}
