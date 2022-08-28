using System;
namespace BookingApi.Services.Interfaces
{
    public interface IBookingService:IServiceBase<Bookings>
    {
        IDataResult<Bookings> GetBookingsById(int id);
        IDataResult<Bookings> GetBookingsByStartsAt(string StartsAt);
        IDataResult<List<Bookings>> GetAll();
    }
}

