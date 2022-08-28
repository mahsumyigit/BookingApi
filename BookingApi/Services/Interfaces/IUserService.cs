using System;
namespace BookingApi.Services.Interfaces
{
    public interface IUserService:IServiceBase<User>
    {
        IDataResult<User> GetUserById(int id);
        IDataResult<User> GetUserByName(string Name);
        IDataResult<List<User>> GetAll();
    }
}

