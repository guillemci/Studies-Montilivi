using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePersona
{
    public class Persona
    {
        private const int PES_INFERIOR = -1;
        private const int PES_NORMAL = 0;
        private const int SOBREPES = 1;
        private const char SEXE_DEFAULT = 'H';

        private string nom;
        private string dni;
        private DateTime dataNeixa;
        private char sexe;
        private double pes;
        private double alcada;

        public Persona()
        {
            this.nom = "";
            this.dataNeixa = DateTime.MinValue;
            this.sexe = SEXE_DEFAULT;
            this.pes = 0;
            this.alcada = 0;
        }

        public Persona(string nom, DateTime dataNeixa, char sexe, double pes, double alcada)
        {
            this.nom = nom;
            this.dataNeixa = dataNeixa;
            this.sexe = sexe;
            this.pes = pes;
            this.alcada = alcada;
            this.dni = GeneraDNI();
        }

        public Persona(string nom, DateTime dataNeixa, char sexe) : this(nom, dataNeixa, 'H', 0.0, 0.0) { }

        public int calcularIMC()
        {
            if (this.alcada <= 0)
                return PES_INFERIOR;

            double valor = this.pes / (Math.Pow(this.alcada, 2));
            int valorARetornar;

            if (valor < 20)
                valorARetornar = PES_INFERIOR;
            else if (valor >= 20 && valor <= 25)
                valorARetornar = PES_NORMAL;
            else
                valorARetornar = SOBREPES;

            return valorARetornar;
        }

        public bool esMajorDeEdat()
        {
            DateTime avui = DateTime.Today;
            int edat = avui.Year - this.dataNeixa.Year;

            if (this.dataNeixa > avui.AddYears(-edat))
                edat--;

            return edat >= 18;
        }

        private char ComprovarSexe(char sexe)
        {
            if (sexe == 'H' || sexe == 'M') return sexe;
            else return 'H';
        }

        private string GeneraDNI()
        {
            Random rnd = new Random();

            int numeroDNI = rnd.Next(10000000, 100000000);
            char lletra = 'X';
            string DNIComplert = ($"{numeroDNI}{lletra}");

            return DNIComplert;
        }

        public override string ToString()
        {
            return $"Nom: {this.nom}, data naixement: {this.dataNeixa.ToShortDateString()},DNI: {this.dni}, sexe: {this.sexe}, pes: {this.pes}kg, alçada: {this.alcada} metres";
        }

        //private const int PES_INFERIOR = -1;
        //private const int PES_NORMAL = 0;
        //private const int SOBREPES = 1;
        //private const char SEXE_DEFAULT = 'H';
        //private string nom;
        //private string dni;
        //private DateTime dataNeixa;
        //private bool sexe; //true dona, fals home
        //private double pes;
        //private double alçada;

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public DateTime DataNeixa
        {
            get { return this.dataNeixa; }
            set { this.dataNeixa = value; }
        }

        public char Sexe
        {
            get { return this.sexe; }
            set { this.sexe = ComprovarSexe(value); }
        }

        public double Pes
        {
            get { return this.pes; }
            set { this.pes = value; }
        }

        public double Alçada
        {
            get { return this.alcada; }
            set { this.alcada = value; }
        }
    }
}
