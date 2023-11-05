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
    }
}
