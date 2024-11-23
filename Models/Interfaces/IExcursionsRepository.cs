using ExcursonatorAPI.Models.DTOs;
using ExcursonatorAPI.Models.Entities;

namespace ExcursonatorAPI.Models.Interfaces
{
    public interface IExcursionsRepository
    {
        bool Create(ExcursionDTO excursion);
        Excursion? GetById(int id);
        IEnumerable<Excursion> GetAll();
        bool Update(int id, ExcursionDTO excursion);
        bool Delete(int id);
    }
}
