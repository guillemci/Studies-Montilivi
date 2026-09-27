using System.Text;

namespace Exercici06
{
    internal class Program
    {
        /// <summary>
        ///Escriu un programa per calcular la nòmina d'un treballador: L’usuari ens ha
        ///d’entrar el nombre total d'hores treballades, el sou brut per cada hora treballada i el
        ///percentatge d'impost aplicat al sou brut total, el programa ha d'informar de:
        ///a.Sou brut total

        ///b.Retenció d’impostos
        ///c. Sou net (sou brut menys els impostos)
        ///
        /// Per assolir el vostre objectiu, escriu tres funcions:
        ///Una funció per calcular el sou brut a partir del sou brut per hora i
        ///el nombre d’hores treballades
        ///Una segona funció per calcular la retenció d’impostos a partir d’un
        ///percentatge d’ impost aplicat(valor real) i un sou brut
        ///Una tercera funció per calcular el sou net a partir de la retenció
        ///total d'impostos i el sou brut
        /// </summary>
        static void Main(string[] args)
        {
            //funcions del sistema
            Console.OutputEncoding = Encoding.UTF8;

            //variables
            double hores_;
            double souBrutPerHora_;
            double souBrutTotal_;
            double retencioDeImpostos_;
            double Impostos_;
            double souNetTotal_;

            //inicialitzacio de dades
            Console.WriteLine("posa aqui les hores treballades:");
            hores_ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("posa aqui el teu sou brut per hora:");
            souBrutPerHora_ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("posa aqui la comisio (per exemple IRPF 21% = 0.21)");
            Impostos_ = Convert.ToDouble(Console.ReadLine());

            //calcul amb funcions
            souBrutTotal_ = souBrutTotal(hores_, souBrutPerHora_);
            retencioDeImpostos_ = RetencioDeImpostos(souBrutTotal_, Impostos_);
            souNetTotal_ = SouNetTotal(souBrutTotal_, retencioDeImpostos_);

            //output
            Console.WriteLine($"el sou brut total sera de {souBrutTotal_}€");
            Console.WriteLine($"la retenció d'impostos sera de {retencioDeImpostos_:F2}€");
            Console.WriteLine($"el sou net total sera de {souNetTotal_:F2}€");
        }

        //funcio sou brut
        static double souBrutTotal(double hores, double souBrut)
        {
            double ResultatSouBrut = hores * souBrut;
            return ResultatSouBrut;
        }

        //funcio retencio
        static double RetencioDeImpostos(double souBrutTotal, double Impostos)
        {
            double ResultatRetencioDImpostos = Impostos * souBrutTotal;
            return ResultatRetencioDImpostos;
        }

        //funcio sou net
        static double SouNetTotal(double souBrut, double retencioDeImpostos)
        {
            double ResultatSouNetTotal = souBrut - retencioDeImpostos;
            return ResultatSouNetTotal;
        }
    }
}
