using Dapper;
using Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace GaroLotoDAL
{
    public class GameDal : IGameDal
    {
        private string _connectionString;

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public GameDal(IOptions<Configuration> configuration)
        {
            _connectionString = configuration.Value.DefaultConnection;
        }

        public IEnumerable<Game> GetGames()
        {
            using (var conn = Connection)
            {
                var cmd = new CommandDefinition(
                    "SELECT * FROM [GaroLoto].Game");

                return SqlMapper.Query<Game>(conn, cmd);

            }
        }
    }
}
