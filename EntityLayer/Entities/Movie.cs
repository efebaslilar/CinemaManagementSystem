using EntityLayer.AbstractEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    [Table("Movies")]
    public class Movie : Base<int>
    {
        public string MovieName { get; set; }
        public string Director { get; set; }
        public int Duration { get; set; }
        public byte MovieTypeId { get; set; }

        //foregn key eklenecek!
        [ForeignKey("MovieTypeId")]
        public virtual MovieType MovieType { get; set; }

        public override string ToString()
        {
            return $"{MovieName}";
        }
    }
}
