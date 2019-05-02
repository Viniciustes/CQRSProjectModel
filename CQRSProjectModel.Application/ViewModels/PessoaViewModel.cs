using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CQRSProjectModel.Application.ViewModels
{
    public class PessoaViewModel : EntityViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O CPF é obrigatório")]
        [MinLength(11)]
        [MaxLength(11)]
        public string CPF { get; set; }

        [DisplayName("Data de nascimento")]
        public DateTime Nascimento { get; set; }

        public int Genero { get; set; }

        [MinLength(3)]
        [MaxLength(30)]
        public string Telefone { get; set; }
    }
}
