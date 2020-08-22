using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Dto
{
    [Table("cards")]
    public class DbCard
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<DbDeckLink> DeckLinks { get; set; }
    }
}
