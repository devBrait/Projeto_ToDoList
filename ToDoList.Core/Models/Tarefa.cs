using System.ComponentModel.DataAnnotations;

namespace ToDoList.Core.Models
{
    public class Tarefa
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "O campo title é obrigatório.")]
        public string title { get; set; }
        [Required(ErrorMessage = "O campo descricao é obrigatório.")]
        public string descricao { get; set; }
        public bool completed { get; set; }
    }
}