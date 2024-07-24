public class GalaClothesFactory : IClothesFactory
{
    public IShirt CreateShirt()
    {
        return new GalaShirt();
    }

    public IShoe CreateShoe()
    {
        return new GalaShoe();
    }

    public ITrouser CreateTrouser()
    {
        return new GalaTrouser();
    }
}