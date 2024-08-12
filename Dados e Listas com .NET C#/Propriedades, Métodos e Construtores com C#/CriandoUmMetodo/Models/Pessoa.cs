using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesNaPratica.Models
{
    public class Pessoa
    {
        
        public string Nome { get; set; }
        public int Idade { get; set; }        
        public string Cpf { get; set; }


        public void Apresentar() {
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade}");
        }

        public void Apresentar(string nome, int idade) {
            Nome = nome;
            Idade = idade;
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }


    }
}