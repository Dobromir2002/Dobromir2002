using MovieStoreC.Models.DTO;

namespace MovieStoreC.Models.Responses
{
    public class MovieFullDeatails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 

        public List<Actor> Actors { get; set; }
        public object Year { get; set; }
        public object Title { get; set; }
    }
}
