using System;
using System.IO;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            try { 
            String filePath = "words.txt";
            String input = "hello";
                UserInput();
                Console.WriteLine("***********************************************");
                int[] arr = {1,2,3,4,5}; 
                Avg(arr);
                Console.WriteLine("***********************************************");
                Diamond();
                Console.WriteLine("***********************************************");
                int[] arr1 = { 9, 2, 3, 4, 5 };
                mostFrequent(arr1);
                Console.WriteLine("***********************************************");
                int[] arr2 = { 5, 25, 99, 123, 78, 96, 555, 108, 4};
                Max(arr2);
                Console.WriteLine("***********************************************");
                SaveTOFile(filePath,input);
                Console.WriteLine("***********************************************");
                ReadFromFile(filePath,input);
                Console.WriteLine("***********************************************");
                DeletFromFile(filePath);
                Console.WriteLine("***********************************************");
                Words();
        }
                catch (Exception e)
            {
                Console.WriteLine("Something error happened" + e.Message);
            }
        }
        // challenge 1
        public static void UserInput()
        {
            Console.WriteLine("Please enter 3 numbers, add space between each number");
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine("The product of these 3 numbers are: " + Product(input));
        }
        public static int Product(string[] input)
        {
            int product = 1;
            if (input.Length < 3)
                return 0;
            if (input.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    product *= Convert.ToInt32(input[i]);
                }
            }
                return product;
        }
        // challenge 2
        public static double Avg(int[] numbers)
        {
            int sum = 0;
            Console.WriteLine("Please enter a number between 2 - 10:");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input < 2 || input > 10)
            {
                Console.Write("Please enter a number between 2 - 10: \n");
                input = Convert.ToInt32(Console.ReadLine());
            }
            numbers = new int[input];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} of " + numbers.Length + " - Enter a number: ", i + 1);
                if (Int32.TryParse(Console.ReadLine(), out input))
                {
                    numbers[i] = input;
                    sum += numbers[i];
                }
                if (input < 0)
                {
                    Console.WriteLine("Please enter positive numbers");
                    i--;
                }
            }
            double avg = (double)sum / (double)numbers.Length;
            Console.WriteLine("The average of these " + numbers.Length + " numbers are: " + avg);
            return avg;
        }

        // challenge 3
        public static void Diamond()
        {
            int r = 5,i,j;
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
        // challenge 4
        public static int mostFrequent(int[]arr)
        {
            int res = arr[0];
            int curr_count = 1;

            for (int i = 1; i < arr.Length; i++) // picks all elements one by one.
            {
                if (arr[i] == arr[i - 1])
                    curr_count++; // if number have multiple occurences
                else
                {
                    curr_count = 1; // if number have one occurence  
                }
            }
            Console.WriteLine("Most Frequent Number is: " +res);
            return res; 
        }
        // challeng 5
        public static int Max(int[] arr)
        {
            int max = arr[0]; 
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max Value in Array : " + max);
            return max;
        }
        // challenge 6 
      public  static void SaveTOFile(String filePath, String input)
        {
            Console.WriteLine("Please input a word:");
            input = Console.ReadLine();
            {
                if (File.Exists(filePath))
                { 
                    File.AppendAllText(filePath, input + Environment.NewLine);
                }
            }
        }
        // challenge 7
        public static void ReadFromFile(String filePath, String input)
        {
            String path = "words.txt";
            String[] fileContent = File.ReadAllLines(path);
            for (int i = 0; i < fileContent.Length; i++)
                Console.WriteLine(fileContent[i]);
        }
        // challenge 8 
        public static void DeletFromFile(string path)
        {
            string str = File.ReadAllText(path);
            string last = str.Substring(0, str.LastIndexOf(' ')).TrimEnd();
            Console.WriteLine(last);
        }
        // challenge 9 
        public static void Words()
        {
            Console.WriteLine("Please enter a sentence:");
            string text = Console.ReadLine();
            WordsCount(text);
        }
        public static string[] WordsCount(string text)
        {
            string[] arr = text.Split(' ');
            string[] words = new string[text.Length];
            foreach (string s in arr)
                Console.WriteLine("[" + s + ":" + s.Length + "],");
            return words;
        }
    }
    }
