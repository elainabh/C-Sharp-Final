using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KomodoCafe.Repository;

namespace KomodoCafe.ConsoleApp
{
    public class UserInterface
    {
        KomodoCafeRepository _repo = new KomodoCafeRepository();
        CustomConsole _console = new CustomConsole();

        bool isRunning = true;

        public void Run()
        {
            _repo.SeedMenuData();
            
            while(isRunning)
            {
                _console.PrintMainMenu();
                string userInput = _console.GetUserInput();

                UserInputPortal(userInput);
            }
        }

        private void UserInputPortal(string inputFromUser)
        {
            switch(inputFromUser)
            {
                case "1":
                CreateNewMenuItem();
                break;
                case "2":
                ViewAllMenuItems();
                break;
                case "3":
                DeleteMenuItem();
                break;
                case "4":
                Exit();
                break;
            }
        }

        private void CreateNewMenuItem()
        {
            _console.EnterAMealNumber();
            string mealNumberString = _console.GetUserInput();

            _console.EnterAMealName();
            string nameOfMeal = _console.GetUserInput();

            _console.EnterAMealDescription();
            string mealDescription = _console.GetUserInput();


            _console.EnterListOfIngredients();
            string listOfIngredients = _console.GetUserInput();

            _console.EnterPriceOfItem();
            string priceOfItem = _console.GetUserInput();

            //Constructor 

            Meal newMeal = new Meal(mealNumberString, nameOfMeal, mealDescription, listOfIngredients, priceOfItem);

            _repo.AddMealToDatabase(newMeal);

        }

        //Read
        private void ViewAllMenuItems()
        {
            List<Meal> allMeals = _repo.GetFullMenu();
            _console.PrintMenuItems(allMeals);
            _console.PressAnyKeyToContinue();
        }

        //Delete
        private void DeleteMenuItem()
        {
            _console.EnterAMealToDelete();
            string mealToDelete = _console.GetUserInput();

            Meal deletedMeal = _repo.GetMenuItemByName(mealToDelete);

            if (deletedMeal != null)
            {
                bool isSuccess = _repo.DeleteMenuItemFromDatabase(deletedMeal);
                
                if(isSuccess)
                {
                    _console.MealSuccessfullyDeleted(deletedMeal);
                }
                else
                {
                    _console.SomethingWentWrong();
                }
            }
            else
            {
                _console.MealNotFound();
            }
            _console.PressAnyKeyToContinue();
        }

        public void Exit()
        {
            isRunning = false;
            _console.ExitMessage();
        }

    }
}