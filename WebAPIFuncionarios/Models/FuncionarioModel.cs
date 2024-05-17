using System.ComponentModel.DataAnnotations;
using WebAPIFuncionarios.Enums;

namespace WebAPIFuncionarios.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public bool Ativo { get; set; }
        public TurnoEnum Turno { get; set; }
        public DateTime DateDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DateDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();
    }
}
