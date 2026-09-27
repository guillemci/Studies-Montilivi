namespace Ex11
{
    internal class Program
    {
        /// <summary>
        /// 11. Dissenyeu un algorisme que, donat un angle entre -360 i 360 graus, determini en
        /// quin quadrant es troba.
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            int angle;
            string resultatFinal;

            //inicialitzacio variable
            Console.WriteLine("Dona un angle per determinar la seva posició");
            angle = Convert.ToInt32(Console.ReadLine());

            //calcul funcio
            resultatFinal = AnalisiAngle(angle);

            //output
            Console.WriteLine(resultatFinal);
        }
        static string AnalisiAngle(int angle)
        {
            string resultat;

            //condicionals
            if (angle < 0)
            {
                angle += 360;
            }

            if (angle == 0 || angle == 360)
            {
                resultat = ($"segons l'angle introduit, el qual es: {angle} el teu angle es de tipus x");
            }
            else if (angle > 0 && angle < 90)
            {
                resultat = ($"segons l'angle introduit, el qual es: {angle} el teu angle es de tipus QI");
            }
            else if (angle == 90)
            {
                resultat = ($"segons l'angle introduit, el qual es: {angle} el teu angle es de tipus y");
            }
            else if (angle > 90 && angle < 180)
            {
                resultat = ($"segons l'angle introduit, el qual es: {angle} el teu angle es de tipus QII");
            }
            else if (angle == 180)
            {
                resultat = ($"segons l'angle introduit, el qual es: {angle} el teu angle es de tipus x'");
            }
            else if (angle > 180 && angle < 270)
            {
                resultat = ($"segons l'angle introduit, el qual es: {angle} el teu angle es de tipus QIII");
            }
            else if (angle == 270)
            {
                resultat = ($"segons l'angle introduit, el qual es: {angle} el teu angle es de tipus y'");
            }
            else if (angle > 270 && angle < 360)
            {
                resultat = ($"segons l'angle introduit, el qual es: {angle} el teu angle es de tipus QIV");
            }
            else
            {
                resultat = ("introdueix un valor valid");
            }

            return resultat;
        }
    }
}