using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GaroLotoDAL
{
    public interface IGameDal
    {
        IEnumerable<Game> GetGames();
    }
}
