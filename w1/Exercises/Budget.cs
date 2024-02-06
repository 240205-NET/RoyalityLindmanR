//Create a console application that will help you track your expenses, and thus survive in this economy!
//Your app should be able to do the following
//- Prompt the user to enter the initial budget
//- Prompt the user to enter expenses with amount and description
//- Display the all expenses and the remaining amount

using System;

namespace budget {

    public class Program {
        public static void Main(string[] args) {

            double initialBudget = 0;
            string[] expenseDescription;
            double[] expenseValue;
            int expenseCounter = 0;
            bool hasExpenses = true;

            while (hasExpenses) {
                Console.WriteLine("enter expense");
                double exp = double.Parse(Console.ReadLine);
                expenseValue[expenseCounter] = exp;

                Console.WriteLine("enter description");
                string desc = string.Parse(Console.ReadLine);
                expenseDescription[expenseCounter];

                expenseCounter++;

                Console.writeLine("do you have more? type y/n");
                string check = string.Parse(Console.ReadLine);
                if(check == "y") !hasExpenses;

            }
            for(int i = 0;i < expenseDescription.Length; i++) {
                Console.writeLine(expenseValue[i] + " " + expenseDescription[i] + "/n");
            }
            

        }
    }
}
