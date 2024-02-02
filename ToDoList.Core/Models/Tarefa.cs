namespace ToDoList.Core.Models
{
    public class Tarefa
    {
        public int id { get; set; }
        public string title { get; set; }
        public string descricao { get; set; }
        public bool completed { get; set; }
    }
}