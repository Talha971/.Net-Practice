// See https://aka.ms/new-console-template for more information


/////////////////////////////////////// vvv BOILER PLATE vvv//////////////////////////
//using System;

//namespace MyApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}
///////////////////////////////////// ^^^ BOILER PLATE ^^^/////////////////////////////

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, Chamman");
//Console.WriteLine(2+8);

// write line / Read line

/*int num = 45;
Console.WriteLine(num);
string myNum = Console.ReadLine();
Console.WriteLine(Convert.ToInt32(myNum));*/

////MAth
//Console.WriteLine(Math.Min(5, 10));

///////////////////////////////////Arrays////////////////////////////////////////
///////////////////////////////////Arrays////////////////////////////////////////
///////////////////////////////////Arrays////////////////////////////////////////
//string[] cars = { "bolan", "civic", "alto" };
//Array.Sort(cars);
//foreach (var gari in cars)
//{
//    Console.WriteLine(gari);
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] cars = { "bolan", "civic", "alto" };
//        string[] truck = { "jpka", "civic", "mercedes" };
//        string[] bike = { "yamaha", "civic", "hayabosa" };

//        // Find common elements in all three arrays
//        var commonElements = cars.Intersect(truck).Intersect(bike);

//        // Print the common elements
//        Console.WriteLine("Common elements in all arrays:");
//        foreach (var element in commonElements)
//        {
//            Console.WriteLine(element);
//        }
//    }
//}



//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] cars = { "bolan", "civic", "alto", "boss", "extra" };
//        string[] trucks = { "jpka", "civic", "mercedes", "boss" };
//        string[] bikes = { "yamaha", "civic", "civic", "boss" };
//        int matched = 0;
//        foreach (string car in cars)
//        {

//            foreach (string truck in trucks)
//            {
//                if (car == truck)
//                {
//                    matched = 1;
//                }

//            }
//            if (matched == 1)
//            {
//                foreach (string bike in bikes)
//                {
//                    if (car == bike)
//                    {
//                        Console.WriteLine(car);
//                        break;
//                    }
//                }
//            }

//        }
//    }
//}




////Matrix

//int[,] matrix = { { 1, 2 }, { 4, 5 }, { 7, 8 } };
////Console.WriteLine(matrix.GetLength(0)); // ROWS
////Console.WriteLine(matrix.GetLength(1)); //COLUMN

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write($"{matrix[i, j]}\t");

//    }
//    Console.WriteLine("\n");
//}




//****
//***
//**
//*
//for (int i = 0; i < 5; i++)
//{
//	for (int j = i; j < 5; j++)
//	{
//		Console.Write("*");
//	}
//		Console.WriteLine();
//}


////*
////**
////***
////****
////*****

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

// *
//* *
// *
//int size = 5;
//int space = size - 1 ;

//Koi .NET FULL STACK APPLICATION DHOOND SATH BANATE HAIN
//Onn sceen

//for (int i = 0; i < size; i++)
//{
//    for (int k = 0; k < space; k++)
//    {
//        Console.Write(" ");
//    }

//    for (int j = 0; j <= i; j++)
//	{
//        Console.Write("* ");

//    }

//    Console.WriteLine();
//    space--;
//}

//space = 0;

//for (int i = size - 1; i > 0; i--)
//{
//    for (int k = 0; k <= space; k++)
//    {
//        Console.Write(" ");
//    }

//    for (int j = i; j > 0; j--)
//    {
//        Console.Write("* ");

//    }

//    Console.WriteLine();
//    space++;
//}




//return StatementCompletedEventArgs in strings


////////////////////////////////////////OOP//////////////////////////////////////////
//////////////////////////////////Classes: Fruit/////////////////////////////////////
////////////////////////////objects: bananna apple mango/////////////////////////////

////Create a class named "Car" with a variable color:

//class Car
//{
//    string color = "red";
//}
////When a variable is declared directly in a class, it is often referred to as a 
////field (or attribute).


//Classes and Object
//namespace MyApp
//{

//    class Car
//    {
//        string color = "red";
//        int model = 2001;
//        static void Main(string[] args)
//        {
//            Car suzuki = new Car();
//            Car bolan = new Car();
//            Console.WriteLine(bolan.color);
//            Console.WriteLine(suzuki.model);
//        }
//    }
//}








//Leet code 


//using System.Text.RegularExpressions;

//////string s = "A man, a plan, a canal: Panama";
//string s = "nonon";

//s = s.ToLower();
//s = s.Replace(" ", "");
//s = Regex.Replace(s, "[^a-zA-Z0-9]", "");
//Console.WriteLine(s);
////string s1;
//for (int i = 0; i < s.Length / 2; i++)
//{
//    //Console.WriteLine(s[s.Length - i - 1]);
//    if (s[i] != s[s.Length - i - 1])
//    {
//        Console.WriteLine("false");
//        return;
//    }

//}
//Console.WriteLine("true");



///////////////////////////////////////SWAPPING THE NUMBER WITHOUT THIRD VARIABLE//////////////////////////////

//int a = 1;
//int b = 2;

//a = a + b; // a becomes 3 (1 + 2)
//b = a - b; // b becomes 1 (3 - 2)
//a = a - b; // a becomes 2 (3 - 1)
//Console.WriteLine("a:" + a + "\n" + "b:" + b);


///////////////////////////////////////Duplicate//////////////////////////////


//int[] arr = { 1, 2, 3, 2, 5, 3 };
//Array.Sort(arr);
//int[] result = { };
//for (int i = 0; i < arr.Length - 1; i++)
//{
//    if (arr[i] == arr[i + 1])
//    {
//        result.Append(arr[i]);
//        Console.WriteLine(arr[i]);
//    }
//}



/////////////////////////////////////////2nd method//////////////////////////////
//using System;
////using System.Collections.Generic;
//int[] arr = { 1, 2, 2, 3, 7, 2, 5, 4, 2, 3, 3, 4, 4, 3, 7 };

//Dictionary<int, int> count = new Dictionary<int, int>();
//for (int i = 0; i < arr.Length; i++)
//{

//    if (count.ContainsKey(arr[i]))
//    {
//        count[arr[i]]++;
//    }
//    else
//    {
//        count[arr[i]] = 1;
//    }
//}
//foreach (var kvp in count)
//{
//    Console.WriteLine($"{kvp.Key} : {kvp.Value} ");
//}

/////////////////////////////////////////3rd method //////////////////////////////
//using System;
////using System.Collections.Generic;
//int[] arr = { 1, 5, 6, 2, 3, 1, 5, 3 };
//HashSet<int> seen = new HashSet<int>();
//HashSet<int> duplicate = new HashSet<int>();
//for (int i = 0; i < arr.Length; i++)
//{
//    if (seen.Contains(arr[i]))
//    {
//        duplicate.Add(arr[i]);
//    }
//    else
//    {
//        seen.Add(arr[i]);
//    }
//}
//foreach (int k in duplicate)
//{
//    Console.WriteLine(k);
//}

/////////////////////////////////////////////////// Conclusion of duplicate ///////////////////////////////////
//Efficiency Comparison:
//1️⃣ Sorting + Consecutive Check: O(N log N) Time, O(1) Space (❌ Not Ideal)
//2️⃣ Dictionary (Count Frequency): O(N) Time, O(N) Space (✅ Good)
//3️⃣ HashSet (Track Seen & Duplicates): O(N) Time, O(N) Space (✅ Best)

//📌 Use HashSet for Best Performance! 🚀
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////// 2 sum //////////////////////////////
////Input: nums = [1, 2, 3, 4, 5, 6, 7, 8, 9], target = 10
////Output: [[1, 9], [2, 8], [3, 7], [4, 6]]  

//int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9];
//int target = 10;
//for (int i = 0; i < nums.Length; i++)
//{
//    for (int j = i+1; j < nums.Length; j++)
//    {
//        if (nums[i] + nums[j] == target)
//        {
//            Console.WriteLine("[" + nums[i] + "," + nums[j] + "]");
//        }

//    }

//}

///////////////////////////////////////////////////Method 2 ///////////////////////////////////////////
//int[] nums = [6, 12, 8, 7, 2, 5, 10];
//int target = 10;
//Dictionary<int, int> result = new Dictionary<int, int>();
//for (int i = 0; i < nums.Length; i++)
//{
//    result[target - nums[i]] = i;

//    if (result.ContainsKey(nums[i]))
//    {
//        //for indexes 
//        Console.WriteLine(i + ":" + result[nums[i]]);

//        //for values
//        //Console.WriteLine("[" + nums[i] + "," + nums[result[nums[i]]] + "]");
//    }
//}
////foreach (var item in result)
////{
////    //    Console.WriteLine($"{item.Key} : {item.Value}");
////}


///////////////////////////////////////////////////// Reverse an array ///////////////////////////////////////////

////int[] arr = { 1, 2, 3, 4, 5, 6 };
//string[] arr = { "apple", "banana", "papaya", "avacado" };
//for (int i = arr.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(arr[i]);
//}

/////////////////////////////////////////////////////// Reverse the string///////////////////////////////////////////
//string name = "apple";
//for (int i = name.Length - 1; i >= 0; i--)
//{
//    Console.Write(name[i]);
//}

///////////////////////////////////////////////////////// max and min in an array //////////////////////////////////////
//int[] arr = { 10, 2, 11, 9, 33, 40, 5, 6,1 } ;
//int max = arr[0];
//for (int i = 1; i < arr.Length; i++) 
//{
//    if(arr[i] > max)
//    {
//        max = arr[i];
//    }
//}
//Console.WriteLine(max);


//////////////////////////////////////////////////////// odd / Even///////////////////////////////////////////////

//int[] arr = { 10, 2, 11, 9, 33, 40, 5, 6, 1 };
//Console.Write("Even: ");
//foreach (int num in arr)
//{
//    if (num % 2 == 0)
//    {
//        Console.Write(num + " ");
//    }
//}

//int[] arr = { 10, 2, 11, 9, 33, 40, 5, 6, 1 };
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0) 
//    {

//        Console.WriteLine(arr[i]);
//    }
//}

//////////////////////////////////////////////////// //// altenative odd with using loop////////////////////////////////

//by flag //
//int[] arr = { 10, 2, 11, 9, 33, 40, 5, 6, 1 };
//bool print = true;  
//for (int i = 0; i < arr.Length; i++)

//{

//    if (arr[i] % 2 == 0)
//    {

//        if (print)
//        {
//            Console.WriteLine(arr[i]);
//        }
//        print = !print;
//    }
//}

//by COUNT VARIALE
//int[] arr = { 10, 2, 11, 9, 33, 40, 5, 6, 1 };
//Console.Write("Alternate Odd: ");
//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] %2==1)
//    {
//        if (count % 2 == 0)
//        {
//            Console.WriteLine(arr[i]);


//        }
//        count++;
//    }
//}

//////////////////////////////////////////////////////// altenative odd without using loop////////////////////////////////
int[] arr = { 10, 2, 11, 9, 33, 40, 5, 6, 1 };
Console.Write("Alternate Odd: ");
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 1)
    {
        if (count % 2 == 0)
        {
            Console.WriteLine(arr[i]);


        }
        count++;
    }
}
