using System;
using System.Collections.Generic;

namespace OrcamentoDomestico
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("******* BEM-VINDO AO ORÇAMENTO DOMÉSTICO *******");
            Console.WriteLine("Abaixo entre com os dados individuais de cada membro familiar: ");
            Console.WriteLine("************************************************");

            for (i = 0; i < 3; i++)
            {
                Console.Write($"Nome: ");
                string nome = Console.ReadLine();
                Console.Write($"Parentesco: ");
                string parentesco = Console.ReadLine();
                Console.Write($"Salario: ");
                double salario = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Gasto pessoal: ");
                double gastoPessoal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("************************************************");

                Pessoa membroFamiliar = new Pessoa(nome, parentesco, salario, gastoPessoal);
            }
        }
    }
}
