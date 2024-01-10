// Opérateurs

// Affectation

int x = 5;

//x = x + 1;
//x += 1;
Console.WriteLine(x++); // 5 | 6

// Valeur affichée : 5
// Valeur après l'instruction : 6 

x = 5;

Console.WriteLine(++x); // 5 | 6

// Valeur affichée : 6
// Valeur après l'instruction : 6

x += 2; // x = x + 2;

string msg = "Hello";

msg += " Comment ça va ? ";

// Typeof

object o = 5L;
Type type = typeof(object);

Console.WriteLine(type);

if (o.GetType() == type)
{
    Console.WriteLine("Le type de o est un object");
}
else
{
    Console.WriteLine("Le type de o est un " + o.GetType());
}