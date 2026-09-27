/// <summary>
/// Resumeix en una frase (en català) l'objectiu d'aquest programa. Abans d'escriure la
///resposta, escriu la traça donant els valors 2 i 3 a les variables a i b quan l'usuari
///introdueix les dades.
///i. int a, b, c;
///ii.a = Convert.ToInt32(Console.ReadLine());
///iii.b = Convert.ToInt32(Console.ReadLine());
///iv.c = a;
///v.a = b;
///vi.b = c;
///vii.Console.WriteLine(a);
///viii.Console.WriteLine(b);
/// </summary>

//variables declarades
int a, b, c; 

// valors introduits per l'usuari
a = Convert.ToInt32(Console.ReadLine()); 
b = Convert.ToInt32(Console.ReadLine()); 

// interacnvi de valors a les variables
c = a; 
a = b; 
b = c; 

// mostra resultats
Console.WriteLine(a); 
Console.WriteLine(b); 

//aquest programa el que fa es demanar al usuari uns valors per despres guardar-los a unes variables i intercambiar-ne
//el valor i equivalencia d'aquestes sense perdre el valor inicial de la a (el valor de la a pasa a la c)