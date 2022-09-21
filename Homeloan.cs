using System;
using System.Collections.Generic;
using System.Text;

namespace PoEProg
{
    class Homeloan : ExpenseAmount
    {
        
        public override void Expenses()
        {
           
            try
            {
                //accepting differents input from the use and storing it in a arrays
                //the for arechecking the conditions of the arrays
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Please enter purchase price of the property -> R ");
                    price_property[i] = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Please enter total deposit you will make -> R ");
                    total_desposit[i] = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Please enter interest rate in percentage  -> % ");
                    interest_rate[i] = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Please enter number of months you will like to repay back the money between 240 months and 360 months  -> ");
                    number_months[i] = Convert.ToInt32(Console.ReadLine());

                    if (number_months[i] >= 240)
                    {
                        Console.WriteLine("you have choose your number of month: " + number_months[i]);
                    }
                    else if (number_months[i] <= 360)
                    {
                        Console.WriteLine("you have choose your number of month: " + number_months[i]);
                    }
                    else
                    {
                        Console.WriteLine("you enter wrong choose ");
                        Console.Write("Please enter number of months you will like to repay back the money between (1) for 240 months and (2) for 360 months  -> ");
                        number_months[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    // calculating values and amount of loan 

                    double remaining_payment = price_property[i] - total_desposit[i];
                    double interest = interest_rate[i] / 100;

                    double years = number_months[i] / 12;

                    double first_step = 1 + interest * years;

                    double payments = remaining_payment * first_step;

                    double monthly_payments = payments / number_months[i];
                    double answer = Math.Round(monthly_payments);
                    monthly_repayment[i] = answer;
                    double third_gross_monthly = Total_income[0] / 3;

                    Console.WriteLine("**************************************************************************************************************");
                    if (answer > third_gross_monthly)
                    {
                        Console.WriteLine("the home loan repayment is more then third of your total gross monthly income therefor the approval of the home loan is unlikely");
                    }

                    Console.WriteLine("**************************************************************************************************************");
                    Console.WriteLine("Remaing amount after all specifies deductions have been made");
                    double total_remaining = Total_income[0] - Estimated_monthly_tax[0] - Estimated_spend_groceries[0] - travel_cost[0]
                        - cellPhone_telephone[0] - spend_water_lights[0] - other_expense[0] - total_desposit[0] - answer;
                    Console.WriteLine("Remaining total = " + " R " + total_remaining);
                    

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            
        }

       
    }

}
