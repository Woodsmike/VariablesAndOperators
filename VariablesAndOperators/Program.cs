using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Mike";
            //Console.WriteLine(name);

            //int birthMonth = 6;
            //Console.WriteLine(birthMonth);


            //floating point types
            //float, double and decimal
            //float floatNumber = 2.164403304897294849383961032f;
            //Console.WriteLine(floatNumber);
            //double doubleNumber = 2.164403304897294849383961032d;
            //Console.WriteLine(doubleNumber);
            //decimal decimalNumber = 2.164403304897294849383961032m;
            //Console.WriteLine(decimalNumber);

            /*Console.WriteLine("What is the name on the reservation?");
            string reserveName = Console.ReadLine();

            Console.WriteLine("How many people are in your party");
            int numberOfPeople = int.Parse(Console.ReadLine());

            double amountEach = 13d;
            double totalBill = numberOfPeople * amountEach;
            Console.WriteLine(totalBill);

            Console.WriteLine("Reservation: " + reserveName);
            Console.WriteLine("Total Due: $" + totalBill);
            */
            Console.WriteLine("What is your Name?");
            string nameOfDonor = (Console.ReadLine());
            Console.WriteLine("What is your address?");
            string donorAddress = (Console.ReadLine());
            Console.WriteLine("What is you email address?");
            string donorEmail = (Console.ReadLine());
            Console.WriteLine("For which fiscal year?");
            string fiscalYear = (Console.ReadLine());



            Console.WriteLine("How much do you want to donate?");
            Console.WriteLine ("How many ones?");
            int numberOfOnes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many fives?");
            int numberOfFives = int.Parse(Console.ReadLine());
            Console.WriteLine("How many tens?");
            int numberOfTens = int.Parse(Console.ReadLine());
            Console.WriteLine("How many twenties?");
            int numberOfTwenties = int.Parse(Console.ReadLine());
            Console.WriteLine("How many fifties?");
            int numberOfFifties = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hundreds?");
            int numberOfHundreds = int.Parse(Console.ReadLine());
            Console.WriteLine("How many quarters?");
            double numberOfQuarters = double.Parse(Console.ReadLine());

            double totalDonationAmount = (numberOfOnes + (numberOfFives * 5) +
                (numberOfTens * 10) + (numberOfTwenties * 20) + (numberOfFifties * 50) +
                (numberOfHundreds * 100) + (numberOfQuarters * .25));

            Console.WriteLine("Donor Name: " + nameOfDonor);
            Console.WriteLine("Donor Address: " + donorAddress);
            Console.WriteLine("Donor Email address: " + donorEmail);
            Console.WriteLine("Fiscal year: " + fiscalYear);
            Console.WriteLine("Total amount of donations: $" + totalDonationAmount);
        }
    }
}
