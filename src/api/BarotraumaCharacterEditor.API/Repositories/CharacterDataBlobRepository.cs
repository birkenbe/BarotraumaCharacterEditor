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
            _context.CharacterDataBlobs.Add(data);
            await _context.SaveChangesAsync();

            return data;
        }

        public async Task Delete(string id)
        {
            CharacterDataBlob toRemove = await _context.CharacterDataBlobs.FindAsync(id);
            _context.CharacterDataBlobs.Remove(toRemove);
            await _context.SaveChangesAsync();
        }

        public async Task<CharacterDataBlob?> Get(string id)
        {
            if(string.IsNullOrEmpty(id) || _context.CharacterDataBlobs == null)
            {
                return null;
            }
            return await _context.CharacterDataBlobs.FindAsync(id);
        }

        public async Task Update(CharacterDataBlob data)
        {
            _context.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
