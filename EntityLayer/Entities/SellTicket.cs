using EntityLayer.AbstractEntities;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntityLayer.Entities
{
    [Table("SellTickets")]
    public class SellTicket : Base<int>
    {
        public int PresentationId { get; set; }
        public string CustomerNameSurname { get; set; }

        [ForeignKey("PresentationId")]
        public virtual Presentation Presentation { get; set; }
        
    }
}
