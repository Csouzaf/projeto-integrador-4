using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pi_4.Models
{
    [Table("usuario")]
    public class Usuario
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
        
        [Column("cpf")] 
        public string cpf { get; set; }
        
        [Column("cnpj")] 
        public string cnpj { get; set; }

        [Column("data_criacao")]
        public DateTime dataCriacao { get; set; }
        
        public Usuario()
        {
            id = Guid.NewGuid();
            dataCriacao = DateTime.Now;
        }
}
    }

  