using System;

namespace inläming_2_Svante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\tVälkommen!\n\nVar god skriv in den hemliga koden");
            Console.Write(">");
            string password = Console.ReadLine();
            password.ToUpper();

            if (password == "COFFE N CODE")
            {
                Console.WriteLine("Du är värdig");
            }
            else //hoppar måsvingar för jag är ett proffs!
                Console.WriteLine("Du är inte värdig");
        }
    }
}
