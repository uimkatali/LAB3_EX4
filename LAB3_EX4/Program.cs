using System.Globalization;

namespace lab3ex4
{

    /*
     Un program care va normaliza un sir de caractere citit de la tastatura astfel incat
    fiecare cuvant din sir sa inceapa cu MAJUSCULA, restul literelor fiind
    transformate in litere mici.
    Exemplu:
    Input: Ana ARE mErE
    Rezultat: Ana Are Mere
     */

    class Program
    {
        static void Main(string[] args)
        {
            string sir = Console.ReadLine();
            TextInfo text = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine(text.ToTitleCase(sir));
        }
    }
}