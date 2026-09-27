/// <summary>
///Simular una màquina d’un pàrking. L’entrada que tenim seran quatre valors
///enters(HoraEntrada, MinutEntrada, HoraSortida, MinutSortida) i ha de dir l’import que ha
///de pagar, tenint en compte que cobrem 3 cèntims per minut (pagament per minut, ja ho hem
///aconseguit!) i que l’hora de sortida i d’entrada estan dins el mateix dia. El preu has
///d’indicar-lo en euros.
/// </summary>

using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int minutsEntrada, minutsSortida, horaEntrada, horaSortida, minutsSumaEntrada;
int minutsSumaSortida, mhoraEntrada, mhoraSortida, ratoQueHaEstat;
double quePagar;

Console.WriteLine("introdueix hora de entrada");
horaEntrada = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("introdueix minuts de entrada");
minutsEntrada = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("introdueix hora de sortida");
horaSortida = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("introdueix minuts de sortida");
minutsSortida = Convert.ToInt32(Console.ReadLine());

mhoraEntrada = horaEntrada * 60;

mhoraSortida = horaSortida * 60;

minutsSumaEntrada = mhoraEntrada + minutsEntrada;

minutsSumaSortida = mhoraSortida + minutsSortida;

if(minutsSumaEntrada > minutsSumaSortida)
{
    Console.WriteLine("ha de ser dints un mateix dia");
}
else
{
    ratoQueHaEstat = minutsSumaSortida - minutsSumaEntrada;

    quePagar = ratoQueHaEstat * 0.03;
    Console.WriteLine($"l'import a pagar en total es de {quePagar:F2}€");
}

