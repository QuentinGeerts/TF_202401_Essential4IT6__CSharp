namespace demoVariables;
internal class Program
{
    static void Main(string[] args)
    {
        // Déclaration 
        // Réservation d'un emplacement en mémoire
        // type nomVariable [ = valeur ];
        string nom;
        string prenom = "Quentin";
        string Prenom = "Dylan", Nom = "Feys";

        // Variable : lowerCamelCase
        // Propriétés, Méthodes, Classes : UpperCamelCase
        // Constantes : UPPER_CASE

        const double TVA = 0.06;

        // Les types "NULLABLE"

        Nullable<int> age = null;
        int? age2 = null; // Sucre syntaxique : Forme + simple et compact
    }
}

