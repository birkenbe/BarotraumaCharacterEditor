using BarotraumaCharacterEditor.API.Models;
using BarotraumaCharacterEditor.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarotraumaCharacterEditor.API.Controllers
{
    [Route("api/characterData")]
    [ApiController]
    public class CharacterDataBlobController : ControllerBase
    {
        private readonly ICharacterDataBlobRepository _characterDataBlobRepository;

        public CharacterDataBlobController(ICharacterDataBlobRepository characterDataBlobRepository1)
        {
            _characterDataBlobRepository = characterDataBlobRepository1;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterDataBlob>> GetCharacterData(string id)
        {
            CharacterDataBlob? characterData = await _characterDataBlobRepository.Get(id);
            if(characterData == null)
            {
                return NotFound();
            }
            return Ok(characterData);
        }

        [HttpPost]
        public void PostCharacterData()
        {

        }
    }
}
