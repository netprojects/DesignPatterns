public class Mummy : Monster
{
    public Mummy()
    {
        Name = "Mummy";
    }
    public override void Attak()
    {
        Console.WriteLine($"{Name} Attack {Id}");
    }
}