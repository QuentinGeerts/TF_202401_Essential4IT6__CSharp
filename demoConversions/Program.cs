// Conversions

// Type à String : ToString()

int a = 5;
double b = 5.1;
bool c = true;

Console.WriteLine(a.GetType());
Console.WriteLine(b.GetType());
Console.WriteLine(c.GetType());

string aS = a.ToString();
string bS = b.ToString();
string cS = c.ToString();

Console.WriteLine(aS.GetType());
Console.WriteLine(bS.GetType());
Console.WriteLine(cS.GetType());

// String à Type : 
//  - La classe Convert

Console.WriteLine(Convert.ToInt32(aS) + Convert.ToInt16(aS));
Console.WriteLine(Convert.ToDouble(bS));
Console.WriteLine(Convert.ToBoolean(cS));

// Convert.ToInt32("2a");
Console.WriteLine( Convert.ToBoolean(-2) );

//  - La méthode Parse()

Console.WriteLine( int.Parse("2") );
//Console.WriteLine( int.Parse("a") );
//Console.WriteLine( int.Parse("2147999999") );

//  - La méthode TryParse()
int result;

if (int.TryParse(Console.ReadLine(), out result))
    Console.WriteLine(result + " " + result.GetType());
else
    Console.WriteLine("Conversion échouée");