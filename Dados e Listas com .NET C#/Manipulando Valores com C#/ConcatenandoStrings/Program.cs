using Manipulando_Valores_com_C_.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa aluno1 = new Pessoa("Gustavo", 21);
        Pessoa aluno2 = new Pessoa("Gabriel", 32);
        Curso cursoJava = new Curso();

        aluno1.Apresentar();
        cursoJava.AdicionarAluno(aluno1);
        cursoJava.AdicionarAluno(aluno2);
        cursoJava.ListarAlunos();
    }
}