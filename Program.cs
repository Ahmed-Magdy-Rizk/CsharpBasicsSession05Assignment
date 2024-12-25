using System.ComponentModel.DataAnnotations;

namespace Session05Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // 1- Write a program that prints an identity matrix using for loop,
            // in other words takes a value n from the user and shows the identity table of size n * n.

            // prompt user to enter a n value
            /*Console.WriteLine("Please enter your matrix size: ");
            int.TryParse(Console.ReadLine(), out int n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }*/
            #endregion
            #region Q2
            // 2- Write a program in C# Sharp to find the sum of all elements of the array.
            /*int[] TestArr = { 1, 2, 3 };

            int sum = 0;
            for (int i = 0; i < TestArr.Length; i++)
            {
                sum += TestArr[i];
            }
            Console.WriteLine(sum);*/
            #endregion
            #region Q3
            // 3-Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            /*Console.Write("Please enter the size of your array: ");
            int.TryParse(Console.ReadLine(), out int ArrLength);

            int[] arr1 = new int[ArrLength];
            int[] arr2 = new int[ArrLength];

            
            for (int i = 0; i < arr1.Length;)
            {
                Console.Write($"Please Enter the {i + 1} value of your first array : ");
                i = int.TryParse(Console.ReadLine(), out arr1[i]) ? ++i : i;
            }
            
            for (int i = 0; i < arr2.Length;)
            {
                Console.Write($"Please Enter the {i + 1} value of your second array : ");
                i = int.TryParse(Console.ReadLine(), out arr2[i]) ? ++i : i;
            }


            int[] MergedArray = new int[ArrLength * 2];

            Array.Copy(arr1, MergedArray, arr1.Length);
            Array.ConstrainedCopy(arr2, 0, MergedArray, arr1.Length, arr2.Length);

            Array.Sort(MergedArray);

            for (int i = 0; i < MergedArray.Length; i++)
            {
                Console.WriteLine(MergedArray[i]);
            }
            */
            #endregion
            #region Q4
            // 4- Write a program in C# Sharp to count the frequency of each element of an array.
            /*int[] TestArray = { 3, 2, 2, 1, 1, 1};
            Array.Sort(TestArray);

            int frequency;

            for (int i = 0; i < TestArray.Length; i++)
            {
                frequency = 1;

                if (i > 0 && TestArray[i] == TestArray[i - 1])
                {
                    continue;
                }

                for (int j = i + 1; j < TestArray.Length; j++)
                {
                    if (TestArray[i] == TestArray[j])
                    {
                        frequency++;
                    }
                }
                Console.WriteLine($"The frequency of {TestArray[i]} is : {frequency}");

            }*/
            #endregion
            #region Q5
            // 5- Write a program in C# Sharp to find maximum and minimum element in an array
            /*int[] arr = { 1, 10, 3, 8, 5, 8, 7, 8, 9, 10 };

            Array.Sort(arr);

            Console.WriteLine($"Mximum value is: {arr[arr.Length-1]}");
            Console.WriteLine($"Minimum value is: {arr[0]}");*/
            #endregion
            #region Q6
            // 6-Write a program in C# Sharp to find the second largest element in an array.
            /*int[] arr = { 1, 9, 3, 8, 5, 8, 7, 8, -5, 10};

            Array.Sort(arr);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] <  arr[arr.Length - 1])
                {
                    Console.WriteLine($"Second largest element is: {arr[i]}");
                    break;
                }
            }*/
            #endregion
            #region Q7
            // Consider an Array of Integer values with size N, having values as  in this Example
            //int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

            // Prompt user to enter the size of the array
            /*Console.Write("Please enter the size of your array: ");
            int.TryParse(Console.ReadLine(), out int size);

            // decalre an ints array with the user's size array
            int[] arr = new int[size];

            // prompt usser to enter the values of the array
            for (int i = 0; i < arr.Length;)
            {
                Console.Write($"Please enter the {i+1}th element of your array: ");
                i = int.TryParse(Console.ReadLine(), out arr[i]) ? ++i : i;
            }

            //
            int FirstOccurance = 0;
            int LastOccurance = 0;
            int Distance = 0;
            int OrderOfTheFirstCell = 0;
            int OrderOfTheLastCell = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    FirstOccurance = Array.IndexOf(arr, arr[i]);
                    LastOccurance = Array.LastIndexOf(arr, arr[i]);
                    if (LastOccurance - FirstOccurance > Distance)
                    {
                        Distance = LastOccurance - FirstOccurance;
                        OrderOfTheFirstCell = FirstOccurance;
                        OrderOfTheLastCell = LastOccurance;
                        break;
                    }
                }
            }
            Console.WriteLine($"the longest distance is between the {OrderOfTheFirstCell + 1}th cell and the\r\n{OrderOfTheLastCell + 1}th cell with the value of {arr[OrderOfTheFirstCell]}, with a distance of {Distance-1} cells\r\n");
            */
            #endregion
            #region Q9
            // 9-	Given a list of space separated words, reverse the order of the words.
            /*Console.Write("Please enter your a text: ");
            string MyString = Console.ReadLine();

            string[] MyStringArr = MyString.Split(' ');
            
            for (int i = MyStringArr.Length - 1; i >= 0; i--)
            {
                Console.Write(MyStringArr[i]);
                Console.Write(" ");
            }*/
            #endregion
            #region Q10
            // 10-Write a program to create two multidimensional arrays of same size.
            // Accept values from the user and store them in first array.
            // Now copy all the elements of the first array on second array and print second array.
            /*Console.Write("Please enter the size of your array: ");
            int.TryParse(Console.ReadLine(), out int size);

            int[, ] arr = new int[size, size];
            int[, ] CopyArr = new int[size, size];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"row number {i + 1}: ");
                for (int j = 0; j < arr.GetLength(1);)
                {
                    Console.Write($"Please enter the value fo the column number {j + 1}: ");
                    j = int.TryParse(Console.ReadLine(), out arr[i, j]) ? ++j : j;
                }
            }

            for (int i = 0; i < CopyArr.Length; i++)
            {
                CopyArr[i / CopyArr.GetLength(1), i % CopyArr.GetLength(1)] = arr[i / arr.GetLength(1), i % arr.GetLength(1)];
            }

            for (int i = 0; i < CopyArr.Length; i++)
            {
                Console.Write(CopyArr[i / CopyArr.GetLength(1), i % CopyArr.GetLength(1)]);
                if (i % CopyArr.GetLength(1) == size - 1)
                {
                    Console.WriteLine();
                }
            }*/
            #endregion
            #region Q11
            // 11-	Write a Program to Print One Dimensional Array in Reverse Order
            /*int[] ints = { 1, 2, 3, 4, 5, 6 };

            for (int i = ints.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ints[i]);
            }*/
            #endregion
        }
    }
}
