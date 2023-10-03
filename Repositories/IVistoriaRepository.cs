using EstudoCRUDAPI.Models;

namespace EstudoCRUDAPI.Repositories
{
    public interface IVistoriaRepository
    {
        Vistoria getById(int id);
        List<Vistoria> getAll();
        void add(Vistoria vistoria);
        void update(Vistoria vistoria);
        void deleteById(int id);
        
    }
}
