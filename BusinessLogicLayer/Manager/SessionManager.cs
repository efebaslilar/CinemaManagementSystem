using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Manager
{
    public class SessionManager
    {
        MyContext SessionContext = new MyContext();

        public List<Session> GetAllSessions()
        {
            try
            {
                List<Session> sessions = SessionContext.Sessions.ToList();
                return sessions;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddSession(Session session)
        {
            try
            {
                SessionContext.Sessions.Add(session);
                SessionContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
