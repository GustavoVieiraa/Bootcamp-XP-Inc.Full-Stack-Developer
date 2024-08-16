// (int, string, string, decimal) tuplaExemplo = (1, "Gustavo", "Vieira", 1.76M);

// Console.WriteLine("ID: " + tuplaExemplo.Item1);
// Console.WriteLine("Nome: " + tuplaExemplo.Item2);
// Console.WriteLine("Sobrenome: " + tuplaExemplo.Item3);
// Console.WriteLine("Altura: " + tuplaExemplo.Item4);

using TuplasNaPrática.Models;

LeituraArquivo arquivo = new LeituraArquivo();


// Conceito de Descartes em Tuplas.
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/testeDeLeitura.txt");

if (sucesso) {
    //Console.WriteLine("Qnt de linhas: " + quantidadeLinhas);
    foreach (string linha in linhasArquivo) {
        Console.WriteLine(linha);
    }
} else {
    Console.WriteLine("Não foi possível ler o arquivo.");
}