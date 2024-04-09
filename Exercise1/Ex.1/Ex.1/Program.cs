namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Въведете число");
            //int num = int.Parse(Console.ReadLine());

            //int sum = 0;
            //for (int i = 0; i <= num; i++) 
            //{
            //    sum += i;               
            //}
            //Console.WriteLine("Сумата е: " + sum);


            //задача 2
            //Console.WriteLine("Enter number");
            //var number = int.Parse(Console.ReadLine());
            //var isPrime = true;

            //for (int i = 2; i <= Math.Sqrt(number); i++)
            //{
            //    if (number % i ==0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}
            //if (isPrime)
            //    Console.WriteLine("True");
            //else Console.WriteLine("False");

            //задача 3
            //Console.WriteLine("Enter array");
            //string[] input = Console.ReadLine().Split(",");
            //decimal result = 0;
            //for (int i = 0; i < input.Length; i++) 
            //{
            //    result += Decimal.Parse(input[i]);

            //}
            //Console.WriteLine("The sum is " + result);

            //задача 4 

            Console.WriteLine("Enter euro array");
            var euroInput = Console.ReadLine().Split(",");

            Console.WriteLine("Enter usd array");
            var usdInput = Console.ReadLine().Split(",");

            var euroToLv = new decimal[euroInput.Length];
            var usdToLv = new decimal[usdInput.Length];

            for (int i = 0; i < euroInput.Length; i++)
            {
                euroToLv[i] = Decimal.Parse(euroInput[i]) * 1.95m;
            }

            for (int i = 0;i < usdInput.Length; i++)
            {
                usdToLv[i] = Decimal.Parse(usdInput[i]) * 1.8m;
            }

            var areEqual = true;
            if(euroToLv.Length == usdToLv.Length)
            {
                for (int i = 0; i<euroToLv.Length; i++) 
                {
                    if (euroToLv[i] != usdToLv[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }
            else
            {
                areEqual = false;
            }
            Console.WriteLine("Equal: " + areEqual);

        }
    }
}