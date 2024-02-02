using ToDoList.Core.Interfaces;
using ToDoList.Core.Models;

namespace ToDoList.Business.Services
{
    public class TarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaService(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<List<Tarefa>> GetTarefasAsync()
        {   
                return await _tarefaRepository.GetTarefasAsync();
        }
    }
}