// Calculer les 25 premiers nombres de la suite de Fibonacci

Console.WriteLine("Combien de nombre de la suite de Fibonacci voulez-vous ?");
int nbFibo = int.Parse(Console.ReadLine());

int nb1 = 0, nb2 = 1, temp;

Console.Write($"{nb1}");

for (int i = 0; i < nbFibo; i++)
{
    Console.Write($", {nb2}");

    temp = nb1 + nb2;
    nb1 = nb2;
    nb2 = temp;
}
