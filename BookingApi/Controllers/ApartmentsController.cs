using System;
using Microsoft.AspNetCore.Mvc;

namespace BookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentsController : GenericBaseController<Apartments, IApartmentsService>
    {
        public ApartmentsController(IApartmentsService apartmentsService) : base(apartmentsService)
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
            return base.GetResponseByResultSuccess(base._service.GetApartmentsById(id));
        }
        [HttpGet("getbyemail")]
        public IActionResult GetByName(string Name)
        {
            return base.GetResponseByResultSuccess(base._service.GetApartmentsByName(Name));
        }
    }
}

