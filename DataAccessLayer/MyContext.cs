using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyCon")
        {

        }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieType> MovieTypes { get; set; }
        public virtual DbSet<Saloon> Saloons { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<SellTicket> SellTickets { get; set; }
        public virtual DbSet<Presentation> Presentations { get; set; }
    }
}
