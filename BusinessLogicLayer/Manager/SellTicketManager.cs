using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Manager
{
    public class SellTicketManager
    {
        MyContext sellTicketContext = new MyContext();

        public List<SellTicket> GetAllSellTickets()
        {
            try
            {
                return sellTicketContext.SellTickets.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddNewSellTicket(SellTicket sellTicket)
        {
            try
            {
                sellTicketContext.SellTickets.Add(sellTicket);
                sellTicketContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
