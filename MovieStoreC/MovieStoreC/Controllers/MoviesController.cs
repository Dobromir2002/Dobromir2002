using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.Models.DTO;
using MovieStoreC.Models.Requests;

namespace MovieStoreC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _movieService;
        private readonly IMapper _mapper;

        public MoviesController(
            IMoviesService movieService,
            IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        public IMoviesService Get_movieService()
        {
            return _movieService;
        }

        [HttpGet("GetAll")]
        public IActionResult<Movie> GetAll(IMoviesService _movieService)
        {
            var result = _movieService.GetAll();

            if (result != null || result.Count <= 0)
            {
                return (IActionResult<Movie>)NotFound();
            }
            return (IActionResult<Movie>)Ok(result);
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] AddMovieRequest movie)
        {
            var movieDto = _mapper.Map<Movie>(movie);

            _movieService.Add(movieDto);

            return Ok(movieDto);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            //return _movieService.GetById(id);
        }

        [HttpGet("GetById")]
        private IActionResult GetById(int id, IMoviesService _movieService)
        {
            if (id <= 0)
            {
                return BadRequest($"Wrong ID:{id}");
            }

            var result = _movieService.GetById(id);

            if (result == null)
            {
                return NotFound($"Movie with ID:{id} not found");
            }

            return Ok(result);
        }
    }
}
