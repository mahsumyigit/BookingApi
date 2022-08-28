using System;
namespace BookingApi.Repositories.Concrete
{
    public class UserRepository : EfEntityRepositoryBase<User, DbContextBase>, IUserRepository
    {
    }
}

