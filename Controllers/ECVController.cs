using EstudoCRUDAPI.Models;
using EstudoCRUDAPI.Repositories;
using EstudoCRUDAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EstudoCRUDAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ECVController : ControllerBase
    {
        private readonly IECVRepository _ecvService;


        public ECVController(IECVRepository ecvService)
        {
            _ecvService = ecvService;
        }

        [HttpGet("ListarECVs")]
        public IActionResult ListarECVs()
        {
            try
            {
                var ecvs = _ecvService.getAll();
                return Ok(ecvs);
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ECVPorId/{id}")]  
        public IActionResult ECVPorId(int id)
        {
            try
            {
                var ecv = _ecvService.getById(id);
                return Ok(ecv);
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                return BadRequest(ex.Message);
            }

        }

        [HttpPost("CadastrarECV")]
        public IActionResult CadastrarECV([FromBody] ECV ecv)
        {
            try
            {
                _ecvService.add(ecv);
                return Ok();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("ExcluirECV")]
        public IActionResult ExcluirECV(int id)
        {
            try
            {
                _ecvService.deleteById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("AtualizarECV/{id}")]
        public IActionResult AtulizarECV(int id, [FromBody] ECV ecv)
        {
            try
            {
                _ecvService.update(id, ecv);
                return Ok();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                return BadRequest(ex.Message);
            }
        }
    }
}
