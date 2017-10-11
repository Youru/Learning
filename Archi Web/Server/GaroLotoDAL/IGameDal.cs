using Entities;
using System.Collections.Generic;

namespace GaroLotoDAL
{
    public interface IGameDal
    {
        IEnumerable<Game> GetGames();
    }
}
