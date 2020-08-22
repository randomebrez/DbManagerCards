using System;
using System.Collections.Generic;
using System.Text;
using Soap.Dto;
using System.Runtime.CompilerServices;
using System.Linq;
using ManagmentLayer.Dto;

namespace Soap.Mapping
{
    public static class Mapper
    {
        public static SoapCard ToUp(this Card card)
        {
            return new SoapCard
            {
                Id = card.Id,
                Name = card.Name
            };
        }

        public static Card ToDown(this SoapCard soapCard)
        {
            return new Card
            {
                Name = soapCard.Name
            };
        }

        public static SoapDeck ToUp(this Deck deck)
        {
            return new SoapDeck
            {
                Id = deck.Id,
                Name = deck.Name,
                Cards = deck.Cards.Select(t => t.ToUp()).ToList()
            };
        }

        public static Deck ToDown(this SoapDeck soapDeck)
        {
            return new Deck
            {
                Name = soapDeck.Name,
                Cards = soapDeck.Cards.Select(t => t.ToDown()).ToList()
            };
        }
    }
}

