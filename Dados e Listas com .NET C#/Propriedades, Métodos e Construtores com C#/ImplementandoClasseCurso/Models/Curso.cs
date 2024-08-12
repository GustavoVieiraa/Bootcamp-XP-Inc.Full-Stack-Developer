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

        public void AdicionarAluno(Pessoa aluno) {
            Alunos.Add(aluno);
            System.Console.WriteLine("Aluno adicionado.");
        }


    }
}