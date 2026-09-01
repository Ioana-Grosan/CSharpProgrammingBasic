Console.WriteLine("Introdu primul numar");
double numar1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Introdu al doilea numar");
double numar2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ce operatie doresti sa faci? (+,-,*,/)");
string operatie =  Console.ReadLine();
double rezultat = 0;
if (operatie == "*")
{
    rezultat = numar1 * numar2;
    Console.WriteLine("Reultatul este: " + rezultat);
}
else if (operatie == "/")
{
    rezultat = numar1 / numar2;
    Console.WriteLine("Reultatul este: " + rezultat);
}
else if (operatie == "+")
{
    rezultat = (numar1 + numar2);
    Console.WriteLine("Reultatul este: " + rezultat);
}
else if (operatie == "-")
{
    rezultat = (numar1 - numar2);
    Console.WriteLine("Reultatul este: " + rezultat);
}





