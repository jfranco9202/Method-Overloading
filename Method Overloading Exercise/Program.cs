using System;

namespace Method_Overloading_Exercise
{
    class Program
    {
        public static int Add(int x, int y)
        {
            return (x + y);
        }

        public static decimal Add(decimal numx, decimal numy)
        {
            return (numx + numy);
        }

        public static string Add(int x, int y, bool isCheck)
        {
            var sum = x + y;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }

            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }

            static void Main(string[] args)
            {
                var x = 40;
                var y = 15;

                var answer = Add(x, y);

                var a = 20.5m;
                var b = 30.6m;

                var decimalAnswer = Add(a, b);

                var thirdAnswer = Add(0, 0, true);

                Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
                Console.WriteLine(thirdAnswer);
            }



        }
    }

}