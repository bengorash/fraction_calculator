using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public partial class Program
    {
        public static readonly string _helpMessage = string.Format("Legal operators shall be *, /, +, -(multiply, divide, add, subtract){0}Operands and operators shall be separated by one or more spaces{0}Mixed numbers will be represented by whole_numerator/ denominator.e.g. 3_1 / 4{0}Improper fractions and whole numbers are also allowed as operands{0}{0}Example run:{0} 1/2 * 3_3/4{0} 1_7/8{0}{0} 2_3/8 + 9/8{0} 3_1/2{0}", "\n");

        public static void Main(string[] args)
        {
            ///
            //Write a command line program in the language of your choice (preferably Java or C#) 
            //that will take operations on fractions as an input and produce a fractional result.
            //
            //Legal operators shall be *, /, +, -(multiply, divide, add, subtract)
            //Operands and operators shall be separated by one or more spaces
            //Mixed numbers will be represented by whole_numerator/ denominator.e.g. "3_1/4"
            //
            //Improper fractions and whole numbers are also allowed as operands
            //Example run:
            //Example run:
            //? 1/2 * 3_3/4
            //= 1_7/8

            //? 2_3/8 + 9/8
            //= 3_1/2

            //show help message
            Console.WriteLine(_helpMessage);

            while (true)
            {
                var input = Console.ReadLine();

                try
                {
                    var output = CalculateOperations(input);
                    Console.WriteLine(output);
                    Console.WriteLine("\n");
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.WriteLine("Try again.");
                }
            }
        }


        public static string CalculateOperations(string input)
        {
            //split the input based on spaces
            var operations = input.Split(' ').ToList();
            
            //remove all extra spaces
            operations.RemoveAll(x => x == "");
            //incorrect entry, missing spaces 
            if (operations.Count < 3)
            {
                throw new Exception("Incorrect entry, please check your input for spaces in between the operator and the fraction");
            }
                //list of legal operators
            var LegalOperators = new char[] { '*', '/', '+', '-' };
            
            //loop through legal operators and perform calculations
            for (int i = 0; i < LegalOperators.Count(); i++)
            {
                //make sure there are enough fractions to perform a calculation
                if (operations.Count >= 3)
                {
                    var _operator = LegalOperators[i];

                    //get the index of the matching legal operator
                    var _operatorIndex = operations.IndexOf(_operator.ToString());

                    while (_operatorIndex != -1)
                    {
                        //get the left and right fractions to multiply, these would be before and after the operator
                        var leftString = operations[_operatorIndex - 1];
                        var rightString = operations[_operatorIndex + 1];

                        //validate left and right functions, returns a Mixed Object
                        var left = Validate(leftString);
                        var right = Validate(rightString);

                        switch (_operator.ToString())
                        {
                            //perform multiplication 
                            case "*":
                                operations[_operatorIndex] = Operations.Multiply(left, right);
                                break;

                            //perform divide
                            case "/":

                                operations[_operatorIndex] = Operations.Divide(left, right); ;
                                break;
                            //perform add
                            case "+":
                                operations[_operatorIndex] = Operations.Add(left, right); ;
                                break;
                            //perform subtract
                            case "-":
                                operations[_operatorIndex] = Operations.Subtract(left, right); ;
                                break;
                        }

                        //add result and remove fractions
                        operations.RemoveAt(_operatorIndex + 1);
                        operations.RemoveAt(_operatorIndex - 1);

                        _operatorIndex = operations.IndexOf(_operator.ToString());
                    }
                }
                if (operations.Count == 1)
                {
                    //return result if only one entry left
                    return operations[0];
                }
            }

            //couldn't find legal operators
            throw new Exception("Input didn't contain legal operators");


            //validates string value, expected value to include mixed fractions ("2_1/2") fractions ("1/2") and whole numbers ("2")
            MixedFraction Validate(string value)
            {
                if (value.Contains('/'))
                {
                    //if the value contains the character '_ 'it's expected to be a mixed number along with '/'
                    if (value.Contains('_'))
                    {
                        var stringFraction = value.Split('_');

                        //validate and create the mixed fraction
                        if (int.TryParse(stringFraction[0], out int wholeNumber))
                        {
                            //convert the fraction from the mixed fraction to a MixedFraction object
                            var mixedFraction = new MixedFraction(stringFraction[1])
                            {
                                //set the whole number
                                WholeNumber = wholeNumber
                            };
                            
                            return mixedFraction;
                        }
                        else
                        {
                            throw new Exception("illegal character - " + wholeNumber);
                        }
                    }
                    else
                    {
                        //expected to be a fraction
                        return new MixedFraction(value);
                    }
                }
                else
                {
                    //expected to be a whole number
                    if (int.TryParse(value, out int wholeNumber))
                    {
                        return new MixedFraction(wholeNumber);
                    }
                    else
                    {
                        throw new Exception("illegal character - " + wholeNumber);
                    }
                }
            }
        }
    }
}