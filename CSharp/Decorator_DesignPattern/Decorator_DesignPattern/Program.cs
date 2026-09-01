using System.Reflection.Metadata.Ecma335;

public  interface Pizza
{
    string MakePizza();
}
public class PlainPizza : Pizza //interface //
{
    public string MakePizza()  //method//
    {
        return "Plain Pizza";
    }
}
public abstract class PizzaDecorator : Pizza  //interface//
{
    protected Pizza pizza; //poate fi folosit doar in interiorul clasei//

    public PizzaDecorator(Pizza pizza) // method cu parametru Pizza pizza//
    {
        this.pizza = pizza;
    }
    public virtual string MakePizza() //implementare  method virtual MakePizza//
    {
        return pizza.MakePizza();
    }
}
    public class ChickenPizzaDecorator : PizzaDecorator // method mosteneste class abstract PizzaDecorator//
    {
        public ChickenPizzaDecorator(Pizza pizza) : base(pizza) { }
        public override string MakePizza()
        {
            return pizza.MakePizza() + AddChicken();
        }
        private string AddChicken()
        {
            return "Chicken added";
        }
    }


    public class VegPizzaDecorator : PizzaDecorator
    {
        public VegPizzaDecorator(Pizza pizza) : base(pizza) { }
       
        
        public override string MakePizza()
        {
            return pizza.MakePizza() + AddVegetables();
        }
        private string AddVegetables()
        {
            return "Vegetables added";
        }
    }


class Program
{ 

    static void Main()
    {
        PlainPizza pizzaObj = new PlainPizza();
        string plainPizza = pizzaObj.MakePizza();
        Console.WriteLine(plainPizza);
        PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(pizzaObj);
        string chickenPizza = chickenPizzaDecorator.MakePizza();
        Console.WriteLine("\n" + chickenPizza + " using ChickenPizzaDecorator");
        PizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(pizzaObj);
        string vegPizza = vegPizzaDecorator.MakePizza();
        Console.WriteLine("\n" + vegPizza + "using VegPizzaDecorator");

    }
}

