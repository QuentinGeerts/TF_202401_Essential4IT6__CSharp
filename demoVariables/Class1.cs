namespace demoVariables;

internal class Class1
{
    // Une classe possède des membres
    // Une variable membre
    int X; // default(T) => INT => 0

    // Une méthode membre
    public void MaMethode()
    {
        // Une variable locale 
        // = Accessible uniquement dans MaMethode()
        int Y;
        // Console.WriteLine("La valeur vaut : " + Y); // N'a pas de valeur...
        Console.WriteLine("La valeur vaut : " + X); // 0
    }

    public void MaMethode2()
    {
        // Une variable locale
        // = Accessible uniquement dans MaMethode2()
        int Z;
        int X = 4;
        Console.WriteLine("La valeur vaut : " + X); // 4
        Console.WriteLine("La valeur vaut : " + this.X); // 0
    }
}

