using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    struct Rational : IComparable<Rational>, IEquatable<Rational>
    {
        private int numerator;       // számláló
        private int denominator;     // nevező -> alsó lol

        public Rational(int numerator, int denominator)
        {

            if (denominator == 0)
            {
                throw new System.InvalidOperationException("Nullával nem osztunk, heh!");
            }

            int gcd = Gcd(numerator, denominator);
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;
        }
        public static Rational operator +(Rational x, Rational y)
        {
            return new Rational(x.numerator * y.denominator + y.numerator * x.denominator, x.denominator * y.denominator);
        }
        public static Rational operator -(Rational x, Rational y)
        {
            return new Rational(x.numerator * y.denominator - y.numerator * x.denominator, x.denominator * y.denominator);
        }
        public static Rational operator *(Rational x, Rational y)
        {
            return new Rational(x.numerator * y.numerator, x.denominator * y.denominator);
        }
        public static Rational operator /(Rational x, Rational y) //buzi
        {
            return x * new Rational(y.denominator, y.numerator);
        }
        public static bool operator ==(Rational x, Rational y)
        {
            return x.Equals(y);
        }
        public static bool operator !=(Rational x, Rational y) // ==-t kell így is definiálni, mert csak (tudni mi van ha nem ==)
        {
            return !(x == y);
        }
        private static int Gcd(int x, int y) => y == 0 ? x : Gcd(y, x % y);

        public int CompareTo(Rational other) // ha a bal oldal < mint OTHER akkor -1; Ha == akkor 0; Ha nagyobb akkor 1;
        {
            /*if (this.Equals(other))
            {
                return 0;
            }
            else if ()
            {

            }
            else
            {

            }*/
            throw new NotImplementedException();
        }

        public bool Equals(Rational other)
        {
            return this.numerator == other.numerator && this.denominator == other.denominator; //boolean 
        }

        public override string ToString() => denominator == 1 ? $"{numerator}" : $"{numerator} / {denominator}"; // metódus név => if ... ? (akkor)... : (else) ...
    }
}
