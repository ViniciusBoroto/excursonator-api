using ExcursonatorAPI.Data.Contexts;
using ExcursonatorAPI.Models.DTOs;
using ExcursonatorAPI.Models.Entities;
using ExcursonatorAPI.Models.Interfaces;

namespace ExcursonatorAPI.Data.Repositories
{
    public class ExcursionsRepository : IExcursionsRepository
    {
        public ExcursionsRepository(SqliteContext context)
        {
            
        }

        public bool Create(ExcursionDTO excursion)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Excursion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Excursion? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, ExcursionDTO excursion)
        {
            throw new NotImplementedException();
        }
    }
}
