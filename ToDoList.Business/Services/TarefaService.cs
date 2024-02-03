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

        public async Task<Tarefa> GetTarefaByIdAsync(int id)
        {
            return await _tarefaRepository.GetTarefaByIdAsync(id);
        }

        public async Task<Tarefa> CreateTarefaAsync(Tarefa tarefa)
        {
            return await _tarefaRepository.CreateTarefaAsync(tarefa);
        }


        public async Task<Tarefa> UpdateTarefaAsync(int id, Tarefa tarefaAtualizada)
        {
            return await _tarefaRepository.UpdateTarefaAsync(id, tarefaAtualizada);
        }

        public async Task<bool> DeleteTarefaAsync(int id)
        {
            return await _tarefaRepository.DeleteTarefaAsync(id);
        }
    }
}