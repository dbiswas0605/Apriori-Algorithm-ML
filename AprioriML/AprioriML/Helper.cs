using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AprioriML
{
    class Helper
    {
        static internal string[] GetFieldName()
        {
            var lines = File.ReadAllLines(@"F:\Developer\MCS-DS\AprioriAlgorithm\AprioriAlgorithm\Sample Data\categories.txt");

            List<string> items = new List<string>();
            foreach(var line in lines)
            {
                items.AddRange(line.Split(';'));
            }

            var fields = items.Distinct().ToArray();

            return fields;
        }

        static internal List<List<int>> GetTransactions(string[] FieldName)
        {
            var lines = File.ReadAllLines(@"F:\Developer\MCS-DS\AprioriAlgorithm\AprioriAlgorithm\Sample Data\categories.txt");

            List<List<int>> Transactions = new List<List<int>>();
            foreach (var line in lines)
            {
                var items = line.Split(';').ToArray();

                List<int> transaction = new List<int>();
                foreach(var item in items)
                {
                    int index = Array.FindIndex(FieldName, e=>e==item);

                    transaction.Add(index);
                }
                Transactions.Add(transaction);
            }
            return Transactions;
        }
    }
}
