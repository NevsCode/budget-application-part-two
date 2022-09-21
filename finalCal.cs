using System;
using System.Collections.Generic;
using System.Text;

namespace PoEProg
{
    class finalCal: ExpenseAmount
    {
       
        public override void Expenses()
        {
            //using the for loop to calculete the total cost of the expenses
            for (int i = 0; i < 1; i++)
            {
                double total_expenses = Estimated_monthly_tax[0] + Estimated_spend_groceries[0] + travel_cost[0]
                         + cellPhone_telephone[0] + spend_water_lights[0] + other_expense[0];
                double sumAmount = Total_income[0] + monthly_repayment[0] + vehicleExpenses[4];
                double ckeckingAmount = sumAmount/100 * 75;

                //using if statement to check the amounts
                if (total_expenses > ckeckingAmount)
                {
                    Console.WriteLine("**************************************************************************************************************");
                    Console.WriteLine("Your total expenses as exceed 75% of your income,including loan repayments");
                    Console.WriteLine("**************************************************************************************************************");
                }
               

            }
            
            //sorting the expenses of the house 
            Array.Sort(monthly_expenses);
            Console.WriteLine("Expenses descending order by value ");
            for (int i = 0; i < monthly_expenses.Length; i++)
            {
               Console.WriteLine( " R " + monthly_expenses[i]);
            }
            Console.WriteLine("**************************************************************************************************************");
        }
    }
}
