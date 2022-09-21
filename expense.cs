using System;
using System.Collections.Generic;
using System.Text;

namespace PoEProg
{
        
    abstract class ExpenseAmount
    {
        //declaring differents arrays valuable to be used on this class  
        public static double[] Total_income = new double[1];
        public static double[] renting_amount = new double[1];
        public static double[] price_property = new double[1];
        public static double[] total_desposit = new double[1];
        public static double[] interest_rate = new double[1];
        public static int[] number_months = new int[1];
        public static double[] monthly_repayment = new double[1];
        public static double[] Estimated_monthly_tax = new double[1];
        public static double[] Estimated_spend_groceries = new double[1];
        public static double[] travel_cost = new double[1];
        public static double[] cellPhone_telephone = new double[1];
        public static double[] spend_water_lights = new double[1];
        public static double[] other_expense = new double[1];

        public static double[] monthly_expenses = new double[6];  //declaring a array to store the expenses

        public abstract void Expenses(); //abstract class
        //decalring list to store valuables
        public static List<string> vehicledetails = new List<string>();
        public static List<double> vehicleExpenses = new List<double>();
       


    }

}
