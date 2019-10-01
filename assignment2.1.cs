//assignment2.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Assignment2
{
    public class IRIS_app
    {
        public static int[] year1 = new int[600];
        public static string[] month1 = new string[600];
        public static int[] day1 = new int[600];
        public static string[] time1 = new string[600];
        public static float[] magnitude1 = new float[600];
        public static float[] latitude1 = new float[600];
        public static float[] longitude1 = new float[600];
        public static float[] depth1 = new float[600];
        public static string[] region1 = new string[600];
        public static int[] iris1 = new int[600];
        public static int[] timestamp1 = new int[600];

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("CMP1124M - Algorithms and Complexity - Assignment 2 - CRO15592084");
            Console.WriteLine("Select a file to analyse.");
            Console.WriteLine("[1] Year_1.txt");
            Console.WriteLine("[2] Month_1.txt");
            Console.WriteLine("[3] Day_1.txt");
            Console.WriteLine("[4] Time_1.txt");
            Console.WriteLine("[5] Magnitude_1.txt");
            Console.WriteLine("[6] Latitude_1.txt");
            Console.WriteLine("[7] Longitude_1.txt");
            Console.WriteLine("[8] Depth_1.txt");
            Console.WriteLine("[9] Region_1.txt");
            Console.WriteLine("[10] IRIS_ID_1.txt");
            Console.WriteLine("[11] Timestamp_1.txt");
            int selection1 = 0;
            selection1 = Convert.ToInt32(Console.ReadLine());
            int selection2 = 0;
            int count = 0;
            int searchInt = 0;
            float searchF = 0.0f;
            string searchStr = "";
            foreach (string line in File.ReadAllLines("Year_1.txt"))
            {
                int temp = Convert.ToInt32(line);
                year1[count] = temp;
                count++;
            }
            count = 0;
            foreach (string line in File.ReadAllLines("Month_1.txt"))
            {
                string temp = line.Trim();
                month1[count] = temp;
                count++;
            }
            count = 0;
            foreach (string line in File.ReadAllLines("Day_1.txt"))
            {
                int temp = Convert.ToInt32(line);
                day1[count] = temp;
                count++;
            }
            count = 0;
            foreach (string line in File.ReadAllLines("Time_1.txt"))
            {
                string temp = line;
                time1[count] = temp;
                count++;
            }
            count = 0;
            foreach (string line in File.ReadAllLines("Magnitude_1.txt"))
            {
                string temp = line;
                magnitude1[count] = Convert.ToSingle(temp);
                count++;
            }
            count = 0;
            foreach (string line in File.ReadAllLines("Latitude_1.txt"))
            {
                string temp = line;
                latitude1[count] = Convert.ToSingle(temp);
                count++;
            }
            count = 0;
            foreach (string line in File.ReadAllLines("Longitude_1.txt"))
            {
                string temp = line;
                longitude1[count] = Convert.ToSingle(temp);
                count++;
            }
            count = 0;
            foreach (string line in File.ReadAllLines("Depth_1.txt"))
            {
                string temp = line;
                depth1[count] = Convert.ToSingle(temp);
                count++;
            }
            count = 0;
            foreach (string line in File.ReadAllLines("Region_1.txt"))
            {
                string temp = line;
                region1[count] = temp;
                count++;
            }
            count = 0;
            foreach (string line in File.ReadAllLines("IRIS_ID_1.txt"))
            {
                int temp = Convert.ToInt32(line);
                iris1[count] = temp;
                count++;
            }
            count = 0;
            foreach (string line in File.ReadAllLines("Timestamp_1.txt"))
            {
                string temp = line;
                timestamp1[count] = Convert.ToInt32(temp);
                count++;
            }
            count = 0;
            switch (selection1)
            {
                case 1:
                    Console.WriteLine("Would you like to search[1], sort [2], show highest and lowest values[3], or quit[4]?");
                    selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("What would you like to search for in this array?");
                            searchInt = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Searching for {0}", searchInt);
                            SearchTools.LinearSearch(year1, searchInt);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sorting array, press any key to continue...");
                            Console.ReadKey();
                            SortingTools.InsertionSort(year1);
                            Console.WriteLine("Press any key to display sorted array content:");
                            Console.ReadKey();
                            for (int i = 0; i < year1.Length; i++)
                            {
                                Console.WriteLine(year1[i]);
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            int min = year1.Min();
                            searchInt = year1[0];
                            Console.WriteLine("Searching for minimum value and all instances in the array.");
                            SearchTools.LinearSearch(year1, searchInt);
                            Console.ReadKey();
                            int max = year1.Max();
                            searchInt = max;
                            Console.WriteLine("Searching for maximum value and all instances in the array.");
                            SearchTools.LinearSearch(year1, searchInt);
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                    break;
                    case 2:
                    Console.WriteLine("Would you like to search[1], sort [2], show highest and lowest values[3], or quit[4]?");
                    selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("What would you like to search for in this array?");
                            searchStr = Console.ReadLine();
                            Console.WriteLine("Searching for {0}", searchStr);
                            SearchTools.MonthSearch(month1, searchStr);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sorting array, press any key to continue...");
                            Console.ReadKey();
                            SortingTools.MonthSort(month1);
                            Console.ReadKey();
                            break;
                        case 3:
                            searchStr = "January";
                            Console.WriteLine("Searching for minimum value and all instances in the array.");
                            SearchTools.LinearSearch(month1, searchStr);
                            Console.ReadKey();
                            searchStr = "December";
                            Console.WriteLine("Searching for maximum value and all instances in the array.");
                            SearchTools.LinearSearch(month1, searchStr);
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Would you like to search[1], sort [2], show highest and lowest values[3], or quit[4]?");
                    selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("What would you like to search for in this array?");
                            searchInt = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Searching for {0}", searchInt);
                            SearchTools.LinearSearch(day1, searchInt);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sorting array, press any key to continue...");
                            Console.ReadKey();
                            SortingTools.InsertionSort(day1);
                            Console.WriteLine("Press any key to display sorted array content:");
                            Console.ReadKey();
                            for (int i = 0; i < day1.Length; i++)
                            {
                                Console.WriteLine(day1[i]);
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            int min = day1.Min();
                            searchInt = min; 
                            Console.WriteLine("Searching for minimum value and all instances in the array.");
                            SearchTools.LinearSearch(day1, searchInt);
                            Console.ReadKey();
                            int max = day1.Max();
                            searchInt = max;
                            Console.WriteLine("Searching for maximum value and all instances in the array.");
                            SearchTools.LinearSearch(day1, searchInt);
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Would you like to search[1], sort [2], show highest and lowest values[3], or quit[4]?");
                    selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("What would you like to search for in this array?");
                            searchStr = Console.ReadLine();
                            Console.WriteLine("Searching for {0}", searchStr);
                            SearchTools.LinearSearch(time1, searchStr);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sorting array, press any key to continue...");
                            Console.ReadKey();
                            SortingTools.BubbleSort(time1);
                            Console.ReadKey();
                            for (int i = 0; i < time1.Length; i++)
                            {
                                Console.WriteLine(time1[i]);
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            SortingTools.BubbleSort(time1);
                            searchStr = time1[0];
                            Console.WriteLine("Searching for minimum value and all instances in the array.");
                            SearchTools.LinearSearch(time1, searchStr);
                            Console.ReadKey();
                            searchStr = time1[599];
                            Console.WriteLine("Searching for maximum value and all instances in the array.");
                            SearchTools.LinearSearch(time1, searchStr);
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine("Would you like to search[1], sort [2], show highest and lowest values[3], or quit[4]?");
                    selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            SortingTools.InsertionSort(magnitude1);
                            Console.WriteLine("What would you like to search for in this array?");
                            searchF = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Searching for {0}", searchF);
                            SearchTools.BinarySearch(magnitude1, searchF);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sorting array, press any key to continue...");
                            Console.ReadKey();
                            SortingTools.InsertionSort(magnitude1);
                            Console.WriteLine("Press any key to display sorted array content:");
                            Console.ReadKey();
                            for (int i = 0; i < magnitude1.Length; i++)
                            {
                                Console.WriteLine(magnitude1[i]);
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            SortingTools.InsertionSort(magnitude1);
                            searchF = magnitude1[0];
                            Console.WriteLine("Searching for minimum value and all instances in the array.");
                            SearchTools.BinarySearch(magnitude1, searchInt);
                            Console.ReadKey();
                            searchF = magnitude1[599];
                            Console.WriteLine("Searching for maximum value and all instances in the array.");
                            SearchTools.BinarySearch(magnitude1, searchInt);
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                    break;
                case 6:
                    Console.WriteLine("Would you like to search[1], sort [2], show highest and lowest values[3], or quit[4]?");
                    selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("What would you like to search for in this array?");
                            searchF = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Searching for {0}", searchF);
                            SearchTools.BinarySearch(latitude1, searchF);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sorting array, press any key to continue...");
                            Console.ReadKey();
                            SortingTools.InsertionSort(latitude1);
                            Console.WriteLine("Press any key to display sorted array content:");
                            Console.ReadKey();
                            for (int i = 0; i < latitude1.Length; i++)
                            {
                                Console.WriteLine(latitude1[i]);
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            SortingTools.InsertionSort(latitude1);
                            searchF = latitude1[0];
                            Console.WriteLine("Searching for minimum value and all instances in the array.");
                            SearchTools.BinarySearch(latitude1, searchF);
                            Console.ReadKey();
                            searchF = latitude1[599];
                            Console.WriteLine("Searching for maximum value and all instances in the array.");
                            SearchTools.BinarySearch(latitude1, searchF);
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                    break;
                case 7:
                    Console.WriteLine("Would you like to search[1], sort [2], show highest and lowest values[3], or quit[4]?");
                    selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("What would you like to search for in this array?");
                            searchF = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Searching for {0}", searchF);
                            SearchTools.BinarySearch(longitude1, searchF);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sorting array, press any key to continue...");
                            Console.ReadKey();
                            SortingTools.InsertionSort(longitude1);
                            Console.WriteLine("Press any key to display sorted array content:");
                            Console.ReadKey();
                            for (int i = 0; i < longitude1.Length; i++)
                            {
                                Console.WriteLine(longitude1[i]);
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            SortingTools.InsertionSort(longitude1);
                            searchF = longitude1[0];
                            Console.WriteLine("Searching for minimum value and all instances in the array.");
                            SearchTools.BinarySearch(longitude1, searchF);
                            Console.ReadKey();
                            searchF = longitude1[599];
                            Console.WriteLine("Searching for maximum value and all instances in the array.");
                            SearchTools.BinarySearch(longitude1, searchF);
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                    break;
                case 8:
                    Console.WriteLine("Would you like to search[1], sort [2], show highest and lowest values[3], or quit[4]?");
                    selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("What would you like to search for in this array?");
                            searchF = Convert.ToSingle(Console.ReadLine());
                            Console.WriteLine("Searching for {0}", searchF);
                            SearchTools.BinarySearch(depth1, searchF);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sorting array, press any key to continue...");
                            Console.ReadKey();
                            SortingTools.InsertionSort(depth1);
                            Console.WriteLine("Press any key to display sorted array content:");
                            Console.ReadKey();
                            for (int i = 0; i < depth1.Length; i++)
                            {
                                Console.WriteLine(depth1[i]);
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            SortingTools.InsertionSort(depth1);
                            searchF = depth1[0];
                            Console.WriteLine("Searching for minimum value and all instances in the array.");
                            SearchTools.BinarySearch(depth1, searchF);
                            Console.ReadKey();
                            searchF = depth1[599];
                            Console.WriteLine("Searching for maximum value and all instances in the array.");
                            SearchTools.BinarySearch(depth1, searchF);
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                    break;
                case 9:
                    Console.WriteLine("Would you like to search[1], sort [2], show highest and lowest values[3], or quit[4]?");
                    selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("What would you like to search for in this array?");
                            searchStr = Console.ReadLine().ToUpper();
                            Console.WriteLine("Searching for {0}", searchStr);
                            SearchTools.LinearSearch(region1, searchStr);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sorting array, press any key to continue...");
                            Console.ReadKey();
                            SortingTools.BubbleSort(region1);
                            Console.ReadKey();
                            for (int i = 0; i < region1.Length; i++)
                            {
                                Console.WriteLine(region1[i]);
                            }
                            Console.ReadKey();

                            break;
                        case 3:
                            SortingTools.BubbleSort(region1);
                            searchStr = region1[0];
                            Console.WriteLine("Searching for minimum value and all instances in the array.");
                            SearchTools.LinearSearch(region1, searchStr);
                            Console.ReadKey();
                            searchStr = region1[599];
                            Console.WriteLine("Searching for maximum value and all instances in the array.");
                            SearchTools.LinearSearch(region1, searchStr);
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                    break;
                case 10:
                    Console.WriteLine("Would you like to search[1], sort [2], show highest and lowest values[3], or quit[4]?");
                    selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("What would you like to search for in this array?");
                            searchInt = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Searching for {0}", searchInt);
                            SearchTools.BinarySearch(iris1, searchInt);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sorting array, press any key to continue...");
                            Console.ReadKey();
                            SortingTools.InsertionSort(iris1);
                            Console.WriteLine("Press any key to display sorted array content:");
                            Console.ReadKey();
                            for (int i = 0; i < iris1.Length; i++)
                            {
                                Console.WriteLine(iris1[i]);
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            SortingTools.InsertionSort(iris1);
                            searchInt = iris1[0];
                            Console.WriteLine("Searching for minimum value and all instances in the array.");
                            SearchTools.BinarySearch(iris1, searchInt);
                            Console.ReadKey();
                            searchInt = iris1[599];
                            Console.WriteLine("Searching for maximum value and all instances in the array.");
                            SearchTools.BinarySearch(iris1, searchInt);
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                    break;
                case 11:
                    Console.WriteLine("Would you like to search[1], sort [2], show highest and lowest values[3], or quit[4]?");
                    selection2 = Convert.ToInt32(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("What would you like to search for in this array?");
                            searchInt = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Searching for {0}", searchInt);
                            SearchTools.BinarySearch(timestamp1, searchInt);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Sorting array, press any key to continue...");
                            Console.ReadKey();
                            SortingTools.InsertionSort(timestamp1);
                            Console.WriteLine("Press any key to display sorted array content:");
                            Console.ReadKey();
                            for (int i = 0; i < timestamp1.Length; i++)
                            {
                                Console.WriteLine(timestamp1[i]);
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            SortingTools.BubbleSort(day1);
                            searchInt = timestamp1[0];
                            Console.WriteLine("Searching for minimum value and all instances in the array.");
                            SearchTools.LinearSearch(timestamp1, searchInt);
                            Console.ReadKey();
                            searchInt = timestamp1[599];
                            Console.WriteLine("Searching for maximum value and all instances in the array.");
                            SearchTools.BinarySearch(timestamp1, searchInt);
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;          
            }
        }
    }

    public class SortingTools
    {
        public static void InsertionSort<T>(T[] array) where T : IComparable<T>
        {
            T temp;
            int j;
            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i];
                j = i - 1;

                while (j >= 0 && array[j].CompareTo(temp) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = temp;
            }
        }
        public static void BubbleSort(string[] strArray)
        {
            bool swap;
            string temp;
            do
            {
                swap = false;
                for (int i = 0; i < (strArray.Length - 1); i++)
                {
                    if (string.Compare(strArray[i], strArray[i + 1]) > 0)
                    {
                        //swap
                        temp = strArray[i];
                        strArray[i] = strArray[i + 1];
                        strArray[i + 1] = temp;
                        swap = true;
                    }
                }

            } while (swap == true);
        }
        public static void BubbleSort(int[] intArray)
        {
            bool swap;
            int temp;
            do
            {
                swap = false;
                for (int i = 0; i < (intArray.Length - 1); i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        //swap
                        temp = intArray[i];
                        intArray[i] = intArray[i + 1];
                        intArray[i + 1] = temp;
                        swap = true;
                    }
                }

            } while (swap == true);
        }
        public static void MonthSort(string[] monArray)
        {
            int[] monthNums = new int[600];
            int counter = 0;
            int counter1 = 0;
            for (int i = 0; i < monArray.Length; i++)
            {
                Console.WriteLine(monArray[i]);
            }
            foreach (string month in monArray)
            {
                switch (month.Trim())
                {
                    case "January":
                        monthNums[counter] = 1;
                        counter++;
                        break;
                    case "February":
                        monthNums[counter] = 2;
                        counter++;
                        break;
                    case "March":
                        monthNums[counter] = 3;
                        counter++;
                        break;
                    case "April":
                        monthNums[counter] = 4;
                        counter++;
                        break;
                    case "May":
                        monthNums[counter] = 5;
                        counter++;
                        break;
                    case "June":
                        monthNums[counter] = 6;
                        counter++;
                        break;
                    case "July":
                        monthNums[counter] = 7;
                        counter++;
                        break;
                    case "August":
                        monthNums[counter] = 8;
                        counter++;
                        break;
                    case "September":
                        monthNums[counter] = 9;
                        counter++;
                        break;
                    case "October":
                        monthNums[counter] = 10;
                        counter++;
                        break;
                    case "November":
                        monthNums[counter] = 11;
                        counter++;
                        break;
                    case "December":
                        monthNums[counter] = 12;
                        counter++;
                        break;
                }
            }
            InsertionSort(monthNums);
            foreach (int num in monthNums)
            {
                switch (num)
                {
                    case 1:
                        monArray[counter1] = "January";
                        counter1++;
                        break;
                    case 2:
                        monArray[counter1] = "February";
                        counter1++;
                        break;
                    case 3:
                        monArray[counter1] = "March";
                        counter1++;
                        break;
                    case 4:
                        monArray[counter1] = "April";
                        counter1++;
                        break;
                    case 5:
                        monArray[counter1] = "May";
                        counter1++;
                        break;
                    case 6:
                        monArray[counter1] = "June";
                        counter1++;
                        break;
                    case 7:
                        monArray[counter1] = "July";
                        counter1++;
                        break;
                    case 8:
                        monArray[counter1] = "August";
                        counter1++;
                        break;
                    case 9:
                        monArray[counter1] = "September";
                        counter1++;
                        break;
                    case 10:
                        monArray[counter1] = "October";
                        counter1++;
                        break;
                    case 11:
                        monArray[counter1] = "November";
                        counter1++;
                        break;
                    case 12:
                        monArray[counter1] = "December";
                        counter1++;
                        break;
                }
                
            }
            for (int i = 0; i < monArray.Length; i++) {
                Console.WriteLine(monArray[i]);
            }
        }
    }

    public class SearchTools
    {
        public static void BinarySearch(int[] data, int item)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int min = 0;
            int N = data.Length;
            int max = N - 1;
            int searchComplete;
            do
            {
                int mid = (min + max) / 2;
                if (item > data[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (data[mid] == item)
                {
                    Console.WriteLine("Located {0} at position {1} in the array.", data[mid], mid);
                    searchComplete = 1;
                }
                else
                {
                    searchComplete = 0;
                }
                //return mid;
                if (min > max)
                    break;
            } while (min <= max);
            //return -1;
            if (searchComplete == 0)
            {
                Console.WriteLine("No data found that matches the search term: {0}.", item);
            }
            else
            {
                Console.WriteLine("Found search term.");
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("End of Binary Search. Any instances of the search term have been outputted. Time taken: {0}ms", elapsedMs);
        }
        public static void BinarySearch(float[] data, float item)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int min = 0;
            int N = data.Length;
            int max = N - 1;
            int searchComplete;
            do
            {
                int mid = (min + max) / 2;
                if (item > data[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (data[mid] == item)
                {
                    Console.WriteLine("Located {0} at position {1} in the array.", data[mid], mid);
                    searchComplete = 1;
                }
                else
                {
                    searchComplete = 0;
                }
                //return mid;
                if (min > max)
                    break;
            } while (min <= max);
            //return -1;
            if (searchComplete == 0)
            {
                Console.WriteLine("No data found that matches the search term: {0}.", item);
            }
            else
            {
                Console.WriteLine("Found search term.");
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("End of Binary Search. Any instances of the search term have been outputted. Time taken: {0}ms", elapsedMs);
        }
        public static void LinearSearch(int[] dataInt, int item)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int N = dataInt.Length;
            int i = 0;
            do
            {
                if (dataInt[i] == item)
                {
                    Console.WriteLine("Located {0} at position {1} in the array.", item, i);
                    i++;
                }
                else if (i == N)
                {
                    Console.WriteLine("No data found.");
                }
                else
                {
                    i++;
                }
            } while (i < N);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("End of search. All instances of the search term have been outputted. Time taken: {0}ms", elapsedMs);
        }
        public static void LinearSearch(string[] dataStr, string item)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int N = dataStr.Length;
            int i = 0;
            do
            {
                if (dataStr[i] == item)
                {
                    Console.WriteLine("Located {0} at position {1} in the array.", item, i);
                    i++;
                }
                else if (i == N)
                {
                    Console.WriteLine("No data found.");
                }
                else
                {
                    i++;
                }
            } while (i < N);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("End of search. All instances of the search term have been outputted. Time taken: {0}ms", elapsedMs);
        }
        public static void MonthSearch(string[] monthArray, string item)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int N = monthArray.Length;
            int i = 0;
            do
            {
                if (monthArray[i] == item)
                {
                    Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} | {9} | {10}" ,IRIS_app.year1[i], monthArray[i], IRIS_app.day1[i], IRIS_app.time1[i], IRIS_app.magnitude1[i], IRIS_app.latitude1[i], IRIS_app.longitude1[i], IRIS_app.depth1[i], IRIS_app.region1[i], IRIS_app.iris1[i], IRIS_app.timestamp1[i]);
                    i++;
                }
                else if (i == N)
                {
                    Console.WriteLine("No data found.");
                }
                else
                {
                    i++;
                }
            } while (i < N);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("End of search. All instances of the search term have been outputted. Time taken: {0}ms", elapsedMs);
        }
    }
}