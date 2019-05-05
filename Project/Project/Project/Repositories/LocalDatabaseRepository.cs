using Flurl.Http;
using Herhalingsoefening.Context;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoefening.Repositories
{
    public class LocalDatabaseRepository : ILocalDatabaseRepository
    {
        private string Path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "watched.db");
        public LocalDatabaseRepository()
        {
            Setup();
        }

        public void Setup()
        {
            try
            {
                using (var db = new DatabaseContext(Path))
                {
                    db.Database.EnsureCreated();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<List<Movie>> GetWatched()
        {
            try
            {
                var result = Path.GetJsonAsync<List<Movie>>();
                return result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public List<int> AddWatched()
        //{
        //    try
        //    {

        //    }

        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
