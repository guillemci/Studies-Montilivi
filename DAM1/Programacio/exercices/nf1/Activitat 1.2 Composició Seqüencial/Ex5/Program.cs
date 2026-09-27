/// <summary>
/// Escriu un programa per demanar una lletra pel teclat i mostrar el seu codi ASCII a la
/// pantalla.
/// </summary>

//variables
char lletraIntroduida = 'a';
int lletraProcesada;

//entrada
Console.WriteLine("introdueix la lletra/caracter que en vulguis saber el seu codi ASCII");
lletraIntroduida = Convert.ToChar(Console.ReadLine());

//calcul
lletraProcesada = lletraIntroduida;

//sortida
Console.WriteLine($"el codi ASCII de la lletra es {lletraProcesada}");