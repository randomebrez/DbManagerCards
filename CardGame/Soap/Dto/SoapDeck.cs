using System.Collections.Generic;

namespace CardGame.Soap.Dto
{
    public class SoapDeck
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<SoapCard> Cards { get; set; }
    }
}
