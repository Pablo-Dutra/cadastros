using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiCadastro.Model
{
    [Table("pessoas")]
    public class Pessoa
    {
        [Key]
        public int id { get; private set; }
        public string nome { get; private set; }
        public int codigo { get; private set; }
        public string email { get; private set; }
        public string? foto { get; private set; }

        public Pessoa(string nome, int codigo, string email, string foto)
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.codigo = codigo;
            this.email = email; 
            this.foto = foto;
        }

    }
}
