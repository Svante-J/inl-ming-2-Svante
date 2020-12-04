using System;
using System.Collections.Generic;

namespace inläming_2_Svante
{
    class MemberInBaseGroup
    {
        private List<string>GroupMember{ get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("\n\t\t\tVälkommen!\n\nVar god skriv in den hemliga koden");
                Console.Write(">");
               
                string strPassword = Console.ReadLine();
                string password = strPassword.ToUpper();
                Console.WriteLine(password);
                if (password == "COFFE N CODE")
                    Console.WriteLine("Du är värdig\n");
                else //hoppar måsvingar för jag är ett proffs!
                    Console.WriteLine("Du är inte värdig\n");

                Console.WriteLine("Coffe ´n Code"); //gör till meny2

                string strMenu = Console.ReadLine();
                char menuChoice = Convert.ToChar(strMenu);
                char menuChoiceUpper = menuChoice.ToUpper();

                string string1 = "c";
                string upperString = string1.ToUpper();

                switch



            }

        }


        // metod för att skriva ut medlemmar
        static void WriteAllMembers()
        {
            List<string> groupNames = new List<string>();
            groupNames.Add("Mikael Alexander Larsson");
            groupNames.Add("Karin Madeleine Karlsson");
            groupNames.Add("Sammy On Tat Wong");
            groupNames.Add("David Josef Frödin");
            groupNames.Add("Rauf Karimli");
            groupNames.Add("Erik Rindlert");
            groupNames.Add("Daniel Jacob Arlbring");
            groupNames.Add("Svante Joelsson");
            groupNames.Add("Sarah Winroth");
            groupNames.Add("Farzane Zafarzade");
           
            groupNames.ForEach(i => Console.Write(" " + "{0}" + ",", i));
        }
       
    }
}
