using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Core.Models;

namespace ToDoList.Core.Interfaces
{
    public interface ITarefaRepository
    {
        Task<List<Tarefa>> GetTarefasAsync();
        Task<Tarefa> GetTarefaByIdAsync(int id);
        Task<Tarefa> CreateTarefaAsync(Tarefa tarefa);
        Task<Tarefa> UpdateTarefaAsync(int id, Tarefa tarefaAtualizada);
        Task<bool> DeleteTarefaAsync(int id);
    }
}