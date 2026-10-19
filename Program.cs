double saldo = 100;

Console.WriteLine("Tervetuloa SimpleBankiin");
Console.WriteLine($"Tilin saldo on {saldo} euroa.");

Console.Write("Anna nostettava summa: ");
double nosto = double.Parse(Console.ReadLine());

if (nosto <= saldo)
{
    saldo = saldo - nosto;
    Console.WriteLine($"Nosto onnistui. Uusi saldo on {saldo} euroa.");
}
else
{
    Console.WriteLine("Tilillä ei ole tarpeeksi rahaa.");
}