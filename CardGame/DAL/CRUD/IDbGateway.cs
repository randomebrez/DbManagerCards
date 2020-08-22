﻿using CardGame.DAL.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.DAL.CRUD
{
    public interface IDbGateway
    {
        Task<DbCard> CardAddAsync(DbCard card);

        Task<DbCard> CardGetAsync(int cardId);

        Task<DbDeck> DeckAddAsync(DbDeck deck);

        Task<DbDeck> DeckGetAsync(int deckId);

        Task<DbDeckLink> DeckLinkAddAsync(int deckId, int cardId);

        Task<DbDeckLink> DeckLinkGetAsync(int linkId);
    }
}
