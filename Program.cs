using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.ComponentModel.Design;

namespace ModernAppliances
{
    /// <summary>
    /// Displays Vacuums
    /// </summary>
    /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
    /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
    public override void DisplayVacuums()
    {
        // Write "Possible options:"
        Console.WriteLine("Possible options: ");

        // Write "0 - Any"
        // Write "1 - Residential"
        // Write "2 - Commercial"

        Console.WriteLine("0 - Any");
        Console.WriteLine("1 - Residential");
        Console.WriteLine("2 - Commercial");

        // Write "Enter grade:"
        Console.WriteLine("Enter Grade");

        // Get user input as string and assign to variable
        string VacInput = Console.ReadLine();
        // Create grade variable to hold grade to find (Any, Residential, or Commercial)
        string grade = "";
        
        if (VacInput == "0")
        {
            grade = "Any";
        }
        else if (VacInput == "1")
        {
            grade = "Residential";
        }
        else if (VacInput) == "2")
        {
            grade = "Commercial";
        }
        else {
            Console.WriteLine("Invalid option");
        }
        // Test input is "0"
        // Assign "Any" to grade
        // Test input is "1"
        // Assign "Residential" to grade

        // Test input is "2"
        // Assign "Commercial" to grade
        // Otherwise (input is something else)
        // Write "Invalid option."

        // Return to calling (previous) method
        // return;
        return; 
        // I DONT UNDERSTANDDDD THIS PART HELLP

        // Write "Possible options:"
        Console.WriteLine("Possible options:");

        // Write "0 - Any"
        // Write "1 - 18 Volt"
        // Write "2 - 24 Volt"
        Console.WriteLine("0 - Any");
        Console.WriteLine("1 - 18 Volts");
        Console.WriteLine("2 - 24 Volts");


        // Write "Enter voltage:"
        Console.WriteLine("Enter voltage");

        // Get user input as string
        string VolInput = Console.ReadLine();

        // Create variable to hold voltage
        string Voltage = VolInput;
        // Test input is "0"
        // Assign 0 to voltage

        // Test input is "1"
        // Assign 18 to voltage

        // Test input is "2"
        // Assign 24 to voltage

        // Otherwise
        // Write "Invalid option."
        if (VolInput == "0")
        {
            grade = "Voltage";
        }
        else if (VolInput == "1")
        {
            grade = "18";
        }
        else if (VolInput) == "2")
        {
            grade = "24";
        }
        else
        {
            Console.WriteLine("Invalid option");
        }
        // Return to calling (previous) method
        // return;
        return;
        // Create found variable to hold list of found appliances.
        List<Appliances> list = new List<Appliances>();
        // Loop through Appliances
        foreach (Appliance appliance in Appliances)
        {
            // Check if current appliance is vacuum
            if (appliance is vacuum)
            {
                // Down cast current Appliance to Vacuum object
                Appliance appliance = (Vacuum)appliances;
            }
        }
        

        // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
        if (grade =="Any"|| (grade == currentVacGrade && (voltage == currentVacGrade)))
        {
            // Add current appliance in list to found list
            currentVacGrade.Add(appliance);
        }

        // Display found appliances
        DisplayAppliancesFromList(foundAppliance, 0);
    





}

