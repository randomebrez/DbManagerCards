using ManagmentLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentLayer.DbGateway.Interface
{
    public interface IDbGateway
    {
        Task<Card> CardAddAsync(Card card);

        Task<Card> CardGetAsync(int cardId);

        Task<Deck> DeckAddAsync(Deck deck);

        Task<Deck> DeckGetAsync(int deckId);

        //Task<DeckLink> DeckLinkAddAsync(int deckId, int cardId);

        //Task<DeckLink> DeckLinkGetAsync(int linkId);
    }
}
