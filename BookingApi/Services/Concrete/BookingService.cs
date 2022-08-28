using System;
using BookingApi.Services.Interfaces;

namespace BookingApi.Services.Concrete
{
    public class BookingService:IBookingService
    {
        private IBookingRepository _bookingRepository;
        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public IResult Add(Bookings entity)
        {
            var FindedBookings = _bookingRepository.Get(u => u.Id == entity.Id);
            if (FindedBookings == null)
            {
                _bookingRepository.Add(entity);
                return new SuccessResult("Add Bookings successful.");
            }
            return new ErrorResult("Bookings to be added already exists.");
        }

        public IResult Delete(Bookings entity)
        {
            var FindedBookings = _bookingRepository.Get(u => u.Id == entity.Id);
            if (FindedBookings != null)
            {
                _bookingRepository.Delete(entity);
                return new SuccessResult("Bookings user successful.");
            }
            return new ErrorResult("No Bookings found to delete.");
        }

        public IDataResult<List<Bookings>> GetAll()
        {
            return new SuccessDataResult<List<Bookings>>(_bookingRepository.GetAll());
        }

        public IDataResult<Bookings> GetBookingsById(int id)
        {
            return new SuccessDataResult<Bookings>(_bookingRepository.Get(u => u.Id == id));
        }

        public IDataResult<Bookings> GetBookingsByStartsAt(string StartsAt)
        {
            var FindedBookings = _bookingRepository.Get(u => u.StartsAt == StartsAt);
            if (FindedBookings != null)
            {
                return new SuccessDataResult<Bookings>(FindedBookings, "The requested Bookings has been brought.");
            }
            return new ErrorDataResult<Bookings>("requested Bookings not found.");
        }

        public IResult Update(Bookings entity)
        {
            var FindedBookings = _bookingRepository.Get(u => u.Id == entity.Id);
            if (FindedBookings != null)
            {
                _bookingRepository.Update(entity);
                return new SuccessResult("Update Bookings successful.");
            }
            return new ErrorResult("No Bookings found to update.");
        }
    }
}

