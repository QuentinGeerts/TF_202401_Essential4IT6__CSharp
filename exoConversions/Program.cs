// En utilisant la méthode « Console.ReadLine() »
// ◼ Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire
// l’addition, la conversion devra utiliser la méthode « int.Parse() »
// ◼ Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire
// l’addition, la conversion devra utiliser la méthode « int.TryParse() »

using System.Globalization;

Console.WriteLine("Entrez le premier nombre :");
int nb1 = int.Parse(Console.ReadLine());

Console.WriteLine("Entrez le deuxième nombre :");
int.TryParse(Console.ReadLine(), out int nb2);

Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");


/*
 * Exercice 02 - Débbugage, Variables et Types
 * Créer une programme qui permet de demander à l'utilisateur de rentrer ses informations telles
 * que le nom, le prénom, âge, taille en mètre (BONUS: et la date de naissance). (Dans leur type d'origine)
 * Vous pouvez vous aider d'internet pour la date de naissance. sourire
 * Le programme doit ensuite afficher les données formatées: 
 * Nom: XXX
 * Prénom: XXX
 * Âge: XX ans
 * Taille: X.XX m
 * BONUS
 * Né le: XX / XX / XXXX
 */

// 1. Création des variables

string nom, prenom;
int age;
double taille;
DateTime date;

// 2. Demander à l'utilisateur de rentrer les informations

Console.WriteLine("Entrez votre nom : ");
nom = Console.ReadLine();

Console.WriteLine("Entrez votre prénom : ");
prenom = Console.ReadLine();

Console.WriteLine("Entrez votre âge : ");
age = int.Parse(Console.ReadLine());

Console.WriteLine("Entrez votre taille : ");
taille = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entrez votre date de naissance : ");
date = DateTime.Parse(Console.ReadLine()); // "03/04/1996"


Console.WriteLine($"Nom: {nom}" +
    $"\nPrénom: {prenom}" +
    $"\nÂge: {age} ans" +
    $"\nTaille: {taille} m" +
    $"\nNé le: {date.ToString("dd MMMM yyyy", new CultureInfo("ja-JP"))}");
