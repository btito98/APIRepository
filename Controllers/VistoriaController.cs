using EstudoCRUDAPI.DTOs;
using EstudoCRUDAPI.Models;
using EstudoCRUDAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EstudoCRUDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VistoriaController : Controller
    {
        private readonly IVistoriaRepository _vistoriaService;

        public VistoriaController(IVistoriaRepository vistoriaService)
        {
            _vistoriaService = vistoriaService;
        }

        [HttpGet("ListarVistorias")]
        public IActionResult ListarVistorias()
        {
            try
            {
                var vistorias = _vistoriaService.getAll();
                return Ok(vistorias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("VistoriaPorId/{id}")]
        public IActionResult VistoriaPorId(int id)
        {
            try
            {
                var vistoria = _vistoriaService.getById(id);
                return Ok(vistoria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost("CadastrarVistoria")]
        public IActionResult CadastrarVistoria([FromBody] VistoriaRequestDTO vistoriaRequest)
        {
            try
            {
                _vistoriaService.add(vistoriaRequest);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("AtualizarVistoria/{id}")]
        public IActionResult AtualizarVistoria(int id, [FromBody] VistoriaRequestDTO vistoriaRequest)
        {
            try
            {
                _vistoriaService.update(id, vistoriaRequest);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeletarVistoria")]
        public IActionResult DeletarVistoria(int id)
        {
            try
            {
                _vistoriaService.deleteById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
