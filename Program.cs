using System;
using System.IO;
using System.Collections.Generic;

namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactionHolder = new List<Transaction>();

            using (var reader = new StreamReader(@"C:\TechSwitchTraining\SupportBank_Ken\Transactions2014.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Console.WriteLine(values);
                    transactionHolder.Add(new Transaction(values[0], values[1], values[2], values[3], Convert.ToDouble(values[4])));
                }
            }

            Console.WriteLine(transactionHolder);
            //Console.Write(transactionHolder);
        }
    }
}
