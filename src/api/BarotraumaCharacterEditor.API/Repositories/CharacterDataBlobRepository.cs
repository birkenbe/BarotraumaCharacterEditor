using BarotraumaCharacterEditor.API.Models;

namespace BarotraumaCharacterEditor.API.Repositories
{
    public class CharacterDataBlobRepository : ICharacterDataBlobRepository
    {
        private readonly CharacterDataBlobContext _context;

        public CharacterDataBlobRepository(CharacterDataBlobContext characterDataBlobContext)
        {
            _context = characterDataBlobContext;
        }

        public async Task<CharacterDataBlob> Create(CharacterDataBlob data)
        {
            _context.CharacterDataBlob.Add(data);
            await _context.SaveChangesAsync();

            return data;
        }

        public async Task Delete(string id)
        {
            CharacterDataBlob toRemove = await _context.CharacterDataBlob.FindAsync(id);
            _context.CharacterDataBlob.Remove(toRemove);
            await _context.SaveChangesAsync();
        }

        public Task<CharacterDataBlob> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CharacterDataBlob data)
        {
            throw new NotImplementedException();
        }
    }
}
