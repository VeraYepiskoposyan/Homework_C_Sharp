/*namespace Homework._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a temperature");

            int t = Convert.ToInt32(Console.ReadLine());

            if(t >= 0 && t <= 10)
            {
                Console.WriteLine("Weather is cold");
            }

            else if (t > 10 && t <= 30) {
                Console.WriteLine("Weather is warm");
            }

            else if(t >= 30)
            {
                Console.WriteLine("Weather is hot");
            }

            else if(t < 0)
            {
                Console.WriteLine("Freezing weather");
            }
        }
    }
}
*/

/*namespace Homework._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a <= 13)
            {
                Console.WriteLine("You are a child");
            }

            else if (a > 13 && a <= 19)
            {
                Console.WriteLine("You are a teenager");
            }

            else if (a > 19)
            {
                Console.WriteLine("You are an adult");
            }
        }
    }
}*/

/*namespace Homework._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 8, 18 };

            int max = arr[0];
            int min = arr[0];

            for(int i  = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine($"Maximum element is " + max);
            Console.WriteLine($"Minimum element is " + min);

        }
    }
}
*/

/*namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 6, 8 };
            Array.Reverse(array);

            Console.WriteLine(String.Join(',', array));

        }
    }
}
*/
/*
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose temperature scale F or C");
            string tempScale = Console.ReadLine();

            if(tempScale != null)
            {
                Console.WriteLine("Please enter the temperature for converting");

                int t = Convert.ToInt32(Console.ReadLine());
                int convertedValue;

                if (tempScale[0] == 'F')
                {
                    convertedValue = (t - 32) * 5 / 9;
                }
                else
                {
                    convertedValue = t * 9 / 5 + 32;
                }

                Console.WriteLine(convertedValue);
            }

           
        }
    }
}*/

/*namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 6, 5, 8, 9, 24 };

            Array.Sort(arr);
            Array.Reverse(arr);

            int secondLargest = arr[1];
            Console.WriteLine("Second largest element " + secondLargest);
        }
    }
}
*/

/*namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 6, 5, 8, 9 };
            int[] arr2 = { 1, 8, 6, 9,25 };

            int[] sumArray = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                sumArray[i] = arr1[i] + arr2[i];
            }

            Console.WriteLine("Sum Array " + string.Join(", ", sumArray));
        }


        }
    }*/

