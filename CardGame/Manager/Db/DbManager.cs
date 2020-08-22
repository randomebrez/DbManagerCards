using CardGame.DAL.CRUD;
using CardGame.DAL.Dto;
using CardGame.Manager.Dto;
using CardGame.Manager.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Manager.Db
{
    public class DbManager : IDbManager
    {
        private IDbGateway _gateway;

        public  DbManager(IDbGateway gateway)
        {
            _gateway = gateway;
        }

        public async Task<Card> CardAddAsync(Card card)
        {
            return (await _gateway.CardAddAsync(card.ToDown()).ConfigureAwait(false)).ToUp();
        }

        public async Task<Card> CardGetAsync(int cardId)
        {
            return (await _gateway.CardGetAsync(cardId).ConfigureAwait(false)).ToUp();
        }

        public async Task<Deck> DeckAddAsync(Deck deck)
        {
            var dbDeck = await _gateway.DeckAddAsync(deck.ToDown()).ConfigureAwait(false);
            foreach(var card in deck.Cards)
            {
                dbDeck.DeckLinks.Add(await _gateway.DeckLinkAddAsync(dbDeck.Id, card.Id).ConfigureAwait(false));
            }
            return dbDeck.ToUp();

        }

        public async Task<Deck> DeckGetAsync(int deckId)
        {
            return (await _gateway.DeckGetAsync(deckId).ConfigureAwait(false)).ToUp();
        }
    }
}
