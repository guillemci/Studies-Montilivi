/// <summary>
/// Escriu un programa per mostrar aleatòriament una lletra majúscula
/// </summary>

//"variables" i "calculs"
Random random = new Random();

char lletraRandom = (char)random.Next(65,91); //o 90+1

//Sortida
Console.WriteLine($"la lletra random majuscula donada a sigut: {lletraRandom}");