/// <summary>
/// Escriu un programa per mostrar el resultat del residu i la divisió entera de 2 números
/// enters.
/// </summary>

//variables
int numero1, numero2;
int divisioentera, residu;

//entrada
Console.WriteLine("aquest programa ens permetra fer una divisio i obtenir-ne el residu i la divisio entera");
Console.WriteLine("introdueix el primer numero de la diviso");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("introdueix el segon numero de la diviso");
numero2 = Convert.ToInt32(Console.ReadLine());

//calculs
divisioentera = numero1 / numero2;
residu = numero1 % numero2;

//sortida
Console.WriteLine($"la divisio entera es {divisioentera}");
Console.WriteLine($"el residu de la divisio es {residu}");