//assignment2.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Assignment2
{
	public class IRIS_app
	{
		static void Main (string[] args)
		{
			Console.WriteLine("CMP1124M - Algorithms and Complexity - Assignment 2 - CRO15592084");
			Console.WriteLine("Which Array or String Array would you like to analyse?");
			int selection = 0;
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
			selection = Convert.ToInt32(Console.ReadLine());
			int count = 0;
			switch(selection){
			case 1:
			int[] year1 = new int[600];
			foreach (string line in File.ReadAllLines("Year_1.txt")){
				int temp = Convert.ToInt32(line);
				year1[count] = temp;
				count++;
			}
			SortingTools.InsertionSort(year1);
			break;
			case 2:
			string[] month1 = new string[600];
			break;
			case 3:
			int[] day1 = new int[600];
			foreach (string line in File.ReadAllLines("Day_1.txt")){
				int temp = Convert.ToInt32(line);
				day1[count] = temp;
				count++;
			}
			SortingTools.InsertionSort(day1);
			break;
			case 4:
			string[] time1 = new string[600];
			foreach (string line in File.ReadAllLines("time_1.txt")){
				string temp = line;
				time1[count] = temp;
				count++;
			}
			SortingTools.BubbleSort(time1);
			break;
			case 5:
			float[] magnitude1 = new float[600];
			foreach (string line in File.ReadAllLines("Magnitude_1.txt")){
				string temp = line;
				magnitude1[count] = Convert.ToSingle(temp);
				count++;
			}
			SortingTools.
			break;
			case 6:
			float[] latitude1 = new float[600];
			break;
			case 7:
			float[] longitude1 = new float[600];
			break;
			case 8:
			float[] depth1 = new float[600];
			break;
			case 9:
			string[] region1 = new string[600];
			foreach (string line in File.ReadAllLines("Region_1.txt")){
				string temp = line;
				region1[count] = temp;
				count++;
			}
			SortingTools.BubbleSort(region1);
			break;
			case 10:
			int[] iris1 = new int[600];
			foreach (string line in File.ReadAllLines("IRIS_ID_1.txt")){
				int temp = Convert.ToInt32(line);
				iris1[count] = temp;
				count++;
			}
			SortingTools.InsertionSort(iris1);
			break;
			case 11:
			int[] timestamp1 = new int[600];
			break;
			default:
			Console.WriteLine("Invalid input, please try again.");
			break;
			}
		}
	}
	
	public class SortingTools{
		public static void InsertionSort(int[] intArray){
			int temp, j;
			for (int i = 1; i < intArray.Length; i++){
				temp = intArray[i];
				j= i - 1;
				
				while (j >= 0 && intArray[j] > temp){
					intArray[j+1] = intArray[j];
					j--;
				}
				
				intArray[j+1] = temp;
			}
			Console.WriteLine("Press any key to display sorted array content:");
			Console.ReadKey();
			for (int i = 0; i < intArray.Length; i++){
				Console.WriteLine(intArray[i]);
			}
		}
		public static void BubbleSort(string[] strArray){
			bool swap;
			string temp;
			do{
				swap = false;
			for (int i = 0; i < (strArray.Length - 1); i++){
				if (string.Compare (strArray[i], strArray[i+1]) > 0){
					//swap
					temp = strArray[i];
					strArray[i] = strArray[i+1];
					strArray[i+1] = temp;
					swap = true;
				}
			}
			
			} while (swap == true);
			for (int i = 0; i < strArray.Length; i++){
				Console.WriteLine(strArray[i]);
			}
		}
	}
}