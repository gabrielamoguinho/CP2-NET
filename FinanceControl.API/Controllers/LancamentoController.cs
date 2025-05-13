using FinanceControl.Application.Services;
using FinanceControl.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using FinanceControl.Application.Services;
using FinanceControl.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using FinanceControl.API.Dtos;

namespace FinanceControl.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LancamentoController : ControllerBase
    {
        private readonly LancamentoService _service;

        public LancamentoController(LancamentoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result); // 200
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null) return NotFound(); // 404
            return Ok(result); // 200
        }

        [HttpPost]
        [SwaggerRequestExample(typeof(LancamentoCreateDto), typeof(LancamentoRequestExample))]
        public async Task<IActionResult> Post([FromBody] LancamentoCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var lancamento = new Lancamento
            {
                Titulo = dto.Titulo,
                Valor = dto.Valor,
                Data = dto.Data,
                Tipo = dto.Tipo,
                UsuarioId = dto.UsuarioId
            };

            await _service.AddAsync(lancamento);
            return CreatedAtAction(nameof(GetById), new { id = lancamento.Id }, lancamento);
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] LancamentoUpdateDto dto)
        {
            if (id != dto.Id) return BadRequest();

            var lancamento = new Lancamento
            {
                Id = dto.Id,
                Titulo = dto.Titulo,
                Valor = dto.Valor,
                Data = dto.Data,
                Tipo = dto.Tipo,
                UsuarioId = dto.UsuarioId
            };

            await _service.UpdateAsync(lancamento);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent(); // 204
        }
    }
}
