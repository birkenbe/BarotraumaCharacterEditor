using BarotraumaCharacterEditor.API.Models;

namespace BarotraumaCharacterEditor.API.Repositories
{
    public interface ICharacterDataBlobRepository
    {
        Task<CharacterDataBlob?> Get(string id);

        Task<CharacterDataBlob> Create(CharacterDataBlob data);

        Task<CharacterDataBlob> Update(CharacterDataBlob data);

        Task Delete(string id);
    }
}
