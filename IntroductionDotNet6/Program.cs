namespace IntroductionDotNet6;

internal class Program
{
    static void Main(string[] args)
    {
        // . : opérateur d'accès aux membres

        // Ecrire dans la console
        Console.WriteLine("Un message");
        Console.WriteLine("Mon message : " + " est le suivant");

        int age = 27;
        Console.WriteLine("J'ai " + age + " ans");

        // Lire dans la console
        // Lire(age)
        string monAgeString = Console.ReadLine(); // "" 

        Console.WriteLine("Valeur : " + monAgeString);

        Console.Clear();

        Console.WriteLine("La console a été nettoyée.");
    }
}

