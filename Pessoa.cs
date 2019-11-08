using System;
using System.Collections.Generic;
using System.Text;

namespace OrcamentoDomestico
{
    class Pessoa
    {
        public Pessoa(string nome, string parentesco, double salario, double gastoPessoal)
        {
            Nome = nome;
            Parentesco = parentesco;
            Salario = salario;
            GastoPessoal = gastoPessoal; 
        }

        public string Nome { get; set; }

        public string Parentesco { get; set; }

        public double Salario { get; set; }

        public double GastoPessoal { get; set; }
    }
}
