using System;
using System.Collections.Generic;
using System.Text;

namespace PoEProg
{

    class vehicle : ExpenseAmount
    {
        
        public override void Expenses()
        {
            //declaring variables  
            string Model, make;
            double price;
            double deposit;
            double interest;
            double insurance_premium;

            Console.WriteLine("**************************************************************************************************************");
            //getting enter by the user
            Console.Write("Enter the Model of the vehicle : ");
            Model = Console.ReadLine();
            vehicledetails.Add(Model);

            Console.Write("Enter the make of the vehicle : ");
            make = Console.ReadLine();
            vehicledetails.Add(make);

            Console.Write("Enter the price of the vehicle : R");
            price = Convert.ToDouble(Console.ReadLine());
            vehicleExpenses.Add(price);

            Console.Write("Enter the Total deposit  of the vehicle : R ");
            deposit = Convert.ToDouble(Console.ReadLine());
            vehicleExpenses.Add(deposit);

            Console.Write("Enter the  Interest rate  of the vehicle in (percentage) : %");
            interest = Convert.ToDouble(Console.ReadLine());
            vehicleExpenses.Add(interest);

            Console.Write("Enter the Estimated insurance premium of the vehicle : R ");
            insurance_premium = Convert.ToDouble(Console.ReadLine());
            vehicleExpenses.Add(insurance_premium);

            //calculeting the total amount that the user will be paying monthly
            double remaining_payment = price - deposit;
            
            double Calinterest = interest / 100;

            double years = 60 / 12;

            double first_step = 1 + Calinterest * years;

            double payments = remaining_payment * first_step;

            double monthly_payments = payments / 60;
            double answer = Math.Round(monthly_payments);
            double total = answer + insurance_premium;

            vehicleExpenses.Add(total);
            //displaying the total
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("Total monthly repayment for vehicle: " + " R " + total);
            Console.WriteLine("**************************************************************************************************************");

            //sorting the value in order
            Console.WriteLine("**************************************************************************************************************");
            vehicleExpenses.Sort();
            Console.WriteLine("VEHICLE EXPENSES SORT");
            Console.WriteLine(String.Join(",R", vehicleExpenses));
            Console.WriteLine("**************************************************************************************************************");


        }
    }
}
