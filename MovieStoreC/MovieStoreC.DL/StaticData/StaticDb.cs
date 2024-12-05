using MovieStoreC.DL.Repositories;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.StaticData
{
    internal static class StaticDb
    {
        public static List<Actor> Actors { get; set; } = new List<Actor>()
        {
            new Actor ()
            {
                Id = 1,
                Name="Actor1"
            },
            new Actor()
            {
                Id = 2,
                Name="Actor2"
            },
            new Actor()
            {
                Id = 3,
                Name="Actor3"
            }
        };
        public static List<Movie> Movies { get; set; } = new List<Movie>()
        {

        };
    }
}

