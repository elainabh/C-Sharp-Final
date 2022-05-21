using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TipCalculator
{
    public class fifteenPercentTip
    {
        tipMethods methods = new Methods();

        bool isRunning = true; }

        public void Run()
        {
            while(isRunning)
            {
                PrintMainMenu();
                string input = GetInputFromUser();
                UserInputSwitchCase(input);
            }

        private void PrintMainMenu()
        {
            Clear();
            Console.WriteLine(
                "/n1. Calculate bill w/ 15% tip."
            );
            Console.Write("Enter Selection: ");
        }

        private string GetInputFromUser()
        {
            return Console.ReadLine();
        }
        }
    }
