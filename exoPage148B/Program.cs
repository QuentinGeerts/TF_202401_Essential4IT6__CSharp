// Calculer le factoriel d’un nombre entré au clavier

Console.WriteLine("Entrez un nombre pour calculer sa factorielle : ");
int nb = int.Parse(Console.ReadLine());
int resultat = 1;

for (int i = nb;  i > 1; i--)
{
    resultat *= i;
}

Console.WriteLine($"La factorielle de {nb} vaut {resultat}");