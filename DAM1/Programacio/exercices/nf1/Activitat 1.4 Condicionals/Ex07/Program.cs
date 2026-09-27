namespace Ex07
{
    internal class Program
    {
        ///<summary>
        ///7. En un control de radar de velocitat s'estableixen tres trams de sancions:
        ///● tram 1 de 80 Km/h a 99 Km/h, (100€ de multa)
        ///● tram 2 de 100 Km/h a 129 Km/h(300€ de multa)
        ///● tram 3 de 130 Km/h en endavant. (600€ de multa) i retirada de carnet
        ///Informeu a partir de la velocitat(que és de tipus enter), quina sanció tindrà el vehicle.
        ///Informeu també en cas que el vehicle no tingui sanció.
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            int velocitat;
            string resultatVelociat;

            //inicialitzacio
            Console.WriteLine("posa aqui la velocitat a la que anava el veicle mobil");
            velocitat = Convert.ToInt32(Console.ReadLine());

            //calcul funcio
            resultatVelociat = Velocitat(velocitat);

            //output
            Console.WriteLine(resultatVelociat);

            static string Velocitat(int velocitat)
            {
                string resultat;

                //condicional
                if (velocitat <= 0)
                {
                    return resultat = ("no et mous");
                }
                else if (velocitat <= 79)
                {
                    return resultat = ("vas a una velocitat correcte d'entre 1 a 79");
                }
                else if (velocitat <= 99)
                {
                    return resultat = ("has pasat la velocitat limit anant a una velocitat entre 80|99km/h això comporta multa tipus tram 1\nmulta de 100 euros");
                }
                else if (velocitat <= 129)
                {
                    return resultat = ("has pasat la velocitat limit anant a una velocitat entre 100|129km/h això comporta multa tipus tram 2\nmulta de 300 euros");
                }
                else
                {
                    return resultat = ("has pasat la velocitat limit anant a una velocitat que a superat 129km/h això comporta multa tipus tram 3\nmulta de 600 euros");
                }
            }
        }
    }
}