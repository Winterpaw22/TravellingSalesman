using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Demo_TheTravelingSalesperson
{
    class ConsoleView
    {

        /// <summary>
        /// initialize all console settings
        /// </summary>
        private void InitializeConsole()
        {
            ConsoleUtil.WindowTitle = "Laughing Leaf Productions";
            ConsoleUtil.HeaderText = "The Traveling Salesperson Application";
        }

        /// <summary>
        /// display the Continue prompt
        /// </summary>
        public void DisplayContinuePrompt()
        {
            Console.CursorVisible = false;

            ConsoleUtil.DisplayMessage("");

            ConsoleUtil.DisplayMessage("Press any key to continue.");
            ConsoleKeyInfo response = Console.ReadKey();

            ConsoleUtil.DisplayMessage("");

            Console.CursorVisible = true;
        }

        /// <summary>
        /// display the Exit prompt on a clean screen
        /// </summary>
        public void DisplayExitPrompt()
        {
            ConsoleUtil.DisplayReset();

            Console.CursorVisible = false;

            ConsoleUtil.DisplayMessage("");
            ConsoleUtil.DisplayMessage("Thank you for using the application. Press any key to Exit.");

            Console.ReadKey();

            System.Environment.Exit(1);
        }


        /// <summary>
        /// display the welcome screen
        /// </summary>
        public void DisplayWelcomeScreen()
        {
            StringBuilder sb = new StringBuilder();

            ConsoleUtil.DisplayReset();

            ConsoleUtil.DisplayMessage("Written by John Velis");
            ConsoleUtil.DisplayMessage("Northwestern Michigan College");
            ConsoleUtil.DisplayMessage("");

            sb.Clear();
            sb.AppendFormat("You are a traveling salesperson buying and selling widgets ");
            sb.AppendFormat("around the country. You will be prompted regarding which city ");
            sb.AppendFormat("you wish to travel to and will then be asked whether you wish to buy ");
            sb.AppendFormat("or sell widgets.");
            ConsoleUtil.DisplayMessage(sb.ToString());
            ConsoleUtil.DisplayMessage("");

            sb.Clear();
            sb.AppendFormat("Your first task will be to set up your account details.");
            ConsoleUtil.DisplayMessage(sb.ToString());

            DisplayContinuePrompt();
        }
        /// <summary>
        /// Displays closing screen
        /// </summary>
        public void DisplayClosingScreen()
        {
            ConsoleUtil.DisplayReset();

            ConsoleUtil.DisplayMessage("Thank you for using The Traveling Salesperson Application.");

            DisplayContinuePrompt();
        }

        public ConsoleView()
        {

        }
        /// <summary>
        /// display the current account information
        /// </summary>
        public void DisplayAccountInfo(Salesperson salesperson)
        {
            ConsoleUtil.HeaderText = "Account Info";
            ConsoleUtil.DisplayReset();

            ConsoleUtil.DisplayMessage("First Name: " + salesperson.FirstName);
            ConsoleUtil.DisplayMessage("Last Name: " + salesperson.LastName);
            ConsoleUtil.DisplayMessage("Account ID: " + salesperson.AccountID);

            DisplayContinuePrompt();
        }
        /// <summary>
        /// Display all cities traveled to in chronological order
        /// </summary>
        /// <param name="salesperson"></param>
        public void DisplayCitiesTraveled(Salesperson salesperson)
        {
            ConsoleUtil.HeaderText = "CitiesVisited";
            ConsoleUtil.DisplayReset();
            ConsoleUtil.DisplayMessage("Cities you have visited:");
            int inc = 0;
            foreach (string city in salesperson.CitiesVisited)
            {
                inc++;
                ConsoleUtil.DisplayMessage(inc + ". " + city);

            }
            DisplayContinuePrompt();
        }


        /// <summary>
        /// prompts user for new city and returns it as a string
        /// </summary>
        /// <returns></returns>
        public string DisplayGetNextCity()
        {
            string city;
             
            ConsoleUtil.DisplayReset();

            ConsoleUtil.DisplayPromptMessage("Enter the city you wish to travel to: ");
            city = Console.ReadLine();
            ConsoleUtil.DisplayMessage("");

            DisplayContinuePrompt();
            return city;
        }

        /// <summary>
        /// get the menu choice from the user
        /// </summary>
        public MenuOption DisplayGetUserMenuChoice()
        {
            MenuOption userMenuChoice = MenuOption.None;
            bool usingMenu = true;

            while (usingMenu)
            {
                //
                // set up display area
                //
                ConsoleUtil.DisplayReset();
                Console.CursorVisible = false;

                //
                // display the menu
                //
                ConsoleUtil.DisplayMessage("Please type the number of your menu choice.");
                ConsoleUtil.DisplayMessage("");
                Console.Write(
                    "\t" + "1. Travel" + Environment.NewLine +
                    "\t" + "2. Display Cities" + Environment.NewLine +
                    "\t" + "3. Display Account Info" + Environment.NewLine +
                    "\t" + "E. Exit" + Environment.NewLine);
                //MenuHandler.ChoiceSelectionCursor(3,4,"Please type the number of your menu choice.","Travel","Display Cities");

                //
                // get and process the user's response
                // note: ReadKey argument set to "true" disables the echoing of the key press
                //
                ConsoleKeyInfo userResponse = Console.ReadKey(true);
                switch (userResponse.KeyChar)
                {
                    case '1':
                        userMenuChoice = MenuOption.Travel;
                        usingMenu = false;
                        break;
                    case '2':
                        userMenuChoice = MenuOption.DisplayCities;
                        usingMenu = false;
                        break;
                    case '3':
                        userMenuChoice = MenuOption.DisplayAccountInfo;
                        usingMenu = false;
                        break;
                    case 'E':
                    case 'e':
                        userMenuChoice = MenuOption.Exit;
                        usingMenu = false;
                        break;
                    default:
                        ConsoleUtil.DisplayMessage(
                            "It appears you have selected an incorrect choice." + Environment.NewLine +
                            "Press any key to continue or the ESC key to quit the application.");

                        userResponse = Console.ReadKey(true);
                        if (userResponse.Key == ConsoleKey.Escape)
                        {
                            usingMenu = false;
                        }
                        break;
                }
            }
            Console.CursorVisible = true;

            return userMenuChoice;
        }



        /// <summary>
        /// prompys user for all sales person information and returns a Salesperson object
        /// </summary>
        /// <returns></returns>


        public Salesperson DisplaySetupAccount()
        {
            Salesperson salesperson = new Salesperson();

            ConsoleUtil.HeaderText = "Account Setup";
            ConsoleUtil.DisplayReset();

            ConsoleUtil.DisplayMessage("Setup your account now.");
            ConsoleUtil.DisplayMessage("");

            ConsoleUtil.DisplayPromptMessage("First Name: ");
            salesperson.FirstName = Console.ReadLine();

            ConsoleUtil.DisplayPromptMessage("Last Name: ");
            salesperson.LastName = Console.ReadLine();

            ConsoleUtil.DisplayPromptMessage("Enter your account ID: ");
            salesperson.AccountID = Console.ReadLine();
            ConsoleUtil.DisplayMessage("");

            //ConsoleUtil.DisplayPromptMessage("Enter your starting City: ");
            //salesperson.CitiesVisited.Add(Console.ReadLine());
            //ConsoleUtil.DisplayMessage("");

            ConsoleUtil.DisplayMessage("");

            ConsoleUtil.DisplayReset();
            return salesperson;
        }
    }
}
