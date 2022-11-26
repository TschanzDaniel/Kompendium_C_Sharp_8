namespace Kompendium_C_Sharp_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string leeresFeld = "#";
            string kreuz = "X";
            string Kreis = "O";
            string spieler1 = "";
            string spieler2 = "";
            string letzerSpielzug = "";

            string[,] spielfeld = new string[4, 4]
            {
                { " ","1","2","3"},
                {"A",leeresFeld,leeresFeld,leeresFeld},
                {"B",leeresFeld,leeresFeld,leeresFeld},
                {"C",leeresFeld,leeresFeld,leeresFeld}
            };

            Console.WriteLine(spielfeld[0, 0] + spielfeld[0, 1] + spielfeld[0, 2] + spielfeld[0, 3]);
            Console.WriteLine(spielfeld[1, 0] + spielfeld[1, 1] + spielfeld[1, 2] + spielfeld[1, 3]);
            Console.WriteLine(spielfeld[2, 0] + spielfeld[2, 1] + spielfeld[2, 2] + spielfeld[2, 3]);
            Console.WriteLine(spielfeld[3, 0] + spielfeld[3, 1] + spielfeld[3, 2] + spielfeld[3, 3]);
        }

        public void Spielzug(string name, string spielstein, string[,] spiefeld, string leeresFeld, string letzterSpielzug)
        {
            Console.WriteLine("Bitte geben Sie die Koordinaten in der Form 'Buchstabe,Zahl' ein:");

            if (spielstein == leeresFeld || name == letzterSpielzug || )
            {
                Console.WriteLine("Dieser Zug ist ungültig, bitte geben Sie den Zug nochmals ein");
            }


            string input = Console.ReadLine();
            string[] inputArray = input.Split(",");
            foreach(string s in inputArray)
            {

            }
        }
            
    }
}