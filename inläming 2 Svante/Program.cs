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
            get { return stad; }
            set { stad = value; }
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
        public class MemberInBaseGrop
        {


        }



    }
    public class Svanton : MemberInBaseGroup
    {
        public Svanton(string name, string stad, int age, string boende, string familj, string husdjur, string senasteYrke, string hobby,
            string favoritMat, string favoritMusik, string programmeringsDriv) : base(name, stad, age, boende, familj, husdjur, senasteYrke,
                hobby, favoritMat, favoritMusik, programmeringsDriv)
        {
            programmeringsDriv = "Fiezta";
        }


    }
    class Program
    {
        
        static void Main(string[] args)
        {
            bool keepAskingPassword = true;
            bool keepGoing = true;

            while (keepAskingPassword == true)
            {
                // städa upp med method
                Console.WriteLine("\n\t\t\tVälkommen!\n\nVar god skriv in den hemliga koden");
                Console.Write(">");

                string strPassword = Console.ReadLine();
                string password = strPassword.ToUpper();
                Console.WriteLine(password);
                if (password == "COFFE N CODE")
                {
                    Console.Clear();
                    Console.WriteLine("Du är värdig\n");
                    keepAskingPassword = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Du är inte värdig\n");
                }

            }

            while (keepGoing)
            {
                Console.WriteLine("\n\tCoffe ´n Code"); //gör till meny2 method

                OptionMenu();

                
            }

        }
        static void OptionMenu()
        {
              // en "huvudmetod" med lista de andra behöver bara läsa förutom removeMember
          
            List<MemberInBaseGroup> memberList = new List<MemberInBaseGroup>();
            memberList.Add(new MemberInBaseGroup("Mikael Alexander Larsson", "Vänersborg", 35, "Villa", "Fru Två döttrar och en tredje dotter på väg", " två kaniner",
            "Restauranglärare", " Träning och hälsa, surdegsbröd", ": Bönchiligryta i tortillabröd", ": Elektroniskt. Allt mellan ambient och techno.",
            "Mitt största driv är att det är härligt att få den dagliga hjärngympan man får med programmering, att det är kreativt och att man faktiskt skapar en produkt i slutändan"));
            memberList.Add(new MemberInBaseGroup("Svante Joelsson", "Strömstad", 36, "Lägenhet", "Sambo och en son", "Hund", "Fritidspedagog", "Illustrera och animera",
            "Pasta al fungi", "Gubbrock och allt som är bra", "Kul combo av kreativitet och frihet och att en dag landa ett jobb med mer frihet"));
            memberList.Add(new MemberInBaseGroup("Karin Madeleine Karlsson", "Stockholm", 35, "Hyr en villa", " Sambo och en dotter", "Tre katter", "Har varit ekonomiassistent, testare och senast föräldraledig", " Bakning och spela Stardew Valley",
            "Någon form av biff, sötpotatispommes och beanésås", "Just nu, allt som inte är barnvisor", "Har alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv"));
            memberList.Add(new MemberInBaseGroup("Sammy On Tat Wong", "Åmål", 54, "Villa", "Fru och en son", "3 katter och en hund", "Personlig assistent", "Fotografering, matlagning",
            "Asiatisk, italiensk, svensk husmanskost", " Soul, RnB, House", "Att kunna skapa någonting själv, problemlösning och tillfredsställelse när man har löst ett problem"));
            memberList.Add(new MemberInBaseGroup("David Josef Frödin", "Sundbyberg", 25, "Lägenhet", " det vanliga", "Inga", "Verksamhetschef på en studentförening", " Leta efter universums hemligheter, målning, lära sig språk",
            "Bortsch", " Allt! Inne i rockperiod som varvas med rysk folkmusik", "Det är ballt och jag får kombinera kreativitet, problemlösning och människoperspektiv i en trevlig mix"));
            memberList.Add(new MemberInBaseGroup("Rauf Karimli", " Göteborg", 36, "Villa", "Fru, en son och en dotter", "Inga", "Projektledare", " Spela piano, laga mat",
            " Grillat kött", " Gott och blandat", "De gränslösa möjligheterna att utveckla och utvecklas"));
            memberList.Add(new MemberInBaseGroup(" Erik Rindlert", " Stockholm", 31, "Lägenhet", "Ogift", "Inga", "IT-support", "Litteratur, datorspel",
            "Svensk-fransk fisksoppa", " Schubert eller Darkthrone, beroende på dag", "Bygga, bygga, bygga"));
            memberList.Add(new MemberInBaseGroup("Daniel Jacob Arlbring", ": Alingsås", 24, "Lägenhet", "Sambo", "Inga", "Väktare", " Motorsport/datorspel",
            "Italienskt", " House", ""));
            memberList.Add(new MemberInBaseGroup("Sarah Winroth", "Vara", 31, "Lägenhet", "Gift", "Inga", " Reseledare", " Motionerar gärna",
            " Älskar mat i alla former", "Lyssnar på det mesta", " Själva problemlösningen och tillfredsställelsen efteråt!"));
            memberList.Add(new MemberInBaseGroup("Farzane Zafarzade", "Karlstad", 32, "Lägenhet", "min man och inget barn", "Inga", "IT-support", "Träning och bakning",
            "Alla typer av pastarätter", "lugna och klassikermusik", ": Problemlösning, inom att lösa problem man lär sig att bli mer tålmodig och kreativ"));

            Console.WriteLine("\nvalA write all \nVal B info \nval c remove\n");
            string strMenu = Console.ReadLine();
            string menuChoice = strMenu.ToUpper();
            

            switch (menuChoice)
            {
                case "A":
                    WriteAllMembers(memberList);

                    break;
                case "B":

                    
                    WriteMemberInfo(memberList);

                    break;
                case "C":
                    RemoveMember(memberList);
                    break;

                default:
                    Console.WriteLine("Ogiltigt val prova igen");

                    break;
            }
        }
        
        static void WriteAllMembers(IReadOnlyList<MemberInBaseGroup> memberList)
        {

            Console.Clear();
            foreach (var member in memberList) 
            {
                Console.Write($"{{0}},",member.Name);
            }
                       
        }
        static void WriteMemberInfo(IReadOnlyList<MemberInBaseGroup> memberList)
        {
            Console.Clear();
            
            foreach (var member in memberList)
            {
                Console.WriteLine($" Namn:{{0}}\n Stad: {{1}}\n Ålder: {{2}}\n Boende: {{3}}\n Familj: {{4}}\n Husdjur: {{5}}\n Senaste yrke: {{6}}\n Hobby: {{7}}\n Favorit maträtt: {{8}}\n Favorit musik: {{9}}\n Driv till att programera: {{10}}\n"
                    , member.Name, member.Stad, member.Age, member.Boende, member.Familj, member.Husdjur, member.SenasteYrke, member.Hobby, member.FavoritMat, member.FavoritMusik, member.ProgrammeringsDriv);

            }

        }

        static void RemoveMember(List<MemberInBaseGroup> memberList)
        {
            Console.Clear();

            
            for (int i = 0; i < memberList.Count; i++)
            {
                Console.WriteLine($" {i +1} {memberList[i].Name}");
            }

            Console.WriteLine("Skriv numret på den du vill ta bort");
            Console.WriteLine(">");
            int iRemove = Convert.ToInt32(Console.ReadLine());
            memberList.RemoveAt(2);


            // valet under tar bort en hel rad
            // memberList.RemoveAt(1);



        }




    }
}
