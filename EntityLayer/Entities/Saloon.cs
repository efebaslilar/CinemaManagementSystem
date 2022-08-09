using EntityLayer.AbstractEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    [Table("Saloons")]
    public class Saloon : Base<byte>
    {
        public string SaloonNo { get; set; }
        public int SeatNo { get; set; }

        public override string ToString()
        {
            return $"{SaloonNo}";
        }
    }
}
