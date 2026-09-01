using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace tablaInmultirii
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Scrie tabla inmultirii");
            
            int numar = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " este par");

                }
                else
                {
                    Console.WriteLine(i + " este impar");
                }
            }

                

        }






    }

}