/// <summary>
/// Escriu un programa que et demani el nombre de cares d'un dau i després llença el
/// dau aleatòriament (suposa que el dau està numerat començant per 1)
/// </summary>

//variables
Random random = new Random();
int cares, tirada;

//entrades
Console.WriteLine("determina el numero de cares");
cares = Convert.ToInt32(Console.ReadLine());

//calculs
tirada = random.Next(1, cares + 1);

//sortida
Console.WriteLine($"el dau dels valors 1 al {cares} a tret el numero {tirada}");