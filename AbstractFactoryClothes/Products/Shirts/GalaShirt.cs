public class GalaShirt : IShirt
{
    public string DesignShirt()
    {
        Console.WriteLine("Gala");
        return "Gala";
    }

    public string SizeShirt()
    {
        return "Gala";
    }

    public string TypeClothes()
    {
        return "Shirt";
    }
}