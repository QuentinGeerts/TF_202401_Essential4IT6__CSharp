// For

//Console.WriteLine("Entrez le nombre d'élèves :");
//int nbCotes = int.Parse(Console.ReadLine());

//int somme = 0;
//double moyenne = 0;

//// Initialisation ; condition ; incrémentation
//for (int i = 0; i < nbCotes; i++)
//{
//    Console.WriteLine($"Entrez la côte de l'élève n°{i + 1}: ");
//    somme += int.Parse( Console.ReadLine() );
//}

//moyenne = somme / (double) nbCotes;

//Console.WriteLine( $"La moyenne de la classe est de : {moyenne}");

// While
//Console.WriteLine("Entrez une valeur numérique : ");
//int inputNumber;

//while (!int.TryParse(Console.ReadLine(), out inputNumber))
//{
//    Console.WriteLine("Mauvaise entrée\nEntrez une valeur correcte : ");
//}

//Console.WriteLine($"C'est bien une valeur numérique {inputNumber}");

// Do ... While

//int inputNumber;

//do
//{
//    Console.WriteLine("Entrez une valeur numérique : ");
//} while (!int.TryParse(Console.ReadLine(), out inputNumber));

//Console.WriteLine($"C'est bien une valeur numérique {inputNumber}");

// Foreach

string word = "dzadj248d§è!çà";

//foreach (char letter in word)
//{
//    Console.WriteLine(letter);
//}

//int number = 123456;

//foreach (char digit in number.ToString())
//{
//    // Transformation du type sans conversion de la valeur
//    Console.WriteLine("(int) digit : " + (int)digit); // Transtypage

//    // Conversion de la valeur en le type souhaité
//    Console.WriteLine("int.Parse(digit.ToString()) : " + int.Parse(digit.ToString()));
//}

// Transformation de la chaine de caractère en majuscule

string wordUppercased = "";

foreach (char letter in word)
{
    int letterCode = (int)letter;

    if (letterCode >= 97 && letterCode <= 122 || letterCode >= 224 && letterCode <= 254)
    {
        // Lettre en majuscule
        letterCode -= 32;
        wordUppercased += (char)letterCode;
    }
    else
    {
        wordUppercased += letter;
    }
}

Console.WriteLine(wordUppercased);