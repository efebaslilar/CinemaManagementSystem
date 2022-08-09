using EntityLayer.AbstractEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    [Table("Sessions")]
    public class Session : Base<byte>
    {
        public string MovieSession { get; set; }

        public override string ToString()
        {
            return $"{MovieSession}";
        }
    }
}
