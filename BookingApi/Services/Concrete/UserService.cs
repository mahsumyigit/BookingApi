using System;
using BookingApi.Model.Entity;

namespace BookingApi.Services.Concrete
{
    public class UserService:IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IResult Add(User entity)
        {
            var FindedUser = _userRepository.Get(u => u.Email == entity.Email);
            if (FindedUser == null)
            {
                _userRepository.Add(entity);
                return new SuccessResult("Add user successful.");
            }
            return new ErrorResult("User to be added already exists.");
        }

        public IResult Delete(User entity)
        {
            var FindedUser = _userRepository.Get(u => u.Email == entity.Email);
            if (FindedUser != null)
            {
                _userRepository.Delete(entity);
                return new SuccessResult("User deletion successful.");
            }
            return new ErrorResult("No user found to be deleted.");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userRepository.GetAll());
        }

        public IDataResult<User> GetUserById(int id)
        {
            return new SuccessDataResult<User>(_userRepository.Get(u => u.Id == id));
        }

        public IDataResult<User> GetUserByName(string Name)
        {
            var FindedUser = _userRepository.Get(u => u.FullName == Name);
            if (FindedUser != null)
            {
                return new SuccessDataResult<User>(FindedUser, "The requested user has been retrieved.");
            }
            return new ErrorDataResult<User>("Requested user not found\n.");
        }

        public IResult Update(User entity)
        {
            var FindedUser = _userRepository.Get(u => u.Email == entity.Email);
            if (FindedUser != null)
            {
                _userRepository.Update(entity);
                return new SuccessResult("User update successful\n.");
            }
            return new ErrorResult("No user found to update\n.");
        }
    }
}

