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
            return await _characterDataBlobRepository.Get(id);
        }

        [HttpPost]
        public void PostCharacterData()
        {

        }
    }
}
