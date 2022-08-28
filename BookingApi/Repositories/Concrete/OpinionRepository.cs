using System;
using System.Linq.Expressions;

namespace BookingApi.Repositories.Concrete
{
    public class OpinionRepository : EfEntityRepositoryBase<Opinions, DbContextBase>, IOpinionRepository
    {
    }
}

