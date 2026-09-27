/// <summary>
/// Escriu un programa per demanar una lletra minúscula i mostrar la lletra majúscula
/// equivalent.
/// </summary>

//variables
char lletradonada, aMajuscula;

//entrada
Console.WriteLine("introdueix la lletra que es vulgui pasar a majuscula");
lletradonada = Convert.ToChar(Console.ReadLine());

//condicional "inecesari"
if (lletradonada > 96 && lletradonada < 123)
{
    //calcul
    aMajuscula = (char)(lletradonada - 32);

    //sortida
    Console.WriteLine($"la majuscula de la lletra introduida es {aMajuscula}");
}
else
{
    Console.WriteLine("introdueix un valor valid");
}