using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CardGame.DAL.Dto
{
    [Table("deckLinks")]
    public class DbDeckLink
    {
        public int Id { get; set; }

        public int DeckId { get; set; }

        public int CardId { get; set; }

        public DbDeck Deck { get; set; }

        public DbCard Card { get; set; }
    }
}
