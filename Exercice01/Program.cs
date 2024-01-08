/*
 * Exercice 01 - Débbugage, Variables et Types
 * Créer une programme qui permet de demander à l'utilisateur de rentrer ses informations telles
 * que le nom, le prénom, âge, taille en mètre (BONUS: et la date de naissance).
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
using System.Globalization;

string nom, prenom, age, taille;
DateTime date;

// 2. Demander à l'utilisateur de rentrer les informations

Console.WriteLine("Entrez votre nom : ");
nom = Console.ReadLine();

Console.WriteLine("Entrez votre prénom : ");
prenom = Console.ReadLine();

Console.WriteLine("Entrez votre âge : ");
age = Console.ReadLine();

Console.WriteLine("Entrez votre taille : ");
taille = Console.ReadLine();

Console.WriteLine("Entrez votre date de naissance : ");
date = DateTime.Parse(Console.ReadLine()); // "03/04/1996"


Console.WriteLine($"Nom: {nom}" +
    $"\nPrénom: {prenom}" +
    $"\nÂge: {age} ans" +
    $"\nTaille: {taille} m" +
    $"\nNé le: {date.ToString("dd MMMM yyyy", new CultureInfo("ja-JP"))}");
