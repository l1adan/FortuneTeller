using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_CRYSTaLLL_bub
{
    class Tarrot
    {
        //properties
        private Dictionary<string, string> TarrotCards { get; set; } = new Dictionary<string, string>(); 


      private string getCard()
        {
            Random random = new Random();
        }

       protected void TarotCards()
        {
            TarrotCards.Add("The Magician", "shows will and determination, of someone starting a journey. This is more a journey of personal enrichment, either material or spiritual. This is less of a beginning in the realm of personal relationships. There is initiative and some willingness to take risk and utilize the potential that rest within every individual. This card also shows tendency towards organizational and communicative skills.");

            TarrotCards.Add("The Lovers", "This card represents relationship, both physical romantic relationship, as well as that of friendship. Though many look at this card as a card symbolizing romance and family, this card is more about a choice.");

            TarrotCards.Add("The Chariot", "This card shows a strong figured man in armor, a conquer. He’s riding a chariot covered with a curtain of stars, drawn by one black and one white sphinx. Behind him is a fortified city. This is the card of victory through work.");
        }





        
    }

}
