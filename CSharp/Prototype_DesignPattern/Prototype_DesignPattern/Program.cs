// Prototype Interface

using System.Security.Cryptography.X509Certificates;

interface IProtoType
{
    IProtoType Clone();

}

class Automobile : IProtoType
{
    public string Model { get; set; }
    public string Color { get; set; }    

    public int DoorsNumbers { get; set; }

    public Automobile(string model, string Color, int doorsNumbers)
    {
        Model = model;
        this.Color = Color;
        DoorsNumbers = doorsNumbers;
    }
         // Implememt Clone Method

        public IProtoType Clone()
        {
        return (IProtoType)MemberwiseClone();
        }

    class ProjecAutomobile
    {
        static void Main (string[] args)
        {
            Automobile prototype = new Automobile("Model x", "Black", 5);
            Automobile automobile1 = (Automobile)prototype.Clone();
            automobile1.Model = "Y";
            Automobile automobile2 = (Automobile)prototype.Clone();
            automobile2.Color = "White";
            Automobile automobile3 = (Automobile)prototype.Clone();
            automobile3.DoorsNumbers = 4;
            Console.WriteLine("Prototype: " + prototype.Model + ", " + prototype.Color + ", " + prototype.DoorsNumbers);
            Console.WriteLine("Automobile 1: " + automobile1.Model +", " + automobile1.Color + ", " + automobile1.DoorsNumbers);
            Console.WriteLine("Automobile 2: " + automobile2.Model +", " + automobile2.Color + ", " + automobile2.DoorsNumbers);
            Console.WriteLine("Automobile 3: " + automobile3.Model +", " + automobile3.Color + ", " + automobile3.DoorsNumbers);



        }
    }
}




