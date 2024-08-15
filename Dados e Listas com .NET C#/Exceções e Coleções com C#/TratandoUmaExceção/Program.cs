
try {

    string[] linhas = File.ReadAllLines("Arqvos/arquivoLeitura.txt"); // forced error

    foreach (string linha in linhas) {

        Console.WriteLine(linha);
    
    }
    
} catch(Exception ex) {

    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");

}
