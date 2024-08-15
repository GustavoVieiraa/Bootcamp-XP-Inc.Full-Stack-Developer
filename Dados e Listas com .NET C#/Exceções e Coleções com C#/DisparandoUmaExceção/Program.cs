string[] linhas = File.ReadAllLines("Arqvos/arquivoLeitura.txt");

foreach (string linha in linhas) {
    Console.WriteLine(linha);
}