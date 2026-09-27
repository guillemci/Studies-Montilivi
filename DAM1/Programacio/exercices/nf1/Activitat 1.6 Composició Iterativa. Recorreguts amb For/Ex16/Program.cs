namespace Ex16
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani a l’usuari un número i que mostri una piràmide.
        ///NTRA UN NÚMERO: 4
        ///*
        ///**
        ///***
        ///****
        /// </summary>
        static void Main(string[] args)
        {
            int j = Convert.ToInt32(Console.ReadLine());
            //bucle
            Console.WriteLine("introdueix aqui la longitud de la mitja piramide");
            for (int i = 0; i <= j; i++)
            {
                //j pasa a ser 1 per tant k a d'arribar a 1 printeja 1
                //j pasa a ser 2 per tant k a d'arribar a 2 printeja 2

                //bucle niat AKA doble bucle
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }

                //fa la nova linea
                Console.WriteLine();

                //també es pot fer amb aquest objecte
                /* 
                string tabs = new string('*', j);
                Console.WriteLine(tabs);
                */
            }
        }
    }
}
