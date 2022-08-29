using System;
using Microsoft.AspNetCore.Mvc;

namespace BookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : GenericBaseController<Bookings, IBookingService>
    {
        public BookingController(IBookingService bookingService) : base(bookingService)
        {
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return base.GetResponseByResultSuccess(base._service.GetAll());
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return base.GetResponseByResultSuccess(base._service.GetBookingsById(id));
        }
        [HttpGet("getbystartat")]
        public IActionResult GetByStartAt(string StartAt)
        {
            return base.GetResponseByResultSuccess(base._service.GetBookingsByStartsAt(StartAt));
        }
    }
}

