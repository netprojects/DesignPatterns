namespace Fast_food;

public class Burger
{
    public string Bread{get;set;}
    public string Cheese{get;set;}
    public string Lettuce{get;set;}
    public string Meat{get;set;}
    public string Dressing{get;set;}

    public string Tomato{get;set;}

    public void DisplayInfoBurger()
    {
        Console.WriteLine($"Bread {Bread}");
        Console.WriteLine($"Cheese {Cheese}");
        Console.WriteLine($"Lettuce {Lettuce}");
        Console.WriteLine($"Meat {Meat}");
        Console.WriteLine($"Dressing {Dressing}");
        Console.WriteLine($"Tomato {Tomato}");
    }
}