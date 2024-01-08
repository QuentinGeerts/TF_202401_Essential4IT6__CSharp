using System.Text;

namespace demoTypes;

internal class Program
{
    static void Main(string[] args)
    {
        // Types : 
        //  - Valeur → Sur la valeur
        //  - Références → Sur l'adresse mémoire

        // Types valeur
        // - byte

        int age = 10;
        Int32 age2 = 10;

        char c1 = 'a';
        // char c2 = "b";
        char c3 = '1';
        char c4 = '.';
        char c5 = '\'';

        string s1 = "hello";
        string s2 = "Quentin";
        // string s2 = 'a';
        string s3 = "\"";

        string s4 = $"{s1} {s3}"; // Interpolation de chaine de caractères

        Console.WriteLine(s2 + " dit à Dylan : " + s1);
        Console.WriteLine($"{c5}{s2}{c5} dit à Dylan : {s1}");

        // string test = Console.ReadLine();

        // L - long
        // U - uint
        // UL - ulong
        // F - float
        // M - decimal
        // D - double

        uint val1 = 123456789u;

        // long val2 = 123ul;

        int i = 100 / 200 * 5;
        float f = 100 / 200f * 5;


        int a = i;
        float b = i;

        int c = (int)f;
        float d = f;

        long e = 1_000_000_000_000;
        long y = 1000000000000;

        // String Literal

        string monPrenom = "Quentin";
        string monPrenom2 = "Quentin";

        Console.WriteLine(monPrenom);
        Console.WriteLine(monPrenom2);
        Console.WriteLine(ReferenceEquals(monPrenom, monPrenom2));

        string monPrenom3 = new string(monPrenom);
        Console.WriteLine(ReferenceEquals(monPrenom, monPrenom3));

        string query = @"SELECT * FROM student WHERE studentId = 12";

        Console.WriteLine(query);

        // Formatage de chaines

        // 1. Concaténation
        string phrase = "Hello, vous allez bien ?" + "Oui ça va.";

        // 2. Classe: StringBuilder
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello");
        sb.AppendLine(", vous allez bien ?");
        sb.Append("Oui ça va.");
        Console.WriteLine(sb);

        // 3. Méthode: string.Format
        string prenom = "Quentin";
        string msg = "comment vas-tu ?";
        string message = string.Format("Bonjour {0}, {1}", prenom, msg);

        // 4. Interpolation de chaines de caractères
        message = $"Bonjour {prenom}, {msg}";

        Console.WriteLine(message);
    }
}

