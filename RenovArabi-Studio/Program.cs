/*

int i;
i = test(6);
Console.WriteLine("Hello, World! " + i);
Console.ReadKey();

static int test(int i)
{
    return i;
}

if (i == 6) {}
else {}

switch (i) {
    case 0:
        break;
    default:
        break;
}

int[] vs = new int[6];
int[] vs2 = new int[] {1, 2, 3, 4, 5, 6};

List<int> list = new List<int>() {1, 2, 3};
list.Add(3);
list.Remove(1);

foreach (int j in vs) {}

for (int k = 0; k < vs2.Length; k++) {}

class testClass {}

class MyClass : testClass {
    public MyClass() {
        // constructor
    }

    private void Test() {}
}

//MyClass MyClass = new MyClass();
*/
/*
using System;

namespace RenovArabi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}
*/
//using System;
//using System.IO;
//using System.Globalization;
//using System.Linq;
//using CsvHelper;
using Microsoft.VisualBasic.FileIO;

namespace csvReader
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVtoList();
        }
        public static void LoadCSV() { }
        public static void CSVtoList()
        {
            var csvPath = @"D:\Ahmad\Desktop\GitHub\RenovArabi-Studio\RenovArabi-Studio\OtherFiles\Tables\TextTable.csv";
            using TextFieldParser csvReader = new(csvPath);
            //csvReader.CommentTokens = new string[] { "#" };
            csvReader.SetDelimiters(new string[] { "," });
            csvReader.HasFieldsEnclosedInQuotes = true;

            //csvReader.ReadLine(); // Skip the row with the column names
            List<string[]> table = new();

            while (!csvReader.EndOfData)
            {
                string[] fields = csvReader.ReadFields();
                table.Add(fields);
            }
            /*
            foreach (int row in Enumerable.Range(0, table.Count))
            {
                foreach (int col in Enumerable.Range(0, table[row].Length))
                {
                    Console.WriteLine(row);
                    Console.WriteLine(col);
                    Console.WriteLine(table[row][col]);
                }
            }*/
        }
    }
}