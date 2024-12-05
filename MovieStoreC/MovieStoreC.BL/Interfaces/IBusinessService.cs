using MovieStoreC.Models.Responses;

namespace MovieStoreC.BL.Interfaces
{
    internal interface IBusinessService
    {       
        List<MovieFullDeatails> GetMovieFullDeatails();
    }
}
