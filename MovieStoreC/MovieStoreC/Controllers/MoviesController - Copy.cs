using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.Models.DTO;
using MovieStoreC.Models.Requests;

namespace MovieStoreC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinesContoller : ControllerBase
    {
        private readonly BusinesContoller _blService;

        public BusinesContoller(BusinesContoller movieService)
        {
            _blService = (BusinesContoller?)movieService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllDetailsMovies()
        {
            var result = _blService.GetAllDetailsMovies();

            if (result == null && result.Count > 0)
            {

            }

            result Ok(Results);
        }
    }
}
