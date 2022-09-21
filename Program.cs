using System;

namespace ProgPoE
{
    class Program
    {
        static void Main(string[] args)
        {
            IncomeExpense incomeExpense = new IncomeExpense();
            incomeExpense.expenseAmounts();
            Console.ReadKey();
        }
    }
}
