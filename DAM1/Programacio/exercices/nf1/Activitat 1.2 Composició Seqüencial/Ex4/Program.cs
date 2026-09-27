/// <summary>
/// Escriu un programa que demani per teclat dos valors corresponents als coeficients a i
/// b d’una equació de primer grau ( ax + b = 0) i ens calculi la solució de l’equació. El
/// programa després de demanar els dos valors, ens ha de mostrar l’equació i la solució
/// mostrant els coeficients a i b així com la solució exactament amb dues xifres
/// decimals. No cal considerar el cas a=0;
/// </summary>

//variables
double a, b;
double resultat;

//entradas
Console.WriteLine("Defineix els valors a i b de la seguent equació: ax + b = 0 per saber-ne el resultat final: ");

Console.WriteLine("Defineix els valor de la a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Defineix els valor de la b: ");
b = Convert.ToDouble(Console.ReadLine());

//calcul
resultat = -b / a;

//sortides
Console.WriteLine($"la solucio de la equacio amb els coeficients {a} i {b} es {resultat:F2}");