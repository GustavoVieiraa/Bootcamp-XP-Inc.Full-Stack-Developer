int numero = 16;
bool ehPar = false;

// IF Ternário
ehPar = numero % 2 == 0;

System.Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

// if (numero % 2 == 0) {
//     Console.WriteLine($"O número {numero} é par!");
// }
// else {
//     Console.WriteLine($"O número {numero} é impar");
// }