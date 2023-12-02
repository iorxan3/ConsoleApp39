using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp.Domain.Models
{
    public class Kelvin
    {
        public int Derece { get; set; }
        public Kelvin(int kelvinDerece)
        {
            Derece = kelvinDerece;
        }
       
    }
}
