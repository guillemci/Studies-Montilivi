namespace ClassePersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("nom: "); 
            string nom = Console.ReadLine();
            
            Console.WriteLine("data naixement dd/mm/yyyy: "); 
            DateTime dataNeix = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("sexe H/M: "); 
            char sexe = Convert.ToChar(Console.ReadLine());
            char.ToUpper(sexe);
            
            Console.WriteLine("pes kg: "); 
            double pes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("alçada m: "); 
            double alcada = Convert.ToDouble(Console.ReadLine());

            Persona persona1 = new Persona(nom, dataNeix, sexe, pes, alcada);
            Persona persona2 = new Persona(nom, dataNeix, sexe);
            Persona persona3 = new Persona();
            persona3.Nom = "persona3";
            persona3.DataNeixa = new DateTime(1990, 1, 1);
            persona3.Sexe = 'M';
            persona3.Pes = 70;
            persona3.Alçada = 1.75;

            Persona[] persones = { persona1, persona2, persona3 };

            for (int i = 0; i < persones.Length; i++)
            {
                Console.WriteLine($"persona {i + 1}:");
                int imc = persones[i].calcularIMC();

                if (imc == -1)
                    Console.WriteLine("pes baix");
                else if (imc == 0)
                    Console.WriteLine("pes ideal");
                else
                    Console.WriteLine("sobrepes");

                if (persones[i].esMajorDeEdat())
                    Console.WriteLine("major d'edat");
                else
                    Console.WriteLine("menor d'edat");

                Console.WriteLine(persones[i].ToString());
            }
        }
    }
}
