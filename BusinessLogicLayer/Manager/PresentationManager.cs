using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BusinessLogicLayer.Manager
{
    public class PresentationManager
    {
        MyContext PresentationContext = new MyContext();
        public void AddPresentation(Presentation presentation)
        {
            try
            {
                PresentationContext.Presentations.Add(presentation);
                PresentationContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Presentation> GetAllPresentations()
        {
            try
            {
                List<Presentation> presentations = PresentationContext.Presentations.ToList();
                return presentations;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Presentation> GetEnablePresentation()
        {
            try
            {
                return PresentationContext.Presentations.Where(x => x.IsPresentation == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DoEnableFalse(int _id)
        {
            var query = PresentationContext.Presentations.FirstOrDefault(x => x.Id == _id);
            query.IsPresentation = false;
            PresentationContext.SaveChanges();
        }
        public void DoEnableTrue(int _id)
        {
            var query = PresentationContext.Presentations.FirstOrDefault(x => x.Id == _id);
            query.IsPresentation = true;
            PresentationContext.SaveChanges();
        }
    }
}
