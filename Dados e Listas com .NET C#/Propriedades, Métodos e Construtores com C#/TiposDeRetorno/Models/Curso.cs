using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropriedadesNaPratica.Models;

namespace ImplementandoClasseCurso.Models
{
    public class Curso
    {
        
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public Curso() {

        }

        public void AdicionarAluno(Pessoa aluno) {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno) {
            Alunos.Remove(aluno);
            System.Console.WriteLine("Aluno removido.");
        }

        public int ObterQuantidadeDeAlunosMatriculados() {
            return Alunos.Count;
        }


    }
}