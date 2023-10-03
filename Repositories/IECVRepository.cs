using EstudoCRUDAPI.Models;

namespace EstudoCRUDAPI.Repositories
{
    public interface IECVRepository
    {
        ECV getById(int id);
        List<ECV> getAll();
        void add(ECV ecv);
        void update(ECV ecv);
        void deleteById(int id);
    }
}
