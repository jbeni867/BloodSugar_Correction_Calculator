//! Author: Jordy Benitez
//? Description: Simple script to return the amount of insulin needed to correct blood sugar to normal levels
//! Start Date: May 2, 2024

using Cocona;

CoconaLiteApp.Run(([Argument(Description = "User's current blood sugar", Name = "Blood Sugar")] double bloodSugar) =>
{
    const int desiredBloodSugar = 120;
    const int carbsPerUnit = 20;
    var result = (bloodSugar - desiredBloodSugar) / carbsPerUnit;
    double.Round(result, 2);
    Console.Write(result + " units.");
    Console.Read();
});