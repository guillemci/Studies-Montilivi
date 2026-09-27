/// <summary>
/// Escriu un programa que ens mostri el resultat aleatori del partit Paris Sant Germain -
/// Girona de forma que tant el valor dels gols d’un com de l’altre equip sigui un valor a
/// l’atzar entre 0 i 6.
/// </summary>

//variables i "calculs"
Random random = new Random();
int golsParisSantGermain = random.Next(0, 7);
int golsGirona = random.Next(0, 7);

//sortides
Console.WriteLine("el resultat del partit es:");
Console.WriteLine($"Paris Saint-Germain ({golsParisSantGermain}|{golsGirona}) Girona");