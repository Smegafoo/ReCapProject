using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColourManager : IColourService
    {
        IColourDal _colourDal;
        public ColourManager(IColourDal _colourDal)
        {
            this._colourDal = _colourDal;
        }


        //CUD Operations
        public IResult add(Colour color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);
            }
            else
            {
                _colourDal.Add(color);
                return new SuccesResult(Messages.AddedColor);

            }
                
        }

        public IResult delete(int id)
        {
            var deletedColor=_colourDal.Get(p=>p.ColorId==id);

            if (deletedColor != null) { 
            _colourDal.Delete(deletedColor);
                return new SuccesResult(Messages.DeletedColor);
            
            }else
            {
                return new ErrorResult(Messages.ColorNotFound);

            }
        }

        public IResult update(Colour colour)
        {
            int colorId=colour.ColorId;
            var updatetoColor=_colourDal.Get(p=> p.ColorId==colorId);

            if (updatetoColor != null) { 

                updatetoColor.ColorName=colour.ColorName;
            
            _colourDal.Update(updatetoColor);
                return new SuccesResult(Messages.UpdatedColor);
            }
            else
            {
                return new ErrorResult(Messages.ColorNotFound);

            }
        }
        //**************************************************




        //Read Operations
        public IDataResult<List<Colour>> Get(int id)
        {
            var getById = _colourDal.Get(p => p.ColorId == id);
            if (getById!=null)
            {
                return new SuccesDataResult<List<Colour>>(new List<Colour> { getById }, Messages.ColorListed); 
                
            }
            else
            {
                return new ErrorDataResult<List<Colour>>(Messages.ColorNotFound);
            }
        }

        public IDataResult<List<Colour>> GetAll()
        {
            var colors=_colourDal.GetAll();
            if(colors!=null && colors.Count > 0)
            {
                return new SuccesDataResult<List<Colour>>(_colourDal.GetAll(),Messages.ColorListed);

            }
            else
            {
                return new ErrorDataResult<List<Colour>>(Messages.EmptyColorList);

            }
        }
        //*************************************************

        
    }
}
