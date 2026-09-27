/// <summary>
/// Escriu un programa per convertir una quantitat de polzades a metres. Cal tenir en
/// compte que una polzada són 2,54 cm.
/// </summary>

//variables
double metres, polzades;

//entrades
Console.WriteLine("aquest programa pasara polzades a metres");

Console.WriteLine("introdueix aqui el numero de polzades");
polzades = Convert.ToDouble(Console.ReadLine());

//calcul
metres = polzades * 2.54 / 100;

//sortida
Console.WriteLine($"les polzades pasades a metres equivalen a {metres}m");
