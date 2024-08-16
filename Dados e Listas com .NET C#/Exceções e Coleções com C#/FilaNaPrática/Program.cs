using UsandoThrow.Models;

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(7);
fila.Enqueue(10);

foreach(int i in fila) {
    Console.WriteLine(i);
}

Console.WriteLine($"Removendo o elemento: " + fila.Dequeue()); ;

foreach (int i in fila) {
    Console.WriteLine(i);
}