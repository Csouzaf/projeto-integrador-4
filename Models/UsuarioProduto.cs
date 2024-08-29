using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace pi_4.Models;

public class UsuarioProduto
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
                
        [Column("imagem")]
        public string imagem { get; set; }
        
        [Column("nome")]
        public string nome { get; set; }
        
        [Column("preco")]
        public double preco { get; set; }

        [Column("data_criacao")]
        public DateTime dataCriacao { get; set; }

        [JsonIgnore]
        public UsuarioAdm? usuarioAdm { get; set; }
        
        [ForeignKey("UsuarioAdm")]
        [Column("usuario_adm_id")]
        public int usuarioAdmId { get; set; }


        
        public UsuarioProduto()
        {
            dataCriacao = DateTime.Now;
        }

}
