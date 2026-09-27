using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D
{
    internal class Punt2D
    {
        //atributs
        private double x;
        private double y;

        //constructors
        public Punt2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Punt2D() : this(0.0, 0.0) { }

        public override string ToString()
        {
            return $"({x},{y})";
        }

        public override bool Equals(object obj)
        {
            bool valorBool = false;
            if (obj is Punt2D other)
                valorBool = this.x == other.x && this.y == other.y;

            return valorBool;
        }

        public static bool operator ==(Punt2D punt1, Punt2D punt2)
        {
            bool retornar = false;

            if (punt1.x == punt2.x && punt1.y == punt2.y)
                retornar = true;

            return retornar;
        }
        public static bool operator !=(Punt2D punt1, Punt2D punt2)
        {
            bool retornar = false;

            if (punt1.x != punt2.x && punt1.y != punt2.y)
                retornar = true;

            return retornar;
        }

        public static Punt2D operator /(Punt2D punt1, Punt2D punt2)
        {
            if (punt1.x == 0 || punt1.y == 0)
                throw new Exception("no pots dividir 0 peque");
            if (punt2.x == 0 || punt2.y == 0)
                throw new Exception("no pots dividir 0 peque");

            Punt2D puntAux = new Punt2D();

            puntAux.x = punt1.x / punt2.x;
            puntAux.y = punt1.y / punt2.y;

            return puntAux;
        }

        public static Punt2D operator %(Punt2D punt1, Punt2D punt2)
        {
            if (punt1.x == 0 || punt1.y == 0)
                throw new Exception("no pots fer modul de 0 peque");
            if (punt2.x == 0 || punt2.y == 0)
                throw new Exception("no pots fer modul de 0 peque");

            Punt2D puntAux = new Punt2D();

            puntAux.x = punt1.x % punt2.x;
            puntAux.y = punt1.y % punt2.y;

            return puntAux;
        }

        public static Punt2D operator ++(Punt2D punt)
        {
            Punt2D puntAux = new Punt2D();

            puntAux.x = punt.x++;
            puntAux.y = punt.y++;

            return puntAux;
        }
    }
}
