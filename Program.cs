using System.Numerics;

namespace csharp_oppgaver_1;

class Program
{
    static void Main(string[] args)
    {


              //OPPGAVE 2

        //lager en variabel med datatypen int (en variabel som bare kan lagre hele nummere)
         //og gir den navnent myFirstNumber og gir den verdien 1
        int myFirstNumber = 1; 
        //skriver ut verdien
        Console.WriteLine(myFirstNumber);

        //lager en variabel med datatypen string (tekst basert variabel) 
        //og gir den navnet myFirstString og gir den verdien "eg e født i bergen"
        string myFirstString = "Colours you have never seen before";
        Console.WriteLine(myFirstString);

        //lager en variabel med datatypen double (hele og desimaltall) 
        //og gir den navnet fancyDouble og verdien 1.3
        double fancyDouble = 1.3; 
        Console.WriteLine(fancyDouble);
        
        //lager en variabel med datatypen char, gir den navnet aLetter 
        //og lagrer verdien 'a'
        char aLetter = 'a'; 
        Console.WriteLine(aLetter);

        //lager en int arry med navnet arrayName og gir den verdiene 1,2,3,4
        int [] arrayName = {1, 2, 3, 4};
        //en for loop hvor eg tar int gir index (i) verdien 0 sier at så lenge index har en lavere
        //verdi en arry lenght så looper den. ++i gjør at for hver loop så øker verdien til i
        //og den stoopper å loope innen 4 fordi hvis den blir mer en 4 så blir i større
        //arrayName og stopper loopen
        for (int i = 0; i < arrayName.Length; ++i){
            //skriver ut arrayName helt til i er større en arrayName.lenght stopper den
            Console.WriteLine(arrayName[i]);
        }

        //lager en array med string og gir den verdien I am a god lol
        string [] stringArray = {"I", "am", "a god", "lol"}; 
        //bruker en foreachloop hvor jeg forteller den å hente string elementene i 
        //stringArray
        foreach (string i in stringArray){
            //skriver ut elmentene.
            Console.WriteLine(i);
        }

        //laget en liste via string hvor eg har brukt
        //list sin innebygde metode .Add hvor eg har
        //added forskjellige strings til listen
        List<string> stringlist = new List<string>();
        stringlist.Add("the namless city");
        stringlist.Add("the music of Eric Zhan");
        stringlist.Add("the dream-quest of unkown kadath");
        //brukt foreach til å hente strings fra stringlist
        foreach(string names in stringlist){
            //skriver ut string elemente lagt til i list.
            Console.WriteLine(names);
        }

        //Oppgave 3
           Dictionary<int, string> myDictonary = new Dictionary<int, string>();
                myDictonary.Add(1, "Azathoth"); 
                myDictonary.Add(2, "Nyarlathotep");
                myDictonary.Add(3, "Yog-Sothoth");
                myDictonary.Add(4, "Shub-Niggurath");

                foreach(var elderGods in myDictonary)
                Console.WriteLine($"Key: {elderGods.Key}, Value: {elderGods.Value}"); 

                Console.WriteLine(IntMethode(5, 7));
                Console.WriteLine(StringMethod() + " user"); 
   
    }

            static public int IntMethode(int a, int b){
                return a + b;
            }

            static public string StringMethod (){ 
                string Lol = "Good morning, afternoon, evening and night,"; 
                return Lol; 
                
            }


 }




