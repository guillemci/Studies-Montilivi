/// <summary>
/// Escriu un programa per mostrar l'hora en format hh:mm:ss a partir d'una quantitat
/// de segons donada com a entrada. Per exemple, si l'entrada és 4000, la sortida ha de
/// ser 01:04:40.
/// </summary>

/*int segonsProporcionats, segonsProporcionatsM, segonsFinals, minuts, horas;

horas = 0;
minuts = 0;
segonsFinals = 0;
segonsProporcionats = Convert.ToInt32(Console.ReadLine());
segonsProporcionatsM = segonsProporcionats;

while (segonsProporcionats > 0)
{
    if (segonsProporcionats >= 3600)
    {
        horas += 1;
        segonsProporcionats -= 3600;
    }
    else if (segonsProporcionats >= 60)
    {
        minuts += 1;
        segonsProporcionats -= 60;
    }
    else if (segonsProporcionats < 60 || segonsProporcionats == 0)
    {
        segonsFinals = segonsProporcionats;
    }
}

Console.WriteLine($"{segonsProporcionatsM} {horas} {minuts} {segonsFinals}");*/

//variables
int segonsapasar;
int segons;
int minuts;
int horas;

//entrades
Console.WriteLine("introdueix aqui el numero de segons que es volen pasar a hores, minuts...");
segonsapasar = Convert.ToInt32(Console.ReadLine());

//segonstotal = segonstotal - hores * 3600
//calcul
horas = segonsapasar / 3600;
minuts = (segonsapasar % 3600) / 60;
segons = segonsapasar % 60;

//sortides
Console.WriteLine("això ens dona la seguent hora");
Console.WriteLine($"{horas:D2}:{minuts:D2}:{segons:D2}");