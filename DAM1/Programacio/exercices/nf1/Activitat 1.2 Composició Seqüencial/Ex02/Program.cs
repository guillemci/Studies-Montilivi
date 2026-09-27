/// <summary>
///  Escriu un programa que et demani la teva edat i et digui quants anys faràs l'any vinent.
/// </summary>

//variables
int edatIntroduida;

//entrada de dades
Console.WriteLine("introdueix aqui la teva edat");
edatIntroduida = Convert.ToInt32(Console.ReadLine());

//sortida i calcul
Console.WriteLine($"la teva edat actual es de {edatIntroduida} i la edat que tindras l'any que ve es de {edatIntroduida + 1}");