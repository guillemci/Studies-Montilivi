//variables
int nCaramels, nNens;
int caramelsPerNen, sobren;

//entrada
Console.Clear();
Console.WriteLine("Quants nens ");
nNens = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("quants caramels");
nCaramels = Convert.ToInt32(Console.ReadLine());

//proces
caramelsPerNen = nCaramels / nNens;
sobren = nCaramels % nNens;

//sortida
Console.WriteLine($"TOTAL NENS : {nNens}\t\t TOTAL CARAMELS : {nCaramels}");
Console.WriteLine($"TOQUEN A {caramelsPerNen} CARAMELS PER CADA NEN");
Console.WriteLine($"EL PROFESSOR ES QUEDA {sobren} CARAMELS");