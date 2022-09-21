using System;
using System.Collections.Generic;
using System.Text;

namespace PoEProg
{
    class ExpenseDetails : ExpenseAmount
    {
       
        public override void Expenses()
        {
            //accepting differents input from the use and storing it in a arrays
            //the for loop are checking the conditions of the arrays
                
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Enter your total gross monthly income before deductions  -> R ");
                    Total_income[i] = Convert.ToDouble(Console.ReadLine());
                   
                    Console.Write("Enter your Estimated monthly tax deducted -> R ");
                    Estimated_monthly_tax[i] = Convert.ToDouble(Console.ReadLine());
                    monthly_expenses[0] = Estimated_monthly_tax[i];
                //the while loop it checking if the income it bigger then the tax
                    while (Estimated_monthly_tax[i] > Total_income[i])
                    {
                        Console.WriteLine("the estimated monthly tax can not be more then total gross monthly income");
                        Console.Write("Enter your Estimated monthly tax deducted -> R");
                        Estimated_monthly_tax[i] = Convert.ToDouble(Console.ReadLine());
                       
                    }

                    Console.Write("Enter the Estimated amount you spended on Groceries monthly -> R");
                    Estimated_spend_groceries[i] = Convert.ToDouble(Console.ReadLine());
                    monthly_expenses[1] = Estimated_spend_groceries[i];

                    Console.Write("Enter the Estimated amount you spended on water and lights in total monthly -> R ");
                    spend_water_lights[i] = Convert.ToDouble(Console.ReadLine());
                    monthly_expenses[2] = spend_water_lights[i];

                    Console.Write("Enter the Estimated amount you spended on travel cost including petrol monthly -> R ");
                    travel_cost[i] = Convert.ToDouble(Console.ReadLine());
                    monthly_expenses[3] = travel_cost[i];

                    Console.Write("Enter the Estimated amount you spended on cell phone and telephone in total monthly -> R ");
                    cellPhone_telephone[i] = Convert.ToDouble(Console.ReadLine());
                    monthly_expenses[4] = cellPhone_telephone[i];

                    Console.Write("Enter the Estimated amount you spended on other expenses monthly -> R");
                    other_expense[i] = Convert.ToDouble(Console.ReadLine());
                    monthly_expenses[5] = other_expense[i];

                }
        }

       
    }
}
