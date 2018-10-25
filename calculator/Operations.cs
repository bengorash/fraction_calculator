namespace calculator
{
    public partial class Program
    {
        //math operations supported are multiply, divice, add, subtract
        public static class Operations
        {
            //multiply two fractions that may also be mixed fractions
            public static string Multiply(MixedFraction left, MixedFraction right)
            {
                //multiply the fraction
                var final = new MixedFraction()
                {
                    Numerator = left.Numerator * right.Numerator,
                    Denominator = left.Denominator * right.Denominator,
                    WholeNumber = left.WholeNumber * right.WholeNumber
                };

                return ConvertFractionToString(final);
            }

            //Divide two fractions that may also be mixed fractions
            public static string Divide(MixedFraction left, MixedFraction right)
            {
                //Divide the fraction
                var final = new MixedFraction()
                {
                    Numerator = left.Numerator * right.Denominator,
                    Denominator = left.Denominator * right.Numerator,
                    WholeNumber = left.WholeNumber * right.WholeNumber
                };

                return ConvertFractionToString(final);
            }

            //Add two fractions that may also be mixed fractions
            public static string Add(MixedFraction left, MixedFraction right)
            {
                //Add the fraction 
                var final = new MixedFraction()
                {
                    Numerator = (left.Numerator * right.Denominator) + (left.Denominator * right.Numerator),
                    Denominator = left.Denominator * right.Denominator,
                    WholeNumber = left.WholeNumber + right.WholeNumber
                };

                return ConvertFractionToString(final);
            }

            //Subtract two fractions that may also be mixed fractions
            public static string Subtract(MixedFraction left, MixedFraction right)
            {
                //Subtract the fraction
                var final = new MixedFraction()
                {
                    Numerator = (left.Numerator * right.Denominator) - (left.Denominator * right.Numerator),
                    Denominator = left.Denominator * right.Denominator,
                    WholeNumber = left.WholeNumber - right.WholeNumber
                };
                return ConvertFractionToString(final);
            }

            //convert fraction to string output
            private static string ConvertFractionToString(MixedFraction fraction)
            {
                //whole number doesn't exist, expecting a fraction
                if (fraction.WholeNumber <= 0)
                {
                    //if denominator is 1 or 0 then the numerator is a whole number
                    if (fraction.Denominator <= 1)
                    {
                        return fraction.Numerator.ToString();
                    }

                    //if improper fraction convert to mixed fraction
                    if (fraction.Numerator > fraction.Denominator)
                    {
                        //get whole number
                        var wholeNumber = (int)(fraction.Numerator / fraction.Denominator);

                        //get remainder
                        var remainder = fraction.Numerator % fraction.Denominator;

                        fraction.WholeNumber = wholeNumber;
                        fraction.Numerator = remainder;

                        if (remainder == 0)
                        {
                            return fraction.WholeNumber.ToString();
                        }

                        fraction.ReduceFraction(fraction.Numerator, fraction.Denominator);

                        return fraction.WholeNumber.ToString() + "_" + fraction.Numerator + "/" + fraction.Denominator;
                    }

                    //expected fraction
                    //reduce the fraction
                    fraction.ReduceFraction(fraction.Numerator, fraction.Denominator);
                    return fraction.Numerator + "/" + fraction.Denominator;
                }
                //expected to contain a whole number, return it
                else
                {
                    return fraction.WholeNumber.ToString();
                }

            }

        }
    }
}