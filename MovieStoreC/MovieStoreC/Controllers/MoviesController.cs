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

        [HttpGet("GetAll")]
        public IEnumerable<Movie> GetAll()
        {
            return _movieService.GetAll();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
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

        [HttpPost("Add")]
        public void Add([FromBody]AddMovieRequest movie)
        {
            var movieDto = _mapper.Map<Movie>(movie);

            _movieService.Add(movieDto);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            //return _movieService.GetById(id);
        }
    }
}
