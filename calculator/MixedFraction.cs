using System;

namespace calculator
{
    public partial class Program
    {
        public class MixedFraction
        {
            public int WholeNumber { get; set; } = 0;
            public int Numerator { get; set; }
            public int Denominator { get; set; }

            public MixedFraction()
            {

            }

            //expected to be a whole number, return whole number
            public MixedFraction(int number)
            {
                WholeNumber = number;
            }

            //creates MixedFraction object from a string fraction ("1/2") or mixed fraction ("2_1/2")
            public MixedFraction(string fraction)
            {
                //get fraction
                var f = fraction.Split('/');
                if (int.TryParse(f[0], out int numerator) && int.TryParse(f[1], out int denominator))
                {
                    //set numerator and denominator
                    Numerator = numerator;
                    Denominator = denominator;
                }
                else
                {
                    throw new Exception("illegal character - " + fraction);
                }
            }

            //convert mixed fraction to an improper fraction
            public MixedFraction ConvertMixedFractionToImproperFraction()
            {
                //mixed fraction
                if (WholeNumber > 0)
                {
                    //whole number
                    if (Numerator == 0 || Denominator == 0)
                    {
                        Numerator = WholeNumber;
                        Denominator = 1;
                        WholeNumber = 0;
                        return this;
                    }

                    //mixed fraction
                    Numerator = Denominator * WholeNumber + Numerator;
                    Denominator = Denominator;
                    WholeNumber = 0;
                }

                return ReduceFraction(Numerator, Denominator);
            }

            //reduces the fraction down
            public MixedFraction ReduceFraction(int numerator, int denominator)
            {
                var n = Math.Abs(numerator);
                var d = Math.Abs(denominator);

                //get greatest common denominator
                while (n != d)
                    if (n < d) d = d - n;
                    else n = n - d;

                //greatest common denominator
                var gcd = n;

                if (gcd > 0)
                {
                    //return fraction after dividing the numerator and denominator by the greatest common denominator
                    Numerator = Numerator / gcd;
                    Denominator = Denominator / gcd;

                    return this;
                }
                else
                {
                    return new MixedFraction
                    {
                        WholeNumber = WholeNumber
                    };
                }
                
            }
        }
    }
}