﻿using Core.Utilities.Result;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<Rental>> GetAll(); 
        IDataResult<Rental> GetByRentalId(int rentalId);
        IDataResult<Rental> GetByCarId(int carId);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}
