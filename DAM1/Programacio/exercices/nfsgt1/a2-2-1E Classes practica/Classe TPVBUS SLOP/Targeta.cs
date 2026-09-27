using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_TPVBUS
{
    internal class Targeta
    {
        private double preuUnitari;
        private double saldo;
        private int numero;
        private static int numTargetes = 0;

        public Targeta(double preuUnitari, double saldo)
        {
            this.preuUnitari = preuUnitari;
            this.saldo = saldo;
            numTargetes++;
            this.numero = numTargetes;
        }

        public Targeta(double preuUnitari) : this(preuUnitari, 0) { }

        public int Viatges
        {
            get { return (int)(this.saldo / this.preuUnitari); }
        }

        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        public double PreuUnitari
        {
            get { return this.preuUnitari; }
            set { this.preuUnitari = value; }
        }

        public int Numero
        {
            get { return this.numero; }
        }

        public bool Marcar()
        {
            bool returnar = false;
            if (this.saldo >= this.preuUnitari)
            {
                this.saldo -= this.preuUnitari;
                returnar = true;
            }
            return returnar;
        }

        public void Recarregar(double recarga)
        {
            this.saldo += recarga;
        }

        public void FusionarSaldos(Targeta t2)
        {
            this.saldo += t2.saldo;
            t2.saldo = 0;
            if (t2.preuUnitari > this.preuUnitari)
                this.preuUnitari = t2.preuUnitari;
        }

        public static bool Major(Targeta primera, Targeta segona)
        {
            return primera.saldo > segona.saldo;
        }

        public static Targeta FusionarSaldos(Targeta t1, Targeta t2)
        {
            double saldoTotal = t1.saldo + t2.saldo;
            double preuFinal;

            if (t1.preuUnitari > t2.preuUnitari)
                preuFinal = t1.preuUnitari;
            else
                preuFinal = t2.preuUnitari;
            t1.saldo = 0;
            t2.saldo = 0;
            return new Targeta(preuFinal, saldoTotal);
        }

        public override string ToString()
        {
            return ($"Targeta {this.numero} Saldo: {this.saldo}€ | Preu/viatge: {this.preuUnitari}€ Viatges: {this.Viatges}");
        }
    }
}
