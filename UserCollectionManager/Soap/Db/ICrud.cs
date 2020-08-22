using CardGame.Soap.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Soap.Db
{
    public interface ICrud
    {
        Task<SoapCard> CardAddAsync(SoapCard card);

        Task<SoapCard> CardGetAsync(int cardId);

        Task<SoapDeck> DeckAddAsync(SoapDeck deck);

        Task<SoapDeck> DeckGetAsync(int deckId);
    }
}
