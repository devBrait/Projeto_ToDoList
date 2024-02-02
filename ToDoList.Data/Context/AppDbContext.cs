using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using ToDoList.Core.Models;

namespace ToDoList.API.Context
{
    public class AppDbContext : DbContext
    {
         private readonly IHostEnvironment _env;

        public DbSet<Tarefa> tarefas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options, IHostEnvironment env) : base(options)
        {
            _env = env;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
        }
    }
}