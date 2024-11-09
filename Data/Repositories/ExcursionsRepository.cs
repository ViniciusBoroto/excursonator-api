using ExcursonatorAPI.Data.Contexts;
using ExcursonatorAPI.Models.Entities;

namespace ExcursonatorAPI.Data.Repositories
{
    public class ExcursionsRepository
    {
        public ExcursionsRepository(SqliteContext context)
        {
            
        }
        public Excursion GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
