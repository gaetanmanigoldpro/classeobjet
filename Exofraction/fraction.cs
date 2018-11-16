using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exofraction
{
    public class Fraction
    {

        private int numerateur;
        private int denominateur;


        //champs
        public int getNumerateur()
        {

            {
                return this.numerateur;
            }
        }

        public int getDenominateur()
        {

            {
                return this.denominateur;
            }
        }
        // constructeur
        public Fraction(int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;
        }

        public Fraction(int _denominateur)
        {
            this.denominateur = _denominateur;
        }
        public Fraction()
        {
            this.numerateur = 0;
            this.denominateur = 0;
        }
        // methode
        //public string AfficheFraction()
        //{

        //    if (this.numerateur != 0)
        //    {
        //        string chaine = getNumerateur() + "/" + getDenominateur();
        //        return chaine;
        //    }
        //    else
        //    {
        //        string chaine1 = "" + getDenominateur();
        //        return chaine1;
        //    }
        //}
        public Fraction fracop()
        {
            Fraction fracop = new Fraction(-getNumerateur(), getDenominateur());

            return fracop;
        }
        public Fraction Inverse()
        {
            Fraction inverse = new Fraction();
            int permute;
            permute = getNumerateur();
            this.numerateur = getDenominateur();
            this.denominateur = permute;
            inverse.numerateur = this.getNumerateur();
            inverse.denominateur = this.getDenominateur();
            return inverse;
        }
        //public string Affichefrac()
        //{
        //    string retour=getNumerateur()+","+getDenominateur();
        //    return retour;
        //}
        public bool Vrai(Fraction _f)
        {
            bool testc = true;
            if (testc = (getNumerateur() / getDenominateur()) > (_f.getNumerateur() / _f.getDenominateur()))
            {
                testc = true;
                return true;
            }
            else
            {
                testc = false;
                return testc;
            }
        }
        public bool egal(Fraction _f)
        {
            bool test = true;
            if (test = (getNumerateur() / getDenominateur()) > (_f.getNumerateur() / _f.getDenominateur()))
            {
                test = true;
                return test;
            }
            else
            {
                return !test;
            }
        }
        public int Pgcd()
        {

            int a = numerateur;
            int b = denominateur;

            int pgcd = 1;

            if (a != 0 && b != 0)
            {
                if (a < 0)
                {
                    a = -a;
                }
                if (b < 0)
                {
                    b = -b;
                }
                while (a != b)
                {
                    if (a < b)
                    {
                        b -= a;
                    }
                    else
                    {
                        a -= b;
                    }
                }
                pgcd = a;
            }
           return (pgcd);
        }

    }
}












