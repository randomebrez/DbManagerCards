using CardGame.DAL.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.DAL.CRUD
{
    public class DbGateway : IDbGateway
    {
        private readonly CardContext _context;

        public DbGateway(CardContext context)
        {
            _context = context;
        }

        public async Task<DbCard> CardAddAsync(DbCard card)
        {
            DbCard addedCard = new DbCard();
            if (card != null)
            {
                try
                {
                    addedCard = (await _context.Cards.AddAsync(card).ConfigureAwait(false)).Entity;
                    _context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
            return addedCard;
        }

        public async Task<DbCard> CardGetAsync(int cardId)
        {
            var dbcard = await _context.Cards.FirstOrDefaultAsync(t => t.Id == cardId).ConfigureAwait(false);
            return dbcard;
        }

        public async Task<DbDeck> DeckAddAsync(DbDeck deck)
        {
            DbDeck addedDeck = new DbDeck();
            if (deck != null)
            {
                try
                {
                    addedDeck = (await _context.Decks.AddAsync(deck).ConfigureAwait(false)).Entity;
                    _context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
            return addedDeck;
        }

        public async Task<DbDeck> DeckGetAsync(int deckId)
        {
            var dbDeck = await _context.Decks.FirstOrDefaultAsync(t => t.Id == deckId).ConfigureAwait(false);
            return dbDeck;
        }

        public async Task<DbDeckLink> DeckLinkAddAsync(int deckId, int cardId)
        {
            var link = new DbDeckLink { DeckId = deckId, CardId = cardId };
            try
            {
                return (await _context.DeckLinks.AddAsync(link).ConfigureAwait(false)).Entity;
            }
            catch
            {
                throw;
            }
        }

        public async Task<DbDeckLink> DeckLinkGetAsync(int linkId)
        {
            var dbLink = await _context.DeckLinks.FirstOrDefaultAsync(t => t.Id == linkId).ConfigureAwait(false);
            return dbLink;
        }
    }
}
