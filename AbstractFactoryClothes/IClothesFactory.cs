using System.Collections;

public interface IClothesFactory
{
    public IShoe CreateShoe();
    public IShirt CreateShirt();
    public ITrouser  CreateTrouser(); 
}