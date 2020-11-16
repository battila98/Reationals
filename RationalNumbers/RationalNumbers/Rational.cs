using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    struct Rational
    {
        int numerator;       // számláló
        int denominator;      // nevező
        public int getNumerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                if (numerator == 0)
                {
                    throw new System.InvalidOperationException("Nullával nem osztunk, heh!");
                }
            }
        }
        public int getDenominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (denominator == 0)
                {
                    throw new System.InvalidOperationException("Nullával nem osztunk, heh!");
                }
            }
        }
        
    }
}
