namespace Fast_food;

class Program
{
    static void Main(string[] args)
    {
       IBuilderBurger builderBurgerVeggie = new VeggieBurgerBuilder();
       BurgerDirector burgerDirector = new BurgerDirector(builderBurgerVeggie);

       burgerDirector.MakeBurguer();

       Burger veggie = builderBurgerVeggie.GetBurger();
       veggie.DisplayInfoBurger();

       IBuilderBurger builderBurgerClassic = new ClassicBurgerBuilder();
       BurgerDirector burgerDirector1 = new BurgerDirector(builderBurgerClassic);

       burgerDirector1.MakeBurguer();
       Burger classic = builderBurgerClassic.GetBurger();
       classic.DisplayInfoBurger();



    }
}
