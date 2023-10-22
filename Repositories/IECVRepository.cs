using EstudoCRUDAPI.Models;

namespace EstudoCRUDAPI.Repositories
{
    public interface IECVRepository
    {
        ECV getById(int id);
        List<ECV> getAll();
        void add(ECV ecv);
        void update(int id, ECV ecv);
        void deleteById(int id);
    }
}
