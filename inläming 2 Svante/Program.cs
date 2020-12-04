using System;
using System.Collections.Generic;

namespace inläming_2_Svante
{
    public class MemberInBaseGroup
    {
        private string name;
        private string stad;
        private int age;
        private string boende;
        private string familj;
        private string husdjur;
        private string senasteYrke;
        private string hobby;
        private string favoritMat;
        private string favoritMusik;
        private string programmeringsDriv;

        public MemberInBaseGroup(string name, string stad, int age, string boende, string familj, string husdjur, string senasteYrke, string hobby,
            string favoritMat, string favoritMusik, string programmeringsDriv)
        {
            this.name = name;
            this.stad = stad;
            this.age = age;
            this.boende = boende;
            this.familj = familj;
            this.husdjur = husdjur;
            this.senasteYrke = senasteYrke;
            this.hobby = hobby;
            this.favoritMat = favoritMat;
            this.favoritMusik = favoritMusik;
            this.programmeringsDriv = programmeringsDriv;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Stad
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Boende
        {
            get { return boende; }
            set { boende = value; }
        }
        public string Familj
        {
            get { return familj; }
            set { familj = value; }
        }
        public string Husdjur
        {
            get { return husdjur; }
            set { husdjur = value; }
        }
        public string SenasteYrke
        {
            get { return senasteYrke; }
            set { senasteYrke = value; }
        }
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }
        public string FavoritMat
        {
            get { return favoritMat; }
            set { favoritMat = value; }
        }
        public string FavoritMusik
        {
            get { return favoritMusik; }
            set { favoritMusik = value; }
        }
        public string ProgrammeringsDriv
        {
            get { return programmeringsDriv; }
            set { programmeringsDriv = value; }
        }

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
                string menuChoice = strMenu.ToUpper();

                
                // gör en meny metod som kallar på klasserna members
               switch (menuChoice)
                {
                    case "A":
                        WriteAllMembers();
                        break;
                    case "B":
                        // WriteAllMemberInfo gör dem till klasser inte metoder
                        Console.Write("knapp b");
                        break;
                    case "C":
                        // ta bort person
                        Console.Write("knapp c");
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val prova igen");

                        break;
                }

                /*  "Mall" för att lägg in medlemmar
                    private string name;
                    private string stad;
                    private int age;
                    private string boende;
                    private string familj;
                    private string husdjur;
                    private string senasteYrke;
                    private string hobby;
                    private string favoritMat;
                    private string favoritMusik;
                    private string programmeringsDriv;
                (string name, string stad, int age, string boende, string familj, string husdjur, string senasteYrke, string hobby,
            string favoritMat, string favoritMusik, string programmeringsDriv)
                */
                List<MemberInBaseGroup> MemberList = new List<MemberInBaseGroup>();
                //AuthorList.Add(new Author("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET", true, new DateTime(2003, 7, 10)));
                MemberList.Add(new MemberInBaseGroup("Mikael Alexander Larsson","Vänersborg", 35, "Villa", "Fru Två döttrar och en tredje dotter på väg"," två kaniner",
                    " Restauranglärare", " Träning och hälsa, surdegsbröd", ": Bönchiligryta i tortillabröd", ": Elektroniskt. Allt mellan ambient och techno.",
                    "Mitt största driv är att det är härligt att få den dagliga hjärngympan man får med programmering, att det är kreativt och att man faktiskt skapar en produkt i slutändan"));
                MemberList.Add(new MemberInBaseGroup("Svante Joelsson", "Strömstad", 36, "Strömstad", ": Sambo och en son", "Hund", "Fritidspedagog", "Illustrera och animera",
            "Pasta al fungi", "Gubbrock och allt som är bra", "Kul combo av kreativitet och frihet och att en dag landa ett jobb med mer frihet"));

                foreach (var Member in MemberList)
                {
                    Console.WriteLine("Medlem: {0},{1}", MemberInBaseGroup.name, author.Age, author.BookTitle, author.IsMVP, author.PublishedDate);
                }
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
