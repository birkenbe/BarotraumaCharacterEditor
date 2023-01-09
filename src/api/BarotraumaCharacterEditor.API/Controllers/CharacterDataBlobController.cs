using BarotraumaCharacterEditor.API.Models;
using BarotraumaCharacterEditor.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

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

        [HttpPut]
        public async Task<ActionResult<CharacterDataBlob>> PutCharacterData(string id, [FromBody] string rawData)
        {
            string hash = Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(rawData)));

            CharacterDataBlob? characterData = await _characterDataBlobRepository.Get(hash);
            CharacterDataBlob toUpsert = new(hash, rawData);
            if (characterData == null)
            {
                CharacterDataBlob newData = await _characterDataBlobRepository.Create(toUpsert);
                return CreatedAtAction(nameof(PutCharacterData), new { id }, newData);
            }
            return CreatedAtAction(nameof(PutCharacterData), new { id }, toUpsert);
        }

        [HttpPost("/changeJob")]
        public async Task<ActionResult<CharacterDataBlob>> ChangeJob(string targetPlayerName, string changeToJob, [FromBody] string rawData)
        {
            XElement xmlData = XElement.Parse(rawData);
            XElement? targetPlayer = xmlData.Descendants("Character").First(node => node.Attribute("name")?.Value == targetPlayerName);
            if(targetPlayer != null)
            {
                XElement job = targetPlayer.Descendants("job").First();
            }
        }
    }
}
