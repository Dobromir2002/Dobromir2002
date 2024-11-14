using Microsoft.AspNetCore.Mvc;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }
             

        [HttpGet("getall")]
        public IEnumerable<Movie> Get(IMoviesService _moviesService)
        {
            return _moviesService.GetAll();
            
               
        }
    }
}
