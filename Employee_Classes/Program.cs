// See https://aka.ms/new-console-template for more information
using Employee_Classes;

    Console.WriteLine("----- Welcome to Employee Management System -----\n");
    Console.WriteLine("Press ENter to Continue...");
    Console.ReadKey();

CalEmpwage dmart = new CalEmpwage("Dmart", 20, 20, 100);
dmart.Find_Wage();
Console.WriteLine(dmart.toString());


CalEmpwage Amazon = new CalEmpwage("Amazon", 40, 20, 100);
Amazon.Find_Wage();
Console.WriteLine(Amazon.toString());

