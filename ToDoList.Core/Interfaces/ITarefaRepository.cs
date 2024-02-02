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
    }
}