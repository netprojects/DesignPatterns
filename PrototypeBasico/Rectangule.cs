public class Rectangule : Shape
{
    public Rectangule()
    {
        Name = "Rectangule";
    }
    public override void Draw()
    {
        Console.WriteLine($"Dibujar {Id} Rectangule");
    }
}