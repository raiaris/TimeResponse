using System;
using SolucionarApi.Repositories.Interfaces;

namespace SolucionarApi.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        private readonly string _connectionString;

        public BaseRepository(string conectionString)
        {
            _connectionString = conectionString;
        }
    }
}
