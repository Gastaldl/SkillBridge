using System.ComponentModel.DataAnnotations;

namespace SkillBridge.Domain
{
    public class Matricula
    {
        public long Id { get; set; }

        [Required]
        public long UsuarioId { get; set; }

        [Required]
        public long TrilhaId { get; set; }

        public DateTime DataInscricao { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Trilha Trilha { get; set; }
    }
}