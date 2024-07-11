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
    public class UserManager : IUserService
    {

        IUserDal _userDal;
        public UserManager(IUserDal _userDal)
        {
            this._userDal = _userDal;
        }


        //CUD Operations
        public IResult add(User user)
        {
            if (user.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.UserNameInvalid);

            }
            else
            {
                _userDal.Add(user);
                return new SuccesResult(Messages.AddedUser);
            }
        }

        public IResult delete(int id)
        {
            var deletedUser=_userDal.Get(p=> p.UserId == id);
            if (deletedUser != null) { 
            _userDal.Delete(deletedUser);   
                return new SuccesResult(Messages.DeletedUser);
            }
            else
            {
                return new ErrorResult(Messages.UserNotFound);
            }
        }
        public IResult update(User user)
        {
            var userId=user.UserId;
            var updatedUser=_userDal.Get(p=> p.UserId == userId);
            if (updatedUser != null) {

                updatedUser.FirstName = user.FirstName;
                updatedUser.LastName = user.LastName;
                updatedUser.Email = user.Email;
                updatedUser.Passwordd = user.Passwordd;

                _userDal.Update(updatedUser);

                return new SuccesResult(Messages.UpdatedUser);
            
            }else
            {
                return new ErrorResult(Messages.UserNotFound);
            }
        }
        //************************************************





        //Read Operations
        public IDataResult<List<User>> GetAll()
        {
            var users = _userDal.GetAll();
            if(users !=null && users.Count > 0)
            {
                return new SuccesDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
            }
            else
            {
                return new ErrorDataResult<List<User>>(Messages.EmptyUserList);
            }
        }

        public IDataResult<List<User>> Get(int id)
        {
            var getById=_userDal.Get(p=> p.UserId== id);

            if(getById != null)
            {
                return  new SuccesDataResult<List<User>>(new List<User> { getById },Messages.UserListed);
            }
            else
            {
                return new ErrorDataResult<List<User>>(Messages.UserNotFound);
            }
        }
        //*********************************************************

        
    }
}
