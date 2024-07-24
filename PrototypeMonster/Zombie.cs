public class Zombie : Monster
{
    public Zombie()
    {
        Name = "Zombie";
    }
    public override void Attak()
    {
        Console.WriteLine($"{Name} Attack {Id}");
    }
}