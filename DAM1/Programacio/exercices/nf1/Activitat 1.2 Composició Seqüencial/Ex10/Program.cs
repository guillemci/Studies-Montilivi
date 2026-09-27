/// <summary>
/// L'altitud dels avions es mesura en peus. 1 metre són 39,27 polzades i 1 peu són 12
///polzades. 1 polzada són 2,54 cm. Escriu un programa que ens demani una quantitat
///de peus i ens informi del seu equivalent en metres
/// </summary>

//variables
double metres = 0;

//12 * 2.54 / 100 = 0.3048;
const double peusaMetres = 0.3048;
int peus;

//entrada
Console.WriteLine("introdueix aqui els peus que seran pasats a metres");
peus = Convert.ToInt32(Console.ReadLine());

//calcul
metres = peus * peusaMetres;

//sortida
Console.WriteLine($"aquests peus a metres equivalen a {metres}");