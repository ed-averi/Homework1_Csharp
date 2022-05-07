using System;
using static System.Console;
// See https://aka.ms/new-console-template for more information
namespace myfirstapp
{
    // Note: actual namespace depends on the project name.


    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("------------------------------------------------------------------------------------");
            WriteLine("Type    Byte(s) of memory                         Min                           Max");
            WriteLine("------------------------------------------------------------------------------------");

            //decimal a = 10.2M;
            WriteLine($"sbyte    {sizeof(sbyte),-39} {sbyte.MinValue}                            {sbyte.MaxValue}");
            WriteLine($"byte     {sizeof(byte),-42} {byte.MinValue}                            {byte.MaxValue}");
            WriteLine($"short    {sizeof(short),-37} {short.MinValue}                          {short.MaxValue}");
            WriteLine($"ushort   {sizeof(ushort),-42} {ushort.MinValue}                          {ushort.MaxValue}");
            WriteLine($"int      {sizeof(int),-32} {int.MinValue}                     {int.MaxValue}");
            WriteLine($"uint     {sizeof(uint),-42} {uint.MinValue}                     {uint.MaxValue}");
            WriteLine($"long     {sizeof(long),-23} {long.MinValue}            {long.MaxValue}");
            WriteLine($"ulong    {sizeof(ulong),-42} {ulong.MinValue}           {ulong.MaxValue}");
            WriteLine($"float    {sizeof(float),-29} {float.MinValue}                  {float.MaxValue}");
            WriteLine($"double   {sizeof(double),-19} {double.MinValue}        {double.MaxValue}");
            WriteLine($"decimal  {sizeof(decimal),-13} {decimal.MinValue}  {decimal.MaxValue}");
            WriteLine("------------------------------------------------------------------------------------");
            WriteLine();
            WriteLine();
            //Align strings with string.format with text data just for reference
            /*WriteLine("-------------------------------");
            WriteLine("First Name | Last Name  |   Age");
            WriteLine("-------------------------------");
            WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Bill", "Gates", 51));
            WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Edna", "Parker", 114));
            WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Johnny", "Depp", 44));
            WriteLine("-------------------------------");*/

            /* //First method, simple method
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    WriteLine("FizzBuzz");
                }
                if (i % 3 == 0)
                {
                    WriteLine("Fizz");
                }
                if (i % 5 == 0)
                {
                    WriteLine("Buzz");
                }
                else
                {
                    WriteLine(i);
                }
            }*/
            //second method separated by commas
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Write("FizzBuzz,");
                }
                if (i % 3 == 0)
                {
                    Write("Fizz,");
                }
                if (i % 5 == 0)
                {
                    Write("Buzz,");
                }
                else
                {
                    Write($"{i},");
                }
            }


        }
    }
}
