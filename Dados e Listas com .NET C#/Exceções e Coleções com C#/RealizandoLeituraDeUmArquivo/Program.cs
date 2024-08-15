string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach (string linha in linhas) {
    Console.WriteLine(linha);
}