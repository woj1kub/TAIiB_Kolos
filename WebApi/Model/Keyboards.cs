namespace WebApi.Model
{ 
    public enum KeyboardType
    {
        membranowa,
        nozycowa,
        mechaniczna,
        optyczna,
        hybrydowa
    }

    public class Keyboards
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public KeyboardType Rodzaj { get; set; }
    }
}
