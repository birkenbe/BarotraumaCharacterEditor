using Microsoft.EntityFrameworkCore;

namespace BarotraumaCharacterEditor.API.Models
{
    public class CharacterDataBlobContext : DbContext
    {
        public CharacterDataBlobContext(DbContextOptions<CharacterDataBlobContext> options)
            : base(options)
        {
            
        }

        public DbSet<CharacterDataBlob> CharacterDataBlob { get; set; }
    }
}
