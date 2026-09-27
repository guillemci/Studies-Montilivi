//variables
const double PI = 3.1416;
//const double qt = 4 / 3.0;
double radi, volum;

//entrada
Console.Write("RADI DE L'ESFERA EN METRES ? ");
radi = Convert.ToDouble(Console.ReadLine());

//proces
// problema
//volum = 4 / 3 * PI * Math.Pow(radi, 3);
//solució 1
volum = 4.0 / 3.0 * PI * Math.Pow(radi, 3);
//solució 2
//volum = qt * PI * Math.Pow(radi, 3);

//sortida
Console.WriteLine($"ESFERA DE RADI {radi} TÉ UN VOLUM DE {volum} m3");