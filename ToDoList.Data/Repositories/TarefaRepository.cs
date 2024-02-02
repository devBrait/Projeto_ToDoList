using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoList.API.Context;
using ToDoList.Core.Interfaces;
using ToDoList.Core.Models;

namespace ToDoList.Data.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        // Variáveis 
        private readonly AppDbContext _appDbContext;

        // Construtor
        public TarefaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Tarefa>> GetTarefasAsync()
        {
            var lstTarefas = await _appDbContext.tarefas.ToListAsync();
            return lstTarefas;
        }
    }
}