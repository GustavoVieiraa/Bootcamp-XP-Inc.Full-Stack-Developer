
try {

    string[] linhas = File.ReadAllLines("Aruivos/arquivoLeitura.txt"); // forced error

    foreach (string linha in linhas) {

        Console.WriteLine(linha);
    
    }
    
} catch(FileNotFoundException ex) {

    Console.WriteLine($"[Arquivo não encontrado] Ocorreu um erro na leitura do arquivo. {ex.Message}");

}
catch(DirectoryNotFoundException ex) {

    Console.WriteLine($"[Diretorio não encontrado] Ocorreu um erro na leitura do diretorio. {ex.Message}");

}
catch(Exception ex) {

    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");

}