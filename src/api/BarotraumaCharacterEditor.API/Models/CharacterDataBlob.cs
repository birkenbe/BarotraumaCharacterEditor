using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarotraumaCharacterEditor.API.Models
{
    public class CharacterDataBlob
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Hash { get; set; }

        public string Data { get; set; }

        public CharacterDataBlob()
        {

        }
    }
}