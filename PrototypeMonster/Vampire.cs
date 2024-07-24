public class Vampire : Monster
{
    public Vampire()
    {
        Name = "Vampire";
    }
    public override void Attak()
    {
        Console.WriteLine($"Vampire Attack {Id}");
    }
}