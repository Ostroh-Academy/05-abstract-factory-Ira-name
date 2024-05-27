using System;
public abstract class Food
{
    public string Name { get; protected set; }

    public Food(string name)
    {
        Name = name;
    }
}

public class Pizza : Food
{
    public Pizza(string name) : base(name) { }
}

public class Burger : Food
{
    public Burger(string name) : base(name) { }
}

public class Salad : Food
{
    public Salad(string name) : base(name) { }
}

public interface IFoodFactory
{
    Pizza GetPizza();
    Burger GetBurger();
    Salad GetSalad();
}

public class ItalianFoodFactory : IFoodFactory
{
    public Pizza GetPizza()
    {
        return new Pizza("Margherita Pizza");
    }

    public Burger GetBurger()
    {
        return new Burger("Italian Burger");
    }

    public Salad GetSalad()
    {
        return new Salad("Caprese Salad");
    }
}

public class AmericanFoodFactory : IFoodFactory
{
    public Pizza GetPizza()
    {
        return new Pizza("Pepperoni Pizza");
    }

    public Burger GetBurger()
    {
        return new Burger("Cheeseburger");
    }

    public Salad GetSalad()
    {
        return new Salad("Caesar Salad");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFoodFactory italianFoodFactory = new ItalianFoodFactory();
        Pizza pizza = italianFoodFactory.GetPizza();
        Burger burger = italianFoodFactory.GetBurger();
        Salad salad = italianFoodFactory.GetSalad();
        Console.WriteLine("I've got {0}, {1}, and {2}", pizza.Name, burger.Name, salad.Name);

        IFoodFactory americanFoodFactory = new AmericanFoodFactory();
        pizza = americanFoodFactory.GetPizza();
        burger = americanFoodFactory.GetBurger();
        salad = americanFoodFactory.GetSalad();
        Console.WriteLine("I've got {0}, {1}, and {2}", pizza.Name, burger.Name, salad.Name);

        Console.ReadLine();
    }
}
