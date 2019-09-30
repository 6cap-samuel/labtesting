using System;

namespace Tests
{
    public class Calculator
    {
        public Calculator() { }

        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;
            // Default value// Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                    // Return text for an incorrect option entry.default:break
            }
            return result;
        }

        public double Add(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
                return 666;

            if (num1 == 0)
                return this.Divide(num2, 10);

            if (num2 == 0)
                return this.Multiply(num1, 10);

            return (num1 + num2);
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
                return 1;

            if (num1 == 0)
                return 0;

            return (num1 / num2);
        }

        public double Factorial(double num)
        {
            if (num == 1)
            {
                return 1;
            } else
            {
                return Factorial(num - 1) * num;
            }
        }

        public double UnknownFunctionA(double num1, double num2)
        {

            double difference = num1 - num2;
            if (difference < 0)
            {
                throw new ArgumentException();
            }

            if (difference != 0)
            {
                return Divide(Divide(Factorial(num1), Factorial(num2)), difference);
            }
            else
            {
                return Divide(Factorial(num1), Factorial(num2));
            }
        }

        public double UnknownFunctionB(double num1, double num2)
        {
            if (num1 == num2)
            {
                return Factorial(num1);
            }
            else
            {
                double diff = num1 - num2;
                if (diff < 0)
                {
                    throw new ArgumentException();
                }

                return Divide(Factorial(num1), diff);
            }
        }

        public double MTBF(double MTTF, double MTTR)
        {
            return Add(MTTF, MTTR);
        }

        public double systemAvailability(double MTBF, double MTTR)
        {
            return Subtract(MTBF, MTTR);
        }

    }   
}
