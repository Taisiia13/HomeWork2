using System;

namespace HomeWork2
{
    class Program
    {
        static double number1(double A, double B)
        {
            if (A == B)
            {
                return A * B;
            }
            if (A > B)
            {
                return A + B; 
            }
            else 
            {
               return A - B; 
            }
        }

        static string CoordinateGuarter(double X, double Y)
        {
            if (X > 0 && Y > 0)
            { 
                return "1";
            } 
            else if (X < 0 && Y > 0)
            { 
                return "2"; 
            }
            else if  (X < 0 && Y < 0)
            { 
                return "3"; 
            }
            else if (X > 0 && Y < 0)
            { 
                return "4";
            }
            else 
            { 
                return "Point to lie on the axis"; 
            }
        }

        static string Comparison(double a, double b, double c)
        {
            if (a > c && c > b)
                return $"{b},{c},{a}";

            if (a > b && b > c)
                return $"{c},{b},{a}";

            if (c > b && b > a)
                return $"{a},{b},{c}";

            if (c > a && a > b)
                return $"{b},{a},{c}";

            if (b > a && a > c)
                return $"{c},{a},{b}";

            if (b > c && c > a)
                return $"{a},{c},{b}";

            return "no result";
        }

        static string discriminant(double a, double b, double c)
        {
            double d = Math.Pow(b ,2) - 4 * a * c;
            if (d > 0 || d == 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return $"X1={x1}  X2={x2}";
            }
            if(d<0)
                return "There is no root equation";

            return "";           
        }          

        static string PrintStringNumber(int a)
        {
            int first = a / 10;
            var second = a % 10;
            var result = string.Empty;

            switch (first)
            {
                case 1: 
                    switch (second)
                    {
                        case 1: result = "ten";
                            break;
                        case 2:
                            result = "eleven";
                            break;
                        case 3:
                            result = "twelve";
                            break;
                        case 4:
                            result = "thirteen";
                            break;
                        case 5:
                            result = "fourteen";
                            break;
                        case 6:
                            result = "fifteen";
                            break;
                        case 7:
                            result = "sixteen";
                            break;
                        case 8:
                            result = "seventeen";
                            break;
                        case 9:
                            result = "eighteen";
                            break;
                        case 10:
                            result = "nineteen";
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    result = "twenty";
                    break;
                case 3:
                    result = "thirty";
                    break;
                case 4:
                    result = "forty";
                    break;
                case 5:
                    result = "fifty";
                    break;
                case 6:
                    result = "sixty";
                    break;
                case 7:
                    result = "seventy";
                    break;
                case 8:
                    result = "eighty";
                    break;
                case 9:
                    result = "ninety";
                    break;
                default:
                    break;
            }

            switch (second)
            {
                case 1:
                    result += " one";
                    break;
                case 2:
                    result += " two";  
                    break;
                case 3:
                    result += " three";
                    break;
                case 4:
                    result += " four";
                    break;
                case 5:
                    result += " five";
                    break;
                case 6:
                    result += " six";
                    break;
                case 7:
                    result += " seven";
                    break;
                case 8:
                    result += " eight";
                    break;
                case 9:
                    result += " nine";
                    break;
                default:
                    break;
            }

            return result;
        }

        static void Main()
        {

            //Console.WriteLine(number1(2,3));

            //Console.WriteLine(CoordinateGuarter(2,3));

            //Console.WriteLine(Comparison(2,3,8));

            Console.WriteLine(discriminant(5, 6, 8));

            //Console.WriteLine(PrintStringNumber(36));


        }
    }

}

