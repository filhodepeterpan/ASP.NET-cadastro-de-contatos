using System.ComponentModel.DataAnnotations;

namespace CadastroDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é de preenchimento obrigatório.")] 
            public string Nome { get; set; }

        [Required(ErrorMessage = "O email é de preenchimento obrigatório.")]
        [EmailAddress(ErrorMessage = "O email informado é inválido.")]
            public string Email { get; set; }

        [Required(ErrorMessage = "O celular é de preenchimento obrigatório.")]
        [Phone(ErrorMessage = "O celular informado é inválido.")]
            public string Celular { get; set; }
    }
}
