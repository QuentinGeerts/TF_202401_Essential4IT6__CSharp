// Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK
// sur la console sinon KO.
// Le modulo des 10 premiers chiffres par 97 donne les 2 derniers.
// Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 97.
// (utilisez la méthode « Substring » de la classe « string »).

Console.WriteLine("Entrez un code BBAN sans tiret : ");
string bban = Console.ReadLine(); // 539007547034 OK

string tenFirst = bban.Substring(0, 10);
string twoLast = bban.Substring(10, 2);

long tenFirstNumber = long.Parse(tenFirst);
long twoLastNumber = long.Parse(twoLast);

if (tenFirstNumber % 97 == twoLastNumber || tenFirstNumber % 97 == 0 && twoLastNumber == 97)
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("KO");
}

// OU

bool checkValidity =
    (tenFirstNumber % 97 == twoLastNumber)
    || (tenFirstNumber % 97 == 0 && twoLastNumber == 97);

Console.WriteLine(checkValidity ? "OK" : "KO");
