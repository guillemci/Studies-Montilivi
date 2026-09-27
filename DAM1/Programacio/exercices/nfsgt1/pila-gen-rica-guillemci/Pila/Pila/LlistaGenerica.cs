using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class LlistaGenerica<T>
    {
        private const int CAPACITAT_INICIAL = 4;
        private int nElementsLlista;
        private T[] arrayIntern;

        public LlistaGenerica()
        {
            this.arrayIntern = new T[CAPACITAT_INICIAL];
            this.nElementsLlista = 0;
        }
        public LlistaGenerica(int longitud)
        {
            this.arrayIntern = new T[longitud];
            this.nElementsLlista = 0;
        }

        public int Capacitat { get { return this.arrayIntern.Length; } }
        public int Count { get { return this.nElementsLlista; } }
        public T this[int index]
        {
            get { return Obtenir(index); }
            set { Asignar(value, index); }
        }

        public void buidar()
        {
            for (int i = 0; i < this.nElementsLlista; i++)
                this.arrayIntern[i] = default(T);
        }

        public void controlarIndex(int index)
        {
            if (index >= nElementsLlista || index < 0)
                throw new ArgumentOutOfRangeException("index");
        }

        private T Obtenir(int index)
        {
            controlarIndex(index);
            return this.arrayIntern[index];
        }

        private void Asignar(T valor, int index)
        {
            controlarIndex(index);
            this.arrayIntern[index] = valor;
        }

        public void Afegir(T valor)
        {
            this.nElementsLlista++;
            if (this.nElementsLlista >= this.arrayIntern.Length)
                RedimensionarAAdalt();

            Asignar(valor, this.nElementsLlista - 1);
        }

        public void RedimensionarAAdalt()
        {
            int novaTaulaLongitud = this.arrayIntern.Length * 2;
            T[] novaTaula = new T[novaTaulaLongitud];
            for (int i = 0; i < arrayIntern.Length; i++)
                novaTaula[i] = this.arrayIntern[i];

            this.arrayIntern = novaTaula;
        }

        public void Eliminar(T elementEliminar)
        {
            bool trovat = false;
            int index = 0;
            int i = 0;

            while (i < this.nElementsLlista && !trovat)
            {
                trovat = elementEliminar.Equals(this.arrayIntern[i]);
                index = i;
                i++;
            }

            if (trovat)
            {
                this.arrayIntern[index] = default;
                this.nElementsLlista--;
                Desplaçar(index);
            }
        }

        public void EliminarAPosicio(int index)
        {
            this.arrayIntern[index] = default;
            this.nElementsLlista--;
            Desplaçar(index);
        }



        public void Desplaçar(int index)
        {
            int j = index;

            while (j < this.nElementsLlista)
            {
                this.arrayIntern[j] = this.arrayIntern[j + 1];
                this.arrayIntern[j + 1] = default;
                j++;
            }
        }
    }
}
