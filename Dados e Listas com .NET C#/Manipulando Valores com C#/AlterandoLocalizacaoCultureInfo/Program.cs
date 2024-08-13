using Manipulando_Valores_com_C_.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 1782.40M;

Console.WriteLine($"{valorMonetario:C}");