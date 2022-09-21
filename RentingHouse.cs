using System;
using System.Collections.Generic;
using System.Text;

namespace PoEProg
{
    class RentingHouse : ExpenseAmount
    {
        public override void Expenses()
        {
            //using a for loop for the array valuable that was inheritance from express class
            try
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("please enter your monthly rental amount -> ");
                    renting_amount[i] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Remaing amount after all specifies deductions have been made");
                    double total_remaining = Total_income[0] - Estimated_monthly_tax[0] - Estimated_spend_groceries[0] - travel_cost[0]
                     - cellPhone_telephone[0] - spend_water_lights[0] - other_expense[0] - renting_amount[0];
                    Console.WriteLine("Remaining total = " + " R " + total_remaining);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
