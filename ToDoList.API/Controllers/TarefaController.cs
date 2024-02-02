using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoList.Business.Services;

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

                if (lstTarefas == null)
                {
                    return NotFound();
                }

                return Ok(lstTarefas);
            }catch(Exception ex){
                return StatusCode(500, ex.Message);
            }
        }
    }
}