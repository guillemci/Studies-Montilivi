/// <summary>
/// Interpreta el significat del següent fragment de codi
/// </summary>

//declaracio i entrada
int n = Convert.ToInt32(Console.ReadLine()); //aqui es declara i demana per terminal un valor

//calcul
n = n + 1; //un cop es te el valor es fa el valor + 1

//sortida
Console.WriteLine($"HAS ENTRAT: {n - 1}\nI UN MÉS VAL {n}"); //a continuació es fa print de n - 1 (que valor anterior a la operacio n = n + 1;) i de n (valor despres de n = n + 1;)
Console.WriteLine($"HAS ENTRAT: {n - 1:0000}\nI UN MÉS VAL en:0000}"); //el mateix que adalt pero es posen 4 zeros devant (4 zeros + el numero per tant per exemple si posem 9 es 0009)