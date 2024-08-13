using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manipulando_Valores_com_C_.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos = new List<Pessoa>();

        public void AdicionarAluno(Pessoa aluno) {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno) {
            Alunos.Remove(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados() {
            return Alunos.Count();
        }

        public void ListarAlunos() {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            for (int i = 0; i < Alunos.Count(); i++ ) {
                Console.WriteLine($"{i + 1}º: {Alunos[i].Apresentar()}");
            } 
        }

    }
}