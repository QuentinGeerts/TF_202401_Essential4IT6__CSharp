// Calcule de la division entière, du modulo et de la division de deux entiers.
// Résultat attendu pour 5 et 2 🡪 Division entière : 2, Modulo: 1, Division: 2,5.

//Console.WriteLine("Entrez un premier nombre :");
//int.TryParse(Console.ReadLine(), out int nb1);

//Console.WriteLine("Entrez un deuxième nombre :");
//int.TryParse(Console.ReadLine(), out int nb2);

int nb1 = 5;
int nb2 = 2;

Console.WriteLine($"Division entière : {nb1 / nb2}");
Console.WriteLine($"Modulo : {nb1 % nb2}");
Console.WriteLine($"Division : {nb1 / (double)nb2}");