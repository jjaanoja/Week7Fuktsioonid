using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene arv");
            int userNumber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv");
            int userNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe (sisesta: + - / * )");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumber1, userNumber2);
                    break;
                case '/':
                    DivideTwoNumbers(userNumber1, userNumber2);
                    break;


                case '-':
                    SubtractTwoNumbers(userNumber1, userNumber2);
                    break;
                case '*':
                    MultiplyTwoNumbers(userNumber1, userNumber2);
                    break;

                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

        }

        public static void AddTwoNumbers(double x, double y)
        {
            double result = x + y;
            Console.WriteLine(result);
        }
        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }




        public static void SubtractTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine(result);
        }
        public static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }
        
    }
}
