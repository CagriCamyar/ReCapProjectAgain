using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColourService
    {
        IResult Add(Colour colour);
        IResult Delete(Colour colour);
        IResult Update(Colour colour);
        IDataResult<List<Colour>> GetAll();
        IDataResult<Colour> GetById(int colourId);
    }
}
