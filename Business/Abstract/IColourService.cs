using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColourService
    {
        IResult add(Colour color);
        IResult delete(int id);
        IResult update (Colour color);

        IDataResult<List<Colour>> Get(int id);

        IDataResult<List<Colour>> GetAll();
    }
}
