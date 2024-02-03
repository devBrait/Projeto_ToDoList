using Microsoft.AspNetCore.Mvc;
using ToDoList.Business.Services;
using ToDoList.Core.Models;

namespace ToDoList.API.Controllers
{
    [Route("[controller]")]
    public class TarefaController : Controller
    {
        private readonly TarefaService _tarefaService;

        public TarefaController(TarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpGet("tasks")]
        public async Task<IActionResult> GetTarefasAsync()
        {   
            try{
                var lstTarefas = await _tarefaService.GetTarefasAsync();

                if (lstTarefas == null || !lstTarefas.Any())
                {
                    return NotFound("Nenhuma tarefa cadastrada!");
                }

                return Ok(lstTarefas);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("tasks/{id}")]
        public async Task<IActionResult> GetTarefaByIdAsync(int id)
        {
            try
            {
                var tarefa = await _tarefaService.GetTarefaByIdAsync(id);

                if (tarefa == null)
                {
                    return NotFound($"Tarefa com ID {id} não encontrada ou não existe!");
                }

                return Ok(tarefa);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPost("tasks")]
        public async Task<IActionResult> CreateTarefaAsync([FromBody]Tarefa novaTarefa)
        {
            try
            {
                // Validar o modelo no json com o Model
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                // Garantir que o Id não seja especificado no JSON
                if (novaTarefa.id != 0)
                {
                    ModelState.AddModelError("Id", "O campo Id não pode ser especificado no JSON.");
                    return BadRequest(ModelState);
                }
                var tarefa = await _tarefaService.CreateTarefaAsync(novaTarefa);
                return Ok(tarefa);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("tasks/{id}")]
        public async Task<IActionResult> UpdateTarefaAsync(int id, [FromBody]Tarefa tarefaAtualizada)
        {
            try
            {

                // Validar o modelo no json com o Model
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var tarefa = await _tarefaService.UpdateTarefaAsync(id, tarefaAtualizada);

                if (tarefa == null)
                {
                    return NotFound($"Tarefa com ID {id} não encontrada ou não existe!");
                }

                return Ok(tarefa);
            }
            catch (Exception ex)
            {
                // Retorna um status de erro interno do servidor em caso de exceção
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete("tasks/{id}")]
        public async Task<IActionResult> DeleteTarefaAsync(int id)
        {
            try
            {
                var tarefa = await _tarefaService.DeleteTarefaAsync(id);

                if (!tarefa)
                {
                    return NotFound($"Tarefa com ID {id} não encontrada ou não existe!");
                }

                return Ok($"Tarefa com ID {id} excluída com sucesso!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}