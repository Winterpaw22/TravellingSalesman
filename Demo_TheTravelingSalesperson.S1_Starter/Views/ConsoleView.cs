using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Demo_TheTravelingSalesperson
{
    class ConsoleView
    {

        private const int MAXIMUM_ATTEMPTS = 10;
        private const int MAXIMUM_BUYSELL_AMOUNT = 50;
        private const int MINIMUM_BUYSELL_AMOUNT = 0;




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
            ConsoleUtil.HeaderText = "Exit";
            ConsoleUtil.DisplayReset();

            Console.CursorVisible = false;

            ConsoleUtil.DisplayMessage("");
            ConsoleUtil.DisplayMessage("Thank you for using the application. Press any key to Exit.");

            Console.ReadKey();

            Environment.Exit(1);
        }


        /// <summary>
        /// display the welcome screen
        /// </summary>
        public void DisplayWelcomeScreen()
        {
            StringBuilder sb = new StringBuilder();

            ConsoleUtil.DisplayReset();

            ConsoleUtil.DisplayMessage("Written by John Sabins");
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
            string gender;
            if (salesperson.Gender)
            {
                gender = "Boy";
            }
            else
            {
                gender = "Girl";
            }
            ConsoleUtil.HeaderText = "Account Info";
            ConsoleUtil.DisplayReset();

            ConsoleUtil.DisplayMessage("First Name: " + salesperson.FirstName);
            ConsoleUtil.DisplayMessage("Last Name: " + salesperson.LastName);
            ConsoleUtil.DisplayMessage("Gender: " + gender);
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

        public MenuOption MainMenu()
        {
            MenuOption userMenuChoice = MenuOption.None;
            bool usingMenu = true;
            while (usingMenu)
            {
                MenuHandler.ChoiceSelectionCursor("");
            }





            return userMenuChoice;
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
            Console.Write("   Travelling to " + city);
            DisplayTriDotTimed();
            Console.CursorVisible = false;
            System.Threading.Thread.Sleep(1000);
            ConsoleUtil.DisplayMessage("You reached " + city + " City.");

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
                    "\t" + "2. Buy" + Environment.NewLine +
                    "\t" + "3. Sell" + Environment.NewLine +
                    "\t" + "4. Select a Different Product" + Environment.NewLine +
                    "\t" + "5. Display Inventory" + Environment.NewLine +
                    "\t" + "6. Display Cities" + Environment.NewLine +
                    "\t" + "7. Display Account Info" + Environment.NewLine +
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
                        userMenuChoice = MenuOption.Buy;
                        usingMenu = false;
                        break;
                    case '3':
                        userMenuChoice = MenuOption.Sell;
                        usingMenu = false;
                        break;
                    case '4':
                        userMenuChoice = MenuOption.SelectNewProduct;
                        usingMenu = false;
                        break;
                    case '5':
                        userMenuChoice = MenuOption.DisplayInventory;
                        usingMenu = false;
                        break;
                    case '6':
                        userMenuChoice = MenuOption.DisplayCities;
                        usingMenu = false;
                        break;
                    case '7':
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
                            userMenuChoice = MenuOption.Exit;
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
            string placehold;
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


            //logic is IfPartPresent then true
            //IfPartNotPresent then false
            salesperson.Gender = MenuHandler.ChoiceSelectionCursor("Are you a Boy, Or a Girl?", "Boy", "Girl");
            

            ConsoleUtil.DisplayPromptMessage("Enter your starting City: ");
            salesperson.CitiesVisited.Add(Console.ReadLine());

            salesperson.CurrentStock.Type = Product.ProductType.Spotted;
            ConsoleUtil.DisplayMessage("You start off selling spotted product");

            DisplayContinuePrompt();
            

            ConsoleUtil.DisplayReset();
            return salesperson;
        }

        public void DisplayProdToBuyandSell(Salesperson salesperson)
        {
            ConsoleUtil.HeaderText = "Choosing another product";
            ConsoleUtil.DisplayReset();
            Product.ProductType oldProduct = new Product.ProductType();

            oldProduct = salesperson.CurrentStock.Type;

            int attempts = 0;

            bool productSelected = false;

            while (MAXIMUM_ATTEMPTS > attempts && !productSelected)
            {
                ConsoleUtil.DisplayMessage("Enter on of the following products to buy and sell: ");
                ConsoleUtil.DisplayPromptMessage(Product.ProductType.Dancing.ToString() +
                    " " + Product.ProductType.Furry.ToString() + " " + Product.ProductType.Spotted.ToString() + " : ");
                string ProductType = Console.ReadLine();
                switch (UppercaseFirst(ProductType))
                {
                    case "Furry":
                        salesperson.CurrentStock.Type = Product.ProductType.Furry;
                        productSelected = true;
                        break;
                    case "Dancing":
                        salesperson.CurrentStock.Type = Product.ProductType.Dancing;
                        productSelected = true;
                        break;
                    case "Spotted":
                        salesperson.CurrentStock.Type = Product.ProductType.Spotted;
                        productSelected = true;
                        break;

                    default:
                        ConsoleUtil.DisplayMessage("You did not enter one of the Available products");
                        salesperson.CurrentStock.Type = Product.ProductType.None;
                        break;
                }
                attempts++;
            }

            if (oldProduct == salesperson.CurrentStock.Type)
            {
                ConsoleUtil.DisplayMessage("You decided not change the product you were selling");
            }
            else if (oldProduct != salesperson.CurrentStock.Type)
            {
                ConsoleUtil.DisplayMessage("You discard your " + oldProduct.ToString() + " product to make room for " + salesperson.CurrentStock.Type + " product.");
                salesperson.CurrentStock.ResetProductAmount();
            }
            DisplayContinuePrompt();
        }

        public void DisplayBackorderNotification(Product product, int numberOfUnitsSold)
        {
            ConsoleUtil.HeaderText = "Inventory Backorder Notification";
            ConsoleUtil.DisplayReset();

            int numberOfUnitsBackordered = Math.Abs(product.NumberOfUnits);
            int numberOfUnitsShipped = numberOfUnitsSold - numberOfUnitsBackordered;

            ConsoleUtil.DisplayMessage("Products Sold: " + numberOfUnitsSold);
            ConsoleUtil.DisplayMessage("Products Shipped: " + numberOfUnitsShipped);
            ConsoleUtil.DisplayMessage("Products on Backorder: " + numberOfUnitsBackordered);

            DisplayContinuePrompt();
        }


        #region buysell
        public int DisplayGetNumberOfUnitsToBuy(Product product)
        {
            ConsoleUtil.HeaderText = "Buy Inventory";
            ConsoleUtil.DisplayReset();

            //GEt number of products to buy

            ConsoleUtil.DisplayMessage("Buying " + product.Type.ToString() + " products.");
            ConsoleUtil.DisplayMessage("");

            if (!ConsoleValidator.TryGetIntegerFromUser(MINIMUM_BUYSELL_AMOUNT, MAXIMUM_BUYSELL_AMOUNT, MAXIMUM_ATTEMPTS,"products", out int numberOfUnitsToBuy))
            {
                ConsoleUtil.DisplayMessage("It appears you are having difficulty setting the number of products to buy.");
                ConsoleUtil.DisplayMessage("By default, the number of products to Buy will be set to zero.");
                numberOfUnitsToBuy = 0;
                DisplayContinuePrompt();
            }
            ConsoleUtil.DisplayReset();

            ConsoleUtil.DisplayMessage(numberOfUnitsToBuy + " " + product.Type.ToString() + " products have been added to the inventory.");

            DisplayContinuePrompt();

            return numberOfUnitsToBuy;
        }


        public int DisplayGetNumberOfUnitsToSell(Product product)
        {
            ConsoleUtil.HeaderText = "Sell Inventory";
            ConsoleUtil.DisplayReset();

            //get number of products to sell

            ConsoleUtil.DisplayMessage("Selling " + product.Type.ToString() + " products.");
            ConsoleUtil.DisplayMessage("");

            if (!ConsoleValidator.TryGetIntegerFromUser(MINIMUM_BUYSELL_AMOUNT, MAXIMUM_BUYSELL_AMOUNT, MAXIMUM_ATTEMPTS, "products", out int numberOfUnitsToSell))
            {
                ConsoleUtil.DisplayMessage("It appears you are having difficulty setting the number of products to Sell.");
                ConsoleUtil.DisplayMessage("By default, the number of products to sell will be set to zero.");
                numberOfUnitsToSell = 0;
                DisplayContinuePrompt();
            }

            ConsoleUtil.DisplayReset();

            ConsoleUtil.DisplayMessage(numberOfUnitsToSell + " " + product.Type.ToString() + " products have been subrtracted from the inventory.");

            DisplayContinuePrompt();

            return numberOfUnitsToSell;
        }
        #endregion

        public void DisplayInventory(Product product)
        {
            ConsoleUtil.HeaderText = "Current Inventory";
            ConsoleUtil.DisplayReset();


            ConsoleUtil.DisplayMessage("Product type: " + product.Type.ToString());
            ConsoleUtil.DisplayMessage("Number of units: " + product.NumberOfUnits.ToString());
            ConsoleUtil.DisplayMessage("");

            DisplayContinuePrompt();
        }


        static string UppercaseFirst(String s)
        {
            //Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            //return char and concatenation substring.
            return char.ToUpper(s[0]) + s.Substring(1).ToLower();
        }


        public void DisplayTriDotTimed()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
            Console.WriteLine("");
        }
    }
}
