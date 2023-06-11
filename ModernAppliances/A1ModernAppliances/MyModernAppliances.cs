﻿using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");

            // Create long variable to hold item number
            long itemNumber;

            // Get user input as string and assign to variable.
            string userInput = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.
            if (long.TryParse(userInput, out itemNumber))
            {
                // Create 'foundAppliance' variable to hold appliance with item number
                // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
                Appliance? foundAplliance = null;

                // Loop through Appliances
                // Test appliance item number equals entered item number
                foreach (Appliance appliance in Appliances)
                {
                    if (appliance.ItemNumber == itemNumber)
                    {
                        // Assign appliance in list to foundAppliance variable
                        foundAplliance = appliance;
                        // Break out of loop (since we found what need to)
                        break;
                    }
                }

                // Test appliance was not found (foundAppliance is null)
                if (foundAplliance == null)
                {
                    // Write "No appliances found with that item number."
                    Console.WriteLine("No appliances found with that item number.\n\n");
                }
                // Otherwise (appliance was found)
                else
                {
                    // Test found appliance is available
                    if (foundAplliance.IsAvailable)
                    {
                        // Checkout found appliance
                        foundAplliance.Checkout();
                        // Write "Appliance has been checked out."
                        Console.WriteLine($"Appliance {foundAplliance.ItemNumber} has been checked out.\n\n");
                    }
                    // Otherwise (appliance isn't available)
                    else
                    {
                        // Write "The appliance is not available to be checked out."
                        Console.WriteLine("The appliance is not available to be checked out.\n\n");
                    }
                }
            }
        }
            

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string enteredBrand = Console.ReadLine();

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliance = new List<Appliance>();

            // Iterate through loaded appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test current appliance brand matches what user entered
                if (appliance.Brand.Equals(enteredBrand, StringComparison.OrdinalIgnoreCase))
                {
                    // Add current appliance in list to found list
                    foundAppliance.Add(appliance);
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(foundAppliance, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"
            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Double doors");
            Console.WriteLine("3 - Three doors");
            Console.WriteLine("4 - Four doors");
            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");
            // Create variable to hold entered number of doors
            int numOfDoors;
            // Get user input as string and assign to variable
            String userInput = Console.ReadLine();
            // Convert user input from string to int and store as number of doors variable.
            if (int.TryParse(userInput, out numOfDoors))
            {
                // Create list to hold found Appliance objects
                List<Appliance> foundAppliance = new List<Appliance>();

                // Iterate/loop through Appliances
                foreach (Appliance appliance in Appliances)
                {
                    // Test that current appliance is a refrigerator
                    if (appliance is Refrigerator)
                    {
                        // Down cast Appliance to Refrigerator
                        Refrigerator refrigerator = (Refrigerator)appliance;

                        // Test user entered 0 or refrigerator doors equals what user entered.
                        if (numOfDoors == 0 | refrigerator.Doors == numOfDoors)
                        {
                            // Add current appliance in list to found list
                            foundAppliance.Add(appliance);
                        }
                    }

                }
                // Display found appliances
                DisplayAppliancesFromList(foundAppliance, 0);
            }
            
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Residential"
            Console.WriteLine("1 - Residential");
            // Write "2 - Commercial"
            Console.WriteLine("2 - Commercial");
            // Write "Enter grade:"
            Console.WriteLine("Enter grade: ");
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;
            // Test input is "0"
            if (userInput == "0")
            {
                // Assign "Any" to grade
                grade = "Any";
            }
            // Test input is "1"
            else if (userInput == "1")
            {
                // Assign "Residential" to grade
                grade = "Residential";
            }
            // Test input is "2"
            else if (userInput == "2")
            {
                // Assign "Commercial" to grade
                grade = "Commercial";
            }
            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling (previous) method
                return;
            }


            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - 18 Volt"
            Console.WriteLine("1 - 18 Volt");
            // Write "2 - 24 Volt"
            Console.WriteLine("2 - 24 Volt");
            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage: ");
            // Get user input as string
            string voltageInput = Console.ReadLine();  
            // Create variable to hold voltage
            int voltage = 0;
            // Test input is "0"
            if (voltageInput == "0")
            {
                // Assign 0 to voltage
                voltage = 0;
            }
            // Test input is "1"
            else if (voltageInput == "1")
            {
                // Assign 18 to voltage
                voltage = 18;
            }
            // Test input is "2"
            else if (voltageInput == "2")
            {
                // Assign 24 to voltage
                voltage = 24;
            }
            // Otherwise
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling (previous) method
                return;
            }
            // Create found variable to hold list of found appliances.
            List<Appliance> foundAppliance = new List<Appliance>();
            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Check if current appliance is vacuum
                if (appliance is Vacuum)
                {
                    // Down cast current Appliance to Vacuum object
                    Vacuum vacuum = (Vacuum)appliance;
                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                    if (grade == "Any" || (grade == vacuum.Grade && (voltage == 0 || voltage == vacuum.BatteryVoltage)))
                    {
                        // Add current appliance in list to found list
                        foundAppliance.Add(appliance);
                    }
                }

            }
            // Display found appliances
            DisplayAppliancesFromList(foundAppliance, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Kitchen"
            Console.WriteLine("1 - Kitchen");
            // Write "2 - Work site"
            Console.WriteLine("2 - Work site");
            // Write "Enter room type:"
            Console.WriteLine("Enter room type: ");
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();
            // Create character variable that holds room type
            char roomType;
            // Test input is "0"
            if (userInput == "0")
            {
                // Assign 'A' to room type variable
                roomType = 'A';
            }
            // Test input is "1"
            else if (userInput == "1")
            {
                // Assign 'K' to room type variable
                roomType = Microwave.RoomTypeKitchen;

            }
            // Test input is "2"
            else if (userInput == "2")
            {
                // Assign 'W' to room type variable
                roomType = Microwave.RoomTypeWorkSite;
            }
            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalide option.");
                // Return to calling method
                return;
            }
            // Create variable that holds list of 'found' appliances
            List<Appliance> foundAppliance = new List<Appliance>();
            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test current appliance is Microwave
                if (appliance is Microwave)
                {
                    // Down cast Appliance to Microwave
                    Microwave microwave = (Microwave)appliance;
                    // Test room type equals 'A' or microwave room type
                    if (roomType == 'A' || roomType == microwave.RoomType)
                    {
                        // Add current appliance in list to found list
                        foundAppliance.Add(appliance);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(foundAppliance, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Quietest"
            Console.WriteLine("1 - Quietest");
            // Write "2 - Quieter"
            Console.WriteLine("2 - Quieter");
            // Write "3 - Quiet"
            Console.WriteLine("3 - Quiet");
            // Write "4 - Moderate"
            Console.WriteLine("4 - Moderate");
            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating:");
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();
            // Create variable that holds sound rating
            string soundRating;
            // Test input is "0"
            if (userInput == "0")
            {
                // Assign "Any" to sound rating variable
                soundRating = "Any";

            }
            // Test input is "1"
            else if (userInput == "1")
            {
                // Assign "Qt" to sound rating variable
                soundRating = Dishwasher.SoundRatingQuietest;
            }
            // Test input is "2"
            else if (userInput == "2")
            {
                // Assign "Qr" to sound rating variable
                soundRating = Dishwasher.SoundRatingQuieter;
            }
            // Test input is "3"
            else if (userInput == "3")
            {
                // Assign "Qu" to sound rating variable
                soundRating = Dishwasher.SoundRatingQuiet;
            }
            // Test input is "4"
            else if (userInput == "4")
            {
                // Assign "M" to sound rating variable
                soundRating = Dishwasher.SoundRatingModerate;
            }
            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling method
                return;
            }
            // Create variable that holds list of found appliances
            List<Appliance> foundAppliance = new List<Appliance>();
            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test if current appliance is dishwasher
                if (appliance is Dishwasher)
                {
                    // Down cast current Appliance to Vacuum object
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    if (soundRating == "Any" || soundRating == dishwasher.SoundRating)
                    {
                        // Add current appliance in list to found list
                        foundAppliance.Add(appliance);
                    }
                }
            }
                // Display found appliances (up to max. number inputted)
                DisplayAppliancesFromList(foundAppliance, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 – Refrigerators"
            Console.WriteLine("1 – Refrigerators");
            // Write "2 – Vacuums"
            Console.WriteLine("2 – Vacuums");
            // Write "3 – Microwaves"
            Console.WriteLine("3 – Microwaves");
            // Write "4 – Dishwashers"
            Console.WriteLine("4 – Dishwashers");
            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance:");
            // Get user input as string and assign to appliance type variable
            string applianceType = Console.ReadLine();
            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances: ");
            // Get user input as string and assign to variable
            string numOfApplianceInput = Console.ReadLine();
            // Convert user input from string to int
            int numOfAppliance;
            int.TryParse(numOfApplianceInput, out numOfAppliance);
            // Create variable to hold list of found appliances
            List<Appliance> foundAppliances = new List<Appliance>();
            // Loop through appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test inputted appliance type is "0"
                if (applianceType == "0")
                {
                    // Add current appliance in list to found list
                    foundAppliances.Add(appliance);
                }
                // Test inputted appliance type is "1"
                else if (applianceType == "1")
                {
                    // Test current appliance type is Refrigerator
                    if (appliance is Refrigerator)
                    {
                        // Add current appliance in list to found list
                        foundAppliances.Add(appliance);
                    }
                }
                // Test inputted appliance type is "2"
                else if (applianceType == "2")
                {
                    // Test current appliance type is Vacuum
                    if (appliance is Vacuum)
                    {
                        // Add current appliance in list to found list
                        foundAppliances.Add(appliance);
                    }
                }
                // Test inputted appliance type is "3"
                else if (applianceType == "3")
                {
                    // Test current appliance type is Microwave
                    if (appliance is Microwave)
                    {
                        // Add current appliance in list to found list
                        foundAppliances.Add(appliance);
                    }
                }
                // Test inputted appliance type is "4"
                else if (applianceType == "4")
                {
                    // Test current appliance type is Dishwasher
                    if (appliance is Dishwasher) 
                    {
                        // Add current appliance in list to found list
                        foundAppliances.Add(appliance);
                    }
                }
            }
            // Randomize list of found appliances
            foundAppliances.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(foundAppliances, numOfAppliance);
        }
    }
}
