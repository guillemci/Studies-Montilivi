using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseTriangle
{
    internal class Triangle
    {
        private double baseTriangle;
        private double alturaTriangle;
        private string nomTriangle;

        public Triangle()
        {
            this.baseTriangle = 1;
            this.alturaTriangle = 1;
            this.nomTriangle = "NONAME";
        }

        public Triangle(double baseTriangle, double alturaTriangle, string nomTriangle)
        {
            if (baseTriangle < 0 || alturaTriangle < 0) throw new ArgumentException("base i alçada tenen que ser positives");
            this.baseTriangle = baseTriangle;
            this.alturaTriangle = alturaTriangle;
            this.nomTriangle = nomTriangle;
        }

        public Triangle(Triangle copia)
        {
            this.baseTriangle = copia.baseTriangle;
            this.alturaTriangle = copia.alturaTriangle;
            this.nomTriangle = copia.nomTriangle;
        }

        public void Suma(Triangle triangle)
        {
            this.baseTriangle += triangle.baseTriangle;
            this.alturaTriangle += triangle.alturaTriangle;
            this.nomTriangle += triangle.nomTriangle;
        }

        public double PreuSuperficie(double preuM2)
        {
            double area = 0.5 * baseTriangle * alturaTriangle;
            return area * preuM2;
        }

        public void AmpliarAlçada()
        {
            this.alturaTriangle += 1;
        }

        public void AmpliarAlçada(double increment)
        {
            this.alturaTriangle += increment;
        }

        public string ComTeDius()
        {
            return this.nomTriangle;
        }

        public static bool Iguals(Triangle primer, Triangle segon)
        {
            return primer.baseTriangle == segon.baseTriangle &&
                   primer.alturaTriangle == segon.alturaTriangle &&
                   primer.nomTriangle == segon.nomTriangle;
        }

        public static Triangle Suma(Triangle t1, Triangle t2)
        {
            return new Triangle(t1.baseTriangle + t2.baseTriangle, t1.alturaTriangle + t2.alturaTriangle, t1.nomTriangle + t2.nomTriangle);
        }

        public double BaseTriangle
        {
            get { return baseTriangle; }
            set
            {
                if (value < 0) throw new ArgumentException("la base no pot ser negativa");
                this.baseTriangle = value;
            }
        }

        public double AlturaTriangle
        {
            get { return this.alturaTriangle; }
            set
            {
                if (value < 0) throw new ArgumentException("l'alçada no pot ser negativa");
                this.alturaTriangle = value;
            }
        }

        public bool guay
        {
            get { return this.baseTriangle == 2 * this.alturaTriangle; }
        }

        public override string ToString()
        {
            return ($"BASE: {this.baseTriangle} ALÇADA: {this.alturaTriangle} NOM: {this.nomTriangle}");
        }

    }
}
