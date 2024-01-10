// Demander à l’utilisateur d’encoder 1 nombre (int), si la somme des deux moitiés
// de celui-ci donne le nombre, afficher « le nombre est paire » sinon « le nombre est impaire ».

Console.WriteLine("Entrez un nombre entier :");
if (int.TryParse(Console.ReadLine(), out int nombre))
{
    if ((nombre / 2) * 2 == nombre)
    {
        Console.WriteLine("Pair");
    }
    else
    {
        Console.WriteLine("Impair");
    }

    // Opérateur ternaire

    Console.WriteLine(((nombre / 2) * 2 == nombre) ? "Pair" : "Impair");
    //                           condition         ?  si vrai : si faux
}