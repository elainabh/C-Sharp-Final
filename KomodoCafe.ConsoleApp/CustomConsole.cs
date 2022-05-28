using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoCafe.Repository;

namespace KomodoCafe.ConsoleApp
{
    public class CustomConsole
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("1. Add Menu Item \n 2. See All Menu Items \n 3. Delete Menu Items \n 4. Exit \n");
        }
        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public void EnterAMealName()
        {
            Console.WriteLine("Enter a name for the menu item you'd like to add: \n");
        }

        public void EnterAMealNumber()
        {
            Console.WriteLine("Enter a number for the menu item you'd like to add: \n");
        }

        public void EnterAMealDescription()
        {
            Console.WriteLine("Enter a description of the meal: \n");
        }

        public void EnterListOfIngredients()
        {
            Console.WriteLine("Enter a list of ingredients: \n");
        }

        public void EnterPriceOfItem()
        {
            Console.WriteLine("Enter price of item: \n");
        }

        public void PrintMenuItem(Meal meal)
        {
            Console.WriteLine($"# {meal.MenuItemNumber} \nmeal name: {meal.MealName} \ndescription: {meal.MealDescription} \nlist of ingredients: {meal.ListOfIngredients} \n price: ${meal.PriceOfItem}");
        }

        public void PrintMenuItems(List<Meal> meal)
        {
            foreach (Meal x in meal)
            {
                PrintMenuItem(x);
            }
        }
        public void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void EnterAMealToDelete()
        {
            Console.WriteLine("Enter the name of the meal you'd like to delete: \n");
        }

        public void MealSuccessfullyDeleted(Meal deletedCustomer)
        {
            Console.WriteLine($"{deletedCustomer.MealName} successfully deleted.");
        }

        public void SomethingWentWrong()
        {
            Console.WriteLine("Something went wrong...");
        }

        public void MealNotFound()
        {
            Console.WriteLine("Meal Not Found. Press any key to continue...");
            Console.ReadKey();
        }

        public void ExitMessage()
        {
            Console.WriteLine("Come back soon :P");
        }
    }
}