using EstudoCRUDAPI.Models;
using EstudoCRUDAPI.Repositories;

namespace EstudoCRUDAPI.Services
{
    public class ECVService
    {
        private readonly ECVRepository _ecvRepository;

        public ECVService(ECVRepository ecvRepository)
        {
            _ecvRepository = ecvRepository;
        }

        public List<ECV> listarEcvs()
        {
            return _ecvRepository.getAll();
        }

        public ECV filtrarPorId(int id)
        {
            return _ecvRepository.getById(id);
        }

        public void AdicionarECV(ECV ecv)
        {
            _ecvRepository.add(ecv);            
        }

        public void AtualizarECV(int id, ECV ecv)
        {
            _ecvRepository.update(id, ecv);
        }

        public void DeletarECV(int id)
        {
            _ecvRepository.deleteById(id);
        }
    }
}
