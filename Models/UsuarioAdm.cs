using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pi_4.Models
{
    [Table("usuario_adm")]
    public class UsuarioAdm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }

        [Column("primeiro_nome")]
        public string primeiroNome { get; set; }

        [Column("segundo_nome")]
        public string segundoNome { get; set; }

        [Column("email")]
        [Required]
        public string email { get; set; }

        [Column("senha")]
        [Required]
        public string senha { get; set; }

        [Column("endereco")]
        public string endereco { get; set; }

        [Column("cep")]
        public string cep { get; set; }

        [Column("cnpj")]
        public string cnpj { get; set; }

        [Column("data_criacao")]
        public DateTime dataCriacao { get; set; }

        [Column("adm_usuario")]
        public bool admOuUsuario { get; set; }

        public UsuarioAdm()
        {
            id = Guid.NewGuid();
            dataCriacao = DateTime.Now;
        }
        
    }
}

