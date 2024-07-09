using Core.DataAcces;
using Core.DataAcces.EfEntityRepository;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfColourDal : EfEntityRepositoryBase<Colour,MySQlContext>,IColourDal
    {
    }
}
