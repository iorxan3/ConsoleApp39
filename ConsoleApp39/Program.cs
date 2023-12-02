using ConsoleApp.Domain.Models;
Celsi tempCelsi = new Celsi(45);

Kelvin tempKelvin = tempCelsi;

Console.WriteLine(tempKelvin.Derece);