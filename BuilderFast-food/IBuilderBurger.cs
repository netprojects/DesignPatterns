namespace Fast_food;

public interface IBuilderBurger
{
    
    void BuildBread(string bread);

    void BuildCheese(string cheese);
    void BuildLettuce(string lettuce);
    
    void BuildMeat(string meat);
   
    void BuildDressing(string dressing);

    Burger GetBurger();

}