using EstudoCRUDAPI.Models;

namespace EstudoCRUDAPI.Repositories
{
    public class ECVRepository : IECVRepository
    {
        private readonly ApplicationDbContext _context;

        public ECVRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void add(ECV ecv)
        {
            _context.Add(ecv);
            _context.SaveChanges();
        }

        public void deleteById(int id)
        {
            var ecv = _context.ECVs.Find(id);

            if (ecv != null)
            {
                _context.ECVs.Remove(ecv);
                _context.SaveChanges();
            }
        }

        public List<ECV> getAll()
        {
            return _context.ECVs.ToList();
        }

        public ECV getById(int id)
        {
            return _context.ECVs.Find(id);
        }

        public void update(ECV ecv)
        {
            var ecvAtual = _context.ECVs.Find(ecv.Id);
            ecvAtual.Nome = ecv.Nome;
            ecvAtual.Status = ecv.Status;
            _context.Update(ecvAtual);
            _context.SaveChanges();

        }
    }
}
