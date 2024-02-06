//Create a console application that will help you track your expenses, and thus survive in this economy!
//Your app should be able to do the following
//- Prompt the user to enter the initial budget
//- Prompt the user to enter expenses with amount and description
//- Display the all expenses and the remaining amount

using System;
using System.Collections;

namespace budget {

    public class Program {
        public static void Main(string[] args) {

            double initialBudget = 0;
            //string[] expenseDescription;
            ArrayList expenseDescription = new ArrayList();
            ArrayList expenseValue = new ArrayList();
            int expenseCounter = 0;
            bool hasExpenses = true;

            while (hasExpenses) {
                Console.WriteLine("enter expense");
                double exp = Convert.ToDouble(Console.ReadLine());
                expenseValue.Add(exp);

                Console.WriteLine("enter description");
                string desc = Console.ReadLine();
                expenseDescription.Add(desc);

                expenseCounter++;

                Console.WriteLine("do you have more? type y/n");
                string check = Console.ReadLine();
                if(check == "n") hasExpenses = false;

            }
            for(int i = 0;i < expenseDescription.Length(); i++) {
                Console.WriteLine(expenseValue[i] + " " + expenseDescription[i] + "/n");
            }
            

        }
    }
}