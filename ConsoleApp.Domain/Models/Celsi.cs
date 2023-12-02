namespace ConsoleApp.Domain.Models
{
    public class Celsi
    {
        public int Derece { get; set; }
        public Celsi(int selsiDerece)
        {
            Derece = selsiDerece;
        }  
        public static implicit operator Kelvin(Celsi celsi)
        {
            return new Kelvin(celsi.Derece + 273);
        }
    }
}
