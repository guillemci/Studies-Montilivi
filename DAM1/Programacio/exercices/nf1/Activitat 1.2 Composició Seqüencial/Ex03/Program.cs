/// <summary>
/// Escriu un programa demani a l’usuari una quantitat d'hores, minuts i segons i ens
/// informi per la consola del total de temps entrat, convertit tot en segons.
/// </summary>

//variables
int hores, minuts, segons;
int horesProcesades, minutsProcesats;
int resultat;

//entrada de dades
Console.Write("Posa aqui les hores ");
hores = Convert.ToInt32(Console.ReadLine());

Console.Write("Posa aqui els minuts ");
minuts = Convert.ToInt32(Console.ReadLine());

Console.Write("Posa aqui els segons ");
segons = Convert.ToInt32(Console.ReadLine());

//calcul
horesProcesades = hores * 60 * 60;
minutsProcesats = minuts * 60;
resultat = horesProcesades + minutsProcesats + segons;

//sortida
Console.WriteLine($"les hores introduides han estat {hores}");
Console.WriteLine($"els minuts introduits han estat {minuts}");
Console.WriteLine($"els segons introduits han estat {segons}");
Console.WriteLine($"en total hi han aquests segons {resultat}");