using System.Reflection.Metadata.Ecma335;

public class SportClothesFactory : IClothesFactory
{
    public IShirt CreateShirt()
    {
        return new SportShirt();
    }

    public IShoe CreateShoe()
    {
        return new SportShoe();
    }

    public ITrouser CreateTrouser()
    {
        return new SportTrouser();
    }
}