public class Square : Shape
{
    public Square()
    {
        Name = "Square";
    }
    public override void Draw()
    {
        Console.WriteLine($"Dibujar {Id} Square");
    }
}