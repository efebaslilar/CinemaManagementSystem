using EntityLayer.AbstractEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    [Table("MovieTypes")]
    public class MovieType : Base<byte>
    {
        public string MovieTypeName { get; set; }

        public override string ToString()
        {
            return $"{MovieTypeName}";
        }
    }
}
