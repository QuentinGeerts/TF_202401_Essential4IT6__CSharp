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

        Class1 class1 = new Class1();
        class1.X = default(int);
        Console.WriteLine(class1.X);
        Console.WriteLine(Class1.Y);

        Personne quentin = new Personne();
        quentin.prenom = "Quentin";
        quentin.nom = "Geerts";

        Console.WriteLine($"Information de Quentin :\nNom: {quentin.nom}\nPrénom: {quentin.prenom}");


        //{
        //    int a; // a = Accessible à partir d'ici
        //    {
        //        int b; // b = Accessible à partir d'ici

        //        {
        //            int c; // c = Accessible à partir d'ici
        //        } // c = jusqu'ici 
        //    } // b = jusqu'ici 


        //} // a = Jusqu'ici
        var a = true.ToString();
        Console.WriteLine(a + " - " +  a.GetType());


        int ent = 5;

        object obj = ent; // Boxing => Cast implicite
        int ent2 = (int) obj; // Unboxing => Cast explicite => (int)
    }
}

