using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesNaPratica.Models
{
    public class Pessoa
    {
        
        private string _nome;
        public string Nome 
        { 
            get => _nome.ToUpper();

            set
            {
                if (value == "") {
                    throw new ArgumentException("O nome não pode ser vazio");
                } 
                _nome = value;
            } 
        }
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