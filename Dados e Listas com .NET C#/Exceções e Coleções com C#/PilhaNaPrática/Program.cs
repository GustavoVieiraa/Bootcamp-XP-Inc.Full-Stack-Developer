using UsandoThrow.Models;

// Pilhas utiliza o padrão LIFO (First In, Last Out)

Stack<int> pilha = new Stack<int>();

pilha.Push(5);
pilha.Push(12);
pilha.Push(7);
pilha.Push(10);

foreach (int i in pilha) {
    Console.WriteLine(i);
}

Console.WriteLine("Removendo o elemento: " + pilha.Pop());

foreach (int i in pilha) {
    Console.WriteLine(i);
}