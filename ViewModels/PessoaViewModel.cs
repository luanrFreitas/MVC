using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PessoaViewModel
    {
        [Key]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O campo CPF não pode ficar vazio")]
        [MaxLength(11)]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O campo Nome não pode ficar vazio")]
        [MaxLength(20)]
        public string Nome { get; set; }
        [MaxLength(20)]
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }
        [DataType(DataType.MultilineText)]
        public string Texto { get; set; }
        public bool Ativo { get; set; }


    }
}