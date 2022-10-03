using Assignment1;
using Assignment4RESTAPI.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment4RESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayersController : ControllerBase
    {
        private FootballPlayersManager _footballPlayersManager = new FootballPlayersManager();

        // GET: api/<IPAController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return _footballPlayersManager.GetAll();
        }

        // GET api/<IPAController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public ActionResult<FootballPlayer> GetById(int id)
        {
            FootballPlayer footballPlayer = _footballPlayersManager.GetById(id);
            if (footballPlayer == null) return NotFound("No such item, id: " + id);
            return Ok(footballPlayer);
        }

        // POST api/<IPAController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<FootballPlayer> Post([FromBody] FootballPlayer value)
        {
            FootballPlayer footballPlayer = _footballPlayersManager.Add(value);
            if (value == null) return BadRequest("Item Couldn't be created. double check properties");
            return Ok(footballPlayer);
        }

        // PUT api/<IPAController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public ActionResult<FootballPlayer> Put(int id, [FromBody] FootballPlayer value)
        {
            FootballPlayer footballPlayer = _footballPlayersManager.Update(id, value);
            if (footballPlayer == null) return NotFound("No such item, id: " + id);
            return Ok(footballPlayer);
        }

        // DELETE api/<IPAController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public ActionResult<FootballPlayer> Delete(int id)
        {
            FootballPlayer footballPlayer = _footballPlayersManager.Delete(id);
            if (footballPlayer == null) return NotFound("No such item, id: " + id);
            return Ok(footballPlayer);
        }


    }
}
