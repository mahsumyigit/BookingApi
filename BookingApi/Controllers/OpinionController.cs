using System;
using Microsoft.AspNetCore.Mvc;

namespace BookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpinionController : GenericBaseController<Opinions, IOpinionService>
    {
        public OpinionController(IOpinionService tService) : base(tService)
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
            return base.GetResponseByResultSuccess(base._service.GetOpinionsById(id));
        }
        [HttpGet("getbyopinion")]
        public IActionResult GetByName(string Opinion)
        {
            return base.GetResponseByResultSuccess(base._service.GetOpinionsByOpinion(Opinion));
        }
    }
}

