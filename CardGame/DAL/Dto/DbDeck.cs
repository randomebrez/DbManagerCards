﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CardGame.DAL.Dto
{
    [Table("decks")]
    public class DbDeck
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public ICollection<DbDeckLink> DeckLinks { get; set; }
    }
}