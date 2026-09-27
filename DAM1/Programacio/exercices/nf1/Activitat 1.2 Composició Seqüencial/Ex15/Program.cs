/// <summary>
/// Calcula el canvi d'una quantitat en euros utilitzant la quantitat mínima de monedes.
/// El comerç no accepta bitllets de 500€ i 200€. Has de començar amb bitllets de 100€,
/// després 50€, 20€, 10€, 5€, 2€, 1€, 50 cèntims, 20 cèntims, 10 cèntims, 5 cèntims, 2
/// cèntims i 1 cèntim. Suposa que el comerç té canvi il·limitat disponible utilitzant
/// bitllets i monedes il·limitats.
/// </summary>

//funcions del sistema
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

//variables
int centims;
int bit100, bit50, bit20, bit10, bit5, e2, e1, cent50, cent20, cent10, cent5, cent2, cent;

//entrada
Console.WriteLine("posa aqui els centims que vulguis fer-ne cambi");
centims = Convert.ToInt32(Console.ReadLine());

//calculs
//100 euros
bit100 = centims / 10000;
centims %= 10000;

//50 euros
bit50 = centims / 5000;
centims %= 5000;

//20 euros
bit20 = centims / 2000;
centims %= 2000;

//10 euros
bit10 = centims / 1000;
centims %= 1000;

//5 euros
bit5 = centims / 500;
centims %= 500;

//2 euros
e2 = centims / 200;
centims %= 200;

//1 euro
e1 = centims / 100;
centims %= 100;

//50 centims
cent50 = centims / 50;
centims %= 50;

//20 centims
cent20 = centims / 20;
centims %= 20;

//10 centims
cent10 = centims / 10;
centims %= 10;

//5 centims
cent5 = centims / 5;
centims %= 5;

//2 centims
cent2 = centims / 2;
centims %= 2;

//1 centim
cent = centims;
centims = 0;

//sortida
Console.WriteLine("el cambi equivalent es el seguent:");
Console.WriteLine($"Bitllets de 100€: {bit100}");
Console.WriteLine($"Bitllets de 50€: {bit50}");
Console.WriteLine($"Bitllets de 20€: {bit20}");
Console.WriteLine($"Bitllets de 10€: {bit10}");
Console.WriteLine($"Bitllets de 5€: {bit5}");
Console.WriteLine($"Monedes de 2€: {e2}");
Console.WriteLine($"Monedes de 1€: {e1}");
Console.WriteLine($"Monedes de 50 centims: {cent50}");
Console.WriteLine($"Monedes de 20 centims: {cent20}");
Console.WriteLine($"Monedes de 10 centims: {cent10}");
Console.WriteLine($"Monedes de 5 centims: {cent5}");
Console.WriteLine($"Monedes de 2 centims: {cent2}");
Console.WriteLine($"Monedes de 1 centim: {cent}");