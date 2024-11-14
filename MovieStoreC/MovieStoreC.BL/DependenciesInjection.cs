using Microsoft.Extensions.DependencyInjection;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.BL.Services;

namespace MovieStoreC.DL
{
    public static class DependenciesInjection
    {
        public static void RegisterService(this IServiceCollection service)
        {
            service.AddSingleton<IMoviesService, MoviesService>();

        }
    }
}
