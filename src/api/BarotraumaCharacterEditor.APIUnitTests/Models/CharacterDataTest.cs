using BarotraumaCharacterEditor.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BarotraumaCharacterEditor.APIUnitTests.Models
{
    public class CharacterDataTest
    {
        [Fact]
        public void Unmarshal_characterdata()
        {
            XmlSerializer reader = new XmlSerializer(typeof(CharacterData));
            StreamReader file = new StreamReader(@"Resources\CharacterData.xml");
            CharacterData data = (CharacterData)reader.Deserialize(file);
            file.Close();

            Assert.Matches("Timo", data.CharacterCampaignData[0].name);
        }
    }
}
