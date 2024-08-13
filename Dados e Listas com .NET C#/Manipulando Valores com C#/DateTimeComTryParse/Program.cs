using System.Globalization;

string dataString = "13-08-2025 15:00";

DateTime.TryParseExact(dataString, 
"dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

Console.WriteLine(date);
Console.WriteLine(date.ToString("dd/MM/yyyy"));
Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm"));

Console.WriteLine(date.ToString("MM/dd/yyyy"));