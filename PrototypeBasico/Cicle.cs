public class Circle : Shape
{
    public Circle()
    {
        Name = "Circle";
    }
    public override void Draw()
    {
        Console.WriteLine($"Dibujar {Id} Circle");
    }
}