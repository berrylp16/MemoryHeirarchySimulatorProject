using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;


class RWData
{


    public struct Data
    {
        public Data(char permission, string hex)
        {
            this._perm = permission;
            this._hex = hex;
        }

        public char _perm { get; init; }
        public string _hex { get; init; }
        public override string ToString() => $"({_perm},{_hex})";
    }




    static void Main()
    {
        string filepath = @"C:\Users\rayce\Downloads\real_tr.dat";

        int arraysize = File.ReadLines(filepath).Count();

        Data[] virtualMemory = new Data[arraysize];
        int i = 0;

        using StreamReader reader = new StreamReader(filepath);
        {

            string line;
            while ((line = reader.ReadLine()) != null)
            {

                Data data = new Data(line[0], (line.Substring(2)));  
                virtualMemory[i] = data;
                i++;
            }
        }

        printTraceConfig();
        printTraceData(virtualMemory);
        leastReventUse(virtualMemory);
        greedy(virtualMemory);
        firstInFirstOut(virtualMemory);
    }

    private static void printTraceData(Data[]virttualMemory)
    {
        Console.WriteLine("==============\nVirtual Memory\n==============\n");
        foreach (Data data in virttualMemory)
        {
            Console.WriteLine(data.ToString());
        }

    }

    private static void printTraceConfig()
    {
       

        Console.WriteLine("trace.config");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Page Table Configuration: ");
        Console.WriteLine("Number of virtual pages: 100");
        Console.WriteLine("Number of physical pages: 108296");
        Console.WriteLine("Page size: 256");
        Console.WriteLine(" \n");
    }
    private static void leastReventUse(Data[]virtualMemory)
    {
        //todo
        //we can print all output within the function, or change void to string and print as its called.
    }

    private static void greedy(Data[] virtualMemory)
    {
        //todo
        //we can print all output within the function, or change void to string and print as its called.
    }

    private static void firstInFirstOut(Data[] virtualMemory)
    {
        //todo
        //we can print all output within the function, or change void to string and print as its called.
    }

}