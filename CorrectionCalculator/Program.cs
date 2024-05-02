//* Author: Jordy Benitez
//* Start Date: May 2, 2024

using Cocona;
CoconaLiteApp.Run((double bloodSugar = 235) =>
{
    const int desiredBloodSugar = 120;
    const int carbsPerUnit = 20;
    double result = (bloodSugar - desiredBloodSugar) / carbsPerUnit;
    double.Round(result, 2);
    Console.WriteLine(result);
});