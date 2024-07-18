namespace Fast_food;

public class BurgerDirector
{

public IBuilderBurger _builderBurger;
    public BurgerDirector(IBuilderBurger builderBurger)
    {
        _builderBurger = builderBurger;
    } 

    public void MakeBurguer()
    {
        _builderBurger.BuildBread("Bimbo");
        _builderBurger.BuildCheese("Amarillo");
        _builderBurger.BuildDressing("Classica");
        _builderBurger.BuildLettuce("Italiana");
        _builderBurger.BuildMeat("Pollo");
    }
}