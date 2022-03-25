using System;
using System.IO;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
             String filePath = "words.txt";
            String input = "hello";
                UserInput();
                Console.WriteLine("***********************************************");
                UserInputAvg();
                Console.WriteLine("***********************************************");
                Diamond();
                Console.WriteLine("***********************************************");
                int[] arr1 = { 9, 2, 3, 4, 5, 9 };
                Console.WriteLine();
                Console.WriteLine("Most Frequent Number is: " + mostFrequent(arr1));
                Console.WriteLine("***********************************************");
                int[] arr2 = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Max Value in Array : " + Max(arr2));
                Console.WriteLine("***********************************************");
                SaveTOFile(filePath, input);
                Console.WriteLine("***********************************************");
                ReadFromFile(filePath, input);
                Console.WriteLine("***********************************************");
                DeletFromFile(filePath);
                Console.WriteLine("***********************************************");
                WordsCount(Words());
            }
            catch (Exception e)
            {
                Console.WriteLine("Something error happened " + e.Message);
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
        public static int Avg(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int avg = sum / arr.Length;
            Console.WriteLine("The average of these " + arr.Length + " numbers are: " + avg);
            return avg;
        }
        public static int UserInputAvg()
        {
                Console.WriteLine("Please enter a number between 2 - 10:");
                int input;
                while (!Int32.TryParse(Console.ReadLine(), out input)) //for empty user inputs 
                {
                    Console.Write("Please enter a number between 2 - 10: \n");
                }
                while (input < 2 || input > 10)
                {
                    Console.Write("Please enter a number between 2 - 10: \n");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                int[] numbers = new int[input];
                int res;
                for (int i = 0; i < numbers.Length; i++)
                {
                Console.Write("{0} of " + input + " - Enter a number: ", i + 1);
                while (!Int32.TryParse(Console.ReadLine(), out res) || res < 0 ) // for empty user's input
                    {
                        Console.WriteLine("please enter positive numbers only");
                        Console.Write(i + 1 + " of " + input + " - Enter a number: ");
                    }
                numbers[i] = res;
            }
            return Avg(numbers);
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
            try
            {
                String path = "words.txt";
                String[] fileContent = File.ReadAllLines(path);
                for (int i = 0; i < fileContent.Length; i++)
                    Console.WriteLine(fileContent[i]);
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine("Message: " + e.Message);
            }
        }
        // challenge 8 
        public static void DeletFromFile(string path)
        {
            string str = File.ReadAllText(path);
            string last = str.Substring(0, str.LastIndexOf(' ')).TrimEnd();
            Console.WriteLine(last);
        }
        // challenge 9 
        public static string Words()
        {
            Console.WriteLine("please enter a sentence ");
            string text = Console.ReadLine();
            return text;
        }
        public static string[] WordsCount(string text)
        {
            string[] sentence = text.Split(" ");
            string[] str = new string[sentence.Length];
            for (int i = 0; i < sentence.Length; i++)
            {
                str[i] = $"{sentence[i]}:{sentence[i].Length},";
                Console.Write(str[i]);
            }
            return str;
        }
    }
    }
