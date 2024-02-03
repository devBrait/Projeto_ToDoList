using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
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

        // Retorna todas as tarefas
        public async Task<List<Tarefa>> GetTarefasAsync()
        {
            var lstTarefas = await _appDbContext.tarefas.ToListAsync();
            return lstTarefas;
        }

        // Retorna tarefa pelo Id
        public async Task<Tarefa> GetTarefaByIdAsync(int id)
        {
            var tarefa = await _appDbContext.tarefas.FindAsync(id);
            return tarefa;
        }

        // Adiciona nova tarefa
        public async Task<Tarefa> CreateTarefaAsync(Tarefa tarefa)
        {
            var tarefaCriada = _appDbContext.tarefas.Add(tarefa);

            await _appDbContext.SaveChangesAsync();

            return tarefaCriada.Entity;
        }

        // Atualiza uma tarefa pelo Id
        public async Task<Tarefa> UpdateTarefaAsync(int id, Tarefa tarefaAtualizada)
        {
            var tarefa = await _appDbContext.tarefas.FindAsync(id);

            if (tarefa == null)
            {
                return null;
            }
            // Atualiza os campos
            tarefa.title = tarefaAtualizada.title;
            tarefa.descricao = tarefaAtualizada.descricao;
            tarefa.completed = tarefaAtualizada.completed;
            await _appDbContext.SaveChangesAsync();

            return tarefa;
        }

        // Deleta uma tarefa pelo Id
        public async Task<bool> DeleteTarefaAsync(int id)
        {
            var tarefa = await _appDbContext.tarefas.FindAsync(id);

            if (tarefa == null)
            {
                return false; // Caso a tarefa não seja encontrada
            }

            _appDbContext.tarefas.Remove(tarefa);
            await _appDbContext.SaveChangesAsync();

            return true;
        }
    }
}