using System;
namespace CShartBasic

{
    class Program
    {
        static void Main (string[] args)  //metoda///
        {
           Messages messages = new Messages();  ///Obiect////
            Console.WriteLine("Hello, World!");  //mesajul///
            messages.PrintMessages();           //metoda///
            string Title = "Amintiri din copilarie";  //Aici le-am declarat
            string Author = "Ion Creanga";
            int AnulAparitiei = 1920;
            double Pret = 45.99;
            bool esteDisponibila = true;
            Console.WriteLine("Title:" + Title);
            Console.WriteLine("Author:" + Author);
            Console.WriteLine("AnulAparitiei: " + AnulAparitiei);
            Console.WriteLine("Pret: " + Pret);
            Console.WriteLine("Disponibila:" + esteDisponibila);
        }

    }

    public class Messages
    {
        public void PrintMessages()  //metoda///
        {
            //int age;
            //age = 25;
            //bool student = false;

            //Console.WriteLine("New Messages:");   //mesajul///
            //Console.WriteLine("Age:" + age);
            //Console.WriteLine("Enter your name:");
            //string name = Console.ReadLine();

            //// IF, Else if, Else//

            //if (student == true)
            //{
            //    student = true;
            //    Console.WriteLine(name + " is a student");
            //}
            //else if (!(student == true))
            //{
            //    Console.WriteLine(name + " is not a student");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            //// While Loops//
            //Console.WriteLine("Enter your age:");
            //age = Convert.ToInt32(Console.ReadLine());
            //while (age < 18)
            //{
            //    Console.WriteLine("Age:" + age + " _" + name + " is not a student");
            //    break;
            //}
            //while (age >= 18)
            //{
            //    Console.WriteLine("Age:" + age + " _" + name + " can be a student");
            //    break;
            //}

            //// For Loop
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("For loop condition number: " + i);
            //}
            //for (int i = 0; i < 5; i--)
            //{
            //    Console.WriteLine("For loop condition number: " + i);
            //}


            //string Title = "Amintiri din copilarie";  //Aici le-am declarat
            //string Author = "Ion Creanga";
            //int AnulAparitiei = 1920;
            //double Pret = 45.99;
            //bool esteDisponibila = true;
            //Console.WriteLine("Title:" + Title);
            //Console.WriteLine("Author:" + Author);
            //Console.WriteLine("AnulAparitiei: " + AnulAparitiei);
            //Console.WriteLine("Pret: " + Pret);
            //Console.WriteLine("Disponibila:" + esteDisponibila);








        }
    }

}


