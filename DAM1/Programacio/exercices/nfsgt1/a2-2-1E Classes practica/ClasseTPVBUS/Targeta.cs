using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseTPVBUS
{
    internal class Targeta
    {
        private double preuUnitari;
        private double saldo;
        private int numeroT;
        private static int NumTargetes = 0;

        public Targeta(double preuUnitari) : this (preuUnitari, 0) { }


        public Targeta(double preuUnitari, double saldo)
        {
            this.saldo = saldo;
            this.preuUnitari = preuUnitari;
            NumTargetes++;
            this.numeroT = NumTargetes;
        }

        public int Viatges
        {
            get { return (int)(saldo / preuUnitari); }
        }

        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        public double PreuUnitari
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        public int Numero
        {
            get { return this.numeroT; }
        }

        public bool Marcar()
        {
            bool condicio = false;

            if (this.saldo >= this.preuUnitari)
            {
                this.saldo -= preuUnitari;
                condicio = true;
            }

            return condicio;
        }

        public void Recarregar(double import)
        {
            this.saldo += import;
        }

        public void FusionarSaldos(Targeta t2)
        {

        }

        public static bool Major(Targeta t1, Targeta t2)
        {
            return t1.saldo > t2.saldo;
        }

        public static Targeta FusionarSaldos(Targeta t1, Targeta t2)
        {

        }

        public override string ToString()
        {
            return $"Saldo de la targeta: {this.saldo}\n Preu Unitari de la targeta: {this.preuUnitari}\n numero targeta: {this.numeroT}";
        }

        public override bool Equals(object obj)
        {

            bool valorBool = false;

            if (obj is Targeta other)
                valorBool = this.Saldo == other.Saldo;

            return valorBool;
        }
    }
}
