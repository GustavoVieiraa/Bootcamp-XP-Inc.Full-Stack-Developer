using UsandoThrow.Models;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
estados.Add("RJ", "Rio de Janeiro");

foreach(var estado in estados) {
    Console.WriteLine($"Chave {estado.Key} | Valor: {estado.Value}");
}

estados.Remove("MG");
estados["SP"] = "São Paulo - Valor Diferenciado";

Console.WriteLine("=-=-=-=-=-=-=-=-=");

foreach(var estado in estados) {
    Console.WriteLine($"Chave {estado.Key} | Valor: {estado.Value}");
}