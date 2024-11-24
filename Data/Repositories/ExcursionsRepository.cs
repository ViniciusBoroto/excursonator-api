using ExcursonatorAPI.Data.Contexts;
using ExcursonatorAPI.Models.DTOs;
using ExcursonatorAPI.Models.Entities;
using ExcursonatorAPI.Models.Interfaces;

namespace ExcursonatorAPI.Data.Repositories
{
    public class ExcursionsRepository : IExcursionsRepository
    {
        private readonly SqliteContext _context;
        public ExcursionsRepository(SqliteContext context)
        {
            _context = context;
        }

        public bool Create(ExcursionDTO excursion)
        {   
            var newExcursion = new Excursion {Date = excursion.Date, Local = excursion.Local, Name = excursion.Name};
            _context.Excursions.Add(newExcursion);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var excursionToBeDeleted = _context.Excursions.Find(id);
            if (excursionToBeDeleted != null)
            {
                _context.Excursions.Remove(excursionToBeDeleted);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Excursion> GetAll()
        {
            var excursions = _context.Excursions.ToList();
            return excursions;
        }

        public Excursion? GetById(int id)
        {
            return _context.Excursions.Find(id);
        }

        public bool Update(int id, ExcursionDTO excursion)
        {
            var excursionExisting = _context.Excursions.Find(id);
            if (excursionExisting != null)
            {
                excursionExisting.Local = excursion.Local;
                excursionExisting.Name = excursion.Name;
                excursionExisting.Date = excursion.Date;
                excursionExisting.ReturnDate = excursion.ReturnDate;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
