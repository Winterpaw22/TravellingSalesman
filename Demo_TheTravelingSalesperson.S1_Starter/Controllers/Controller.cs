﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Demo_TheTravelingSalesperson
{
    class Controller
    {
        #region FEILDS
        private ConsoleView _consoleView;
        private Salesperson _salesperson;
        private static bool _usingApplication;
        #endregion



        public Controller()
        {
            InitializeController();


            // instantiate a Salesperson object

            _salesperson = new Salesperson();

            //instantiate a ConsoleView object

            _consoleView = new ConsoleView();

            // begins running the application UI


            ManageApplicationLoop();


        }

        public void DisplayAccounInfo()
        {
            _consoleView.DisplayAccountInfo(_salesperson);
        }
        public void DisplayCities()
        {
            _consoleView.DisplayCitiesTraveled(_salesperson);
        }

        /// <summary>
        /// Initialize  the controller
        /// </summary>
        private void InitializeController()
        {
            _usingApplication = true;
        }
        /// <summary>
        /// methon do manage the application setup and control loop
        /// </summary>
        private void ManageApplicationLoop()
        {
            MenuOption userMenuChoice;

            _consoleView.DisplayWelcomeScreen();

            //Initial Salesperson account

            _salesperson = _consoleView.DisplaySetupAccount();


            //App loop
            while (_usingApplication)
            {
                //get a menu choice from the user
                userMenuChoice = _consoleView.DisplayGetUserMenuChoice();


                switch (userMenuChoice)
                {
                    case MenuOption.None:
                        break;
                    case MenuOption.Travel:
                        Travel();
                        break;
                    case MenuOption.DisplayCities:
                        DisplayCities();
                        break;
                    case MenuOption.DisplayAccountInfo:
                        DisplayAccounInfo();
                        break;
                    case MenuOption.Exit:
                        break;
                    default:
                        break;
                }
                
            }



            //Close the application
            Environment.Exit(1);
        }
        public void Travel()
        {
            string nextCity;
            
            nextCity = _consoleView.DisplayGetNextCity();

            _salesperson.CitiesVisited.Add(nextCity);
        }
    }
}