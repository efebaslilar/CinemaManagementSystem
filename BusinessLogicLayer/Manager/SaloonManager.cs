using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Manager
{
    public class SaloonManager
    {
        MyContext SaloonContext = new MyContext();

        public List<Saloon> GetAllSaloon()
        {
            try
            {
                List<Saloon> saloons = SaloonContext.Saloons.ToList();
                return saloons;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddSaloon(Saloon saloon)
        {
            try
            {
                SaloonContext.Saloons.Add(saloon);
                SaloonContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
