/// <summary>
/// Escriu un programa per calcular la nòmina d'un treballador: L’usuari ens ha d’entrar
//el nombre total d'hores treballades, el sou brut per cada hora treballada i el
//percentatge d'impost aplicat al sou brut total, el programa ha d'informar de:
//a.Sou brut total
//b. Retenció d’impostos
//c. Sou net (sou brut menys els impostos)
/// </summary>

//funcions del sistema
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

//variables
double hores;
double souBrutPerHora;
double souBrutTotal;
double retencioDeImpostos;
double Impostos;
double souNetTotal;

//entrades
Console.WriteLine("posa aqui les hores treballades:");
hores = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("posa aqui el teu sou brut per hora:");
souBrutPerHora = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("posa aqui la comisio (per exemple IRPF 21% = 0.21)");
Impostos = Convert.ToDouble(Console.ReadLine());

//calcul
souBrutTotal = hores * souBrutPerHora;
retencioDeImpostos = souBrutTotal * Impostos;
souNetTotal = souBrutTotal - retencioDeImpostos;

//sortida
Console.WriteLine($"el sou brut total sera de {souBrutTotal}€");
Console.WriteLine($"la retenció d'impostos sera de {retencioDeImpostos:F2}€");
Console.WriteLine($"el sou net total sera de {souNetTotal:F2}€");