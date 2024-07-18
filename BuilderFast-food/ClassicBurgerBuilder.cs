namespace Fast_food;

public class ClassicBurgerBuilder: IBuilderBurger
{
    private Burger _burger = new Burger();

    public void BuildBread(string bread)
    {
        _burger.Bread = bread;
    }

    public void BuildCheese(string cheese)
    {
        _burger.Cheese = cheese;
    }

    public void BuildDressing(string dressing)
    {
        _burger.Dressing = dressing;
    }

    public void BuildLettuce(string lettuce)
    {
        _burger.Lettuce = lettuce;
    }

    public void BuildMeat(string meat)
    {
        _burger.Meat = meat;
    }

    public Burger GetBurger()
    {
        return _burger;
    }
}