﻿using EstudoCRUDAPI.Models;
using EstudoCRUDAPI.Repositories;

namespace EstudoCRUDAPI.Services
{
    public class VistoriaService
    {
        private readonly VistoriaRepository _vistoriaRepository;

        public VistoriaService(VistoriaRepository vistoriaRepository)
        {
            _vistoriaRepository = vistoriaRepository;
        }

        public List<Vistoria> ListarVistorias()
        {
            return _vistoriaRepository.getAll();
        }

        public Vistoria FiltrarPorId(int id)
        {
            return _vistoriaRepository.getById(id);
        }

        public void AdicionarVistoria(Vistoria vistoria)
        {
            _vistoriaRepository.add(vistoria);
        }

        public void DeletarVistoria (int id)
        {
            _vistoriaRepository.deleteById(id);
        }

        public void AtualizarVistoria(Vistoria vistoria)
        {
            _vistoriaRepository.update(vistoria);
        }
    }
}
