using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Models;

namespace Herhalingsoefening.Repositories
{
    public interface ILocalDatabaseRepository
    {
        Task<List<Movie>> GetWatched();
        void Setup();
    }
}