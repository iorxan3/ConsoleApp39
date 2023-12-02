using ConsoleApp.Domain.Models;
Celsi tempCelsi = new Celsi(int.Parse(Console.ReadLine()));;

Kelvin tempKelvin = tempCelsi;

Console.WriteLine(tempKelvin.Derece);
