using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogoJogosJv.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMenssage = "O nome do jogo deve conter entre 3 e 100 caracteres")]

        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMenssage = "O nome da produtora deve conter entre 3 e 100 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 3, ErrorMenssage = "O preco do jogo deve ser de no minimo 1 real e maximo de 1000 reais")]
        public double Preco { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMenssage = "O nome do autor deve conter entre 3 e 100 caracteres")]
        public string Autor { get; set; }
        [Required]
        [StringLength(10, MinimumLength: = 3, ErrorMenssage = "A avaliação do jogo deve ser de 1 a 10")]
        public string Avaliacao { get; set; }
    }

    internal class StringLengthAttribute : Attribute
    {
        public StringLengthAttribute(int v, int MinimumLength, string ErrorMenssage)
        {
        }
    }

    internal class RequiredAttribute : Attribute
    {
    }
}
