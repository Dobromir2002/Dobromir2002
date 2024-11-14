using Microsoft.Extensions.DependencyInjection;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.DL.Repositories;

namespace MovieStoreC.DL
{
    public static class DependenciesInjection
    {
        public static void RegisterRepostitories(this IServiceCollection service)
        {
            service.AddSingleton<IMovieRepository, MovieStaticDataRepository>();

        }
    }
}
