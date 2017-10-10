using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GaroLotoDAL;

namespace GaroLoto.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        IGameDal _game;

        public GameController(IGameDal game)
        {
            _game = game;
        }
        // GET api/game
        [HttpGet]
        public JsonResult Get()
        {
            var games = _game.GetGames();
            return Json(new { games = games });
        }

        // GET api/game/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/game
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/game/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/game/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
