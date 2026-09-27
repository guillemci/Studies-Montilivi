using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Enumerador<T> : IEnumerator<T>
    {
        private T[] elements;
        private int index;
        private int nElem;

        public Enumerador(T[] dades, int numElem)
        {
            this.elements = dades;
            this.nElem = numElem;
            this.index = numElem;
        }

        public bool MoveNext()
        {
            this.index--;
            return this.index >= 0;
        }

        public T Current
        {
            get { return this.elements[this.index]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Reset()
        {
            this.index = this.nElem;
        }

        public void Dispose()
        {
        }
    }
}
