using EstudoCRUDAPI.DTOs;
using EstudoCRUDAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace EstudoCRUDAPI.Repositories
{
    public class VistoriaRepository : IVistoriaRepository
    {
        private readonly ApplicationDbContext _context;

        public VistoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void add(VistoriaRequestDTO vistoriaRequest)
        {
            try
            {
                var ecv = _context.ECVs.Find(vistoriaRequest.ECVId);
                if (ecv == null)
                {
                    throw new Exception("ECV não encontrada!");
                }

                var novaVistoria = new Vistoria
                {
                    OS = vistoriaRequest.Vistoria.OS,
                    nomeVistoriador = vistoriaRequest.Vistoria.nomeVistoriador,
                    statusVistoria = vistoriaRequest.Vistoria.statusVistoria,
                    ECVId = vistoriaRequest.ECVId,
                    ECV = ecv
                };

                _context.Add(novaVistoria);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw new Exception(ex.Message);
            }
        }

        public void deleteById(int id)
        {
            var vistoria = _context.Vistorias.Find(id);

            if (vistoria != null)
            {
                _context.Remove(vistoria);
                _context.SaveChanges();
            }

        }

        public List<Vistoria> getAll()
        {
            return _context.Vistorias.Include(v => v.ECV).ToList();
        }

        public Vistoria getById(int id)
        {
            return _context.Vistorias.Find(id);    
        }

        public void update(int id, VistoriaRequestDTO vistoriaRequest)
        {
            try
            {
                var vistoriaAtual = _context.Vistorias.FirstOrDefault(v => v.Id == id);

                if (vistoriaAtual == null)
                    throw new Exception("Vistoria não encontrada!");

                vistoriaAtual.OS = vistoriaRequest.Vistoria.OS;
                vistoriaAtual.nomeVistoriador = vistoriaRequest.Vistoria.nomeVistoriador;
                vistoriaAtual.statusVistoria = vistoriaRequest.Vistoria.statusVistoria;

                _context.Update(vistoriaAtual);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw new Exception(ex.Message);
            }
        }
    }
}
