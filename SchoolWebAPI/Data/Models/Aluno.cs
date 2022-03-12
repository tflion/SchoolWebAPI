using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPI.Data
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        
        [Required]
        [MaxLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres.")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(11, ErrorMessage = "O CPF deve possuir 11 dígitos"), MinLength(11, ErrorMessage = "O CPF deve possuir 11 dígitos")]
        public string CPF { get; set; }

        [Required]
        [MaxLength(11, ErrorMessage = "O Telefone deve possuir 11 dígitos para celular 10 para fixo.")]
        public string Telefone { get; set; }

        [Required]

        public DateTime DataNascimento { get; set; }

    }
}
