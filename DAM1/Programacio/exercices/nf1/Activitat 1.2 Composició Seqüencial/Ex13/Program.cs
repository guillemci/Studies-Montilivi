/// <summary>
/// Demana a l'usuari que introdueixi un número enter que representi un any i mostra els
/// 4 dígits per separat.
/// </summary>

/* int any;

Console.WriteLine("poseu aqui un any");

any = Convert.ToInt32(Console.ReadLine());

string anyString = any.ToString();

for (int i = 0; i < anyString.Length; i++)
{
    Console.WriteLine($" aquests son els numeros per separat {anyString[i]}");
}*/

//variables
int any;
int digit1, digit2, digit3, digit4;

//entrada
Console.WriteLine("introdueix aqui un numero de 4 digits:");

any = Convert.ToInt32(Console.ReadLine());

//calcul
digit1 = any / 1000;
digit2 = (any / 100) % 10;
digit3 = (any / 10) % 10;
digit4 = any % 10;

//sortida
Console.WriteLine($"si agafem l'any {any} i el descomposem en els seus diferents numeros el numero 1 es {digit1} el numero 2 es {digit2}\nel numero 3 es {digit3} el numero 4 es {digit4}");