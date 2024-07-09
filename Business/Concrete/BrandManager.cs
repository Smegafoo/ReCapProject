using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal _brandDal)
        {
            this._brandDal = _brandDal;
        }

        //CUD Operations
        public IResult add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            else
            {
                _brandDal.Add(brand);
                return new SuccesResult(Messages.AddedBrand);
            }
        }

        public IResult delete(int id)
        {
            List<Brand> brandList = _brandDal.GetAll();
            for (int i = 0; i < brandList.Count; i++)
            {
                if (id == brandList[i].BrandId)
                {
                    _brandDal.Delete(brandList[i]);
                    return new SuccesResult(Messages.DeletedBrand);
                }

            }

            return new ErrorResult(Messages.BrandNotFound);
        }

        public IResult update(Brand brand)
        {
            int brandId = brand.BrandId;
            var brandtoUpdate=_brandDal.Get(p =>p.BrandId == brandId);

            if(brandtoUpdate == null)
            {
                return new ErrorResult(Messages.BrandNotFound);
            }
            brandtoUpdate.BrandName= brand.BrandName;

            _brandDal.Update(brandtoUpdate);
            return new SuccesResult(Messages.UpdatedBrand);
        }
        //**************************************************



        //Read Operations
        public IDataResult<List<Brand>> Get(int id)
        {
            var getById=_brandDal.Get(p=> p.BrandId == id);
            
            if(getById != null)
            {
                return new SuccesDataResult<List<Brand>>(new List<Brand> {getById},Messages.BrandListed);
            }
            else
                return new ErrorDataResult<List<Brand>>(Messages.BrandNotFound);
                    
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var brands = _brandDal.GetAll();
            if(brands != null && brands.Count > 0)
            {
                return new SuccesDataResult<List<Brand>>(_brandDal.GetAll(),Messages.BrandListed);
            }
            else
                return new ErrorDataResult<List<Brand>>(Messages.EmptyBrandList);
        }
        //**********************************************
        
    }
}
