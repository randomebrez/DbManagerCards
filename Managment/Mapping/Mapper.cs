using DAL.Dto;
using ManagmentLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ManagmentLayer.Mapping
{
    public static class Mapper
    {
        public static DbCard ToDown(this Card card)
        {
            return new DbCard
            {
                Name = card.Name
            };
        }

        public static Card ToUp(this DbCard dbCard)
        {
            return new Card
            {
                Id = dbCard.Id,
                Name = dbCard.Name
            };
        }

        public static Deck ToUp(this DbDeck dbDeck)
        {
            return new Deck
            {
                Id = dbDeck.Id,
                Name = dbDeck.Name,
                Cards = dbDeck.DeckLinks.Select(t => t.Card.ToUp()).ToList()
            };
        }

        public static DbDeck ToDown(this Deck deck)
        {
            return new DbDeck
            {
                Name = deck.Name
            };
        }
    }
}
