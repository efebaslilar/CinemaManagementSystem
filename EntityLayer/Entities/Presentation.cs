using EntityLayer.AbstractEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    [Table("Presentations")]
    public class Presentation : Base<int>
    {
        public bool IsPresentation { get; set; }
        public int MovieId { get; set; }
        public byte SaloonId { get; set; }
        public byte SessionId { get; set; }

        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }

        [ForeignKey("SaloonId")]
        public virtual Saloon Saloon { get; set; }

        [ForeignKey("SessionId")]
        public virtual Session Session { get; set; }

        public override string ToString()
        {
            return $"{Movie}-{Saloon}-{Session}";
        }
    }
}
