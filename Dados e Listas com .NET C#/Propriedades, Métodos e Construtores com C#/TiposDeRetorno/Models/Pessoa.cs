using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesNaPratica.Models
{
    public class Pessoa
    {
        
        private string _nome;
        private int _idade;
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

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade 
        { 
            get => _idade;

            set 
            {
                if (value < 0) {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }        
        public string Cpf { get; set; }



        public Pessoa(string nome, string sobrenome, int idade) {
            _idade = idade;
            _nome = nome;
            Sobrenome = sobrenome;
        }



        public void Apresentar() {
            Console.WriteLine($"Nome: {Nome} | Sobrenome: {Sobrenome} | Nome Completo: {NomeCompleto} - Idade: {Idade}");
        }

        public void Apresentar(string nome, int idade) {
            Nome = nome;
            Idade = idade;
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }


    }
}