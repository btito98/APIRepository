using EstudoCRUDAPI.Models;

namespace EstudoCRUDAPI.Repositories
{
    public class VistoriaRepository : IVistoriaRepository
    {
        private readonly ApplicationDbContext _context;

        public VistoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void add(Vistoria vistoria)
        {
            throw new NotImplementedException();
        }

        public void deleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Vistoria> getAll()
        {
            throw new NotImplementedException();
        }

        public Vistoria getById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Vistoria vistoria)
        {
            throw new NotImplementedException();
        }
    }
}
