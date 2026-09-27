using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class PilaGenerica<T> : IEnumerable<T>
    {
        private const int CAPACITAT_DEFAULT = 10;
        private int apilonamentPila;
        private T[] arrayIntern;

        public PilaGenerica()
        {
            this.arrayIntern = new T[CAPACITAT_DEFAULT];
            this.apilonamentPila = -1;
        }
        public PilaGenerica(int longitud)
        {
            this.arrayIntern = new T[longitud];
            this.apilonamentPila = -1;
        }

        public void Empila(T valor)
        {
            controlarIndexEmpila();
            this.apilonamentPila++;
            this.arrayIntern[this.apilonamentPila] = valor;
        }

        public void Desempila()
        {
            ControlarVuida();
            this.arrayIntern[this.apilonamentPila] = default;
            this.apilonamentPila--;
        }

        public T Cim()
        {
            ControlarVuida();
            return this.arrayIntern[this.apilonamentPila];
        }

        public T PCim()
        {
            T valor = Cim();
            Desempila();

            return valor;
        }

        public void ControlarVuida()
        {
            if (EsBuida())
                throw new InvalidOperationException("Pila buida");
        }

        public void controlarIndexEmpila()
        {
            if (EsPlena())
                throw new InvalidOperationException("Pila plena");
        }

        public bool EsPlena()
        {
            return this.apilonamentPila == this.arrayIntern.Length - 1;
        }

        public bool EsBuida()
        {
            return this.apilonamentPila == -1;
        }

        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();
            sr.Append('[');

            for (int i = apilonamentPila; i >= 0; i--)
            {
                sr.Append(arrayIntern[i]);
                if (i != 0)
                    sr.Append(',');
            }

            sr.Append(']');
            return sr.ToString();
        }

        public override bool Equals(object? obj)
        {
            int i = 0;
            bool iguals = false;

            if (obj is PilaGenerica<T> temp)
            {
                iguals = this.apilonamentPila == temp.apilonamentPila;

                if (iguals)
                {
                    while (iguals && i <= apilonamentPila)
                    {
                        iguals = Equals(this.arrayIntern[i], temp.arrayIntern[i]);
                        i++;
                    }
                }
            }

            return iguals;
        }

        //segon tipus d'implementacio (no fetch)
        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerador<T>(this.arrayIntern, this.apilonamentPila + 1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
