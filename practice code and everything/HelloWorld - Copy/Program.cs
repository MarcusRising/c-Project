// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello Everyone in the world!");

//Console.WriteLine("This is a new line of text");
//Console.WriteLine("Please enter your name:  ");

//string name = Console.ReadLine(); // holds the value you type

//Console.WriteLine(name);
//Console.WriteLine("Your name is " + name); //Test comment
//////////////////////////////////////////////////////////////////////////
//Console.WriteLine("Hello");
//Console.WriteLine("What is your first name?: ");
//string firstName = Console.ReadLine();

//Console.WriteLine("What is your last name");
//string lastName = Console.ReadLine();

//Console.WriteLine("Hello " +firstName + " " + lastName);
/////////////////////////////////////////////////////////////////////////// 

//string name = Console.ReadLine();
//string name1 = Console.ReadLine();
//string 2name = Console.ReadLine();        //cant start variable with a number it wont work

///////////////////////////////////////////////////////////////////////////

//int a = 2;
//int b = a + 3;
//Console.WriteLine(b); // prints 5
/////////////////////////////////////////////////////////////////////////// 

//int monthlyWage = 1200, months = 12, bonus = 1000;

//const double profitMargin = 0.17D;

//double rating = 98.2; // float number?
//decimal price = 100.0m;
//byte numberOfEmployees = 25; // byte can only hold 0-256

//int hoursWorked;

//hoursWorked = 120;
//hoursWorked = 14;
/////////////////////////////////////////////////////////////////////////

//int month = 3;
//month += 1;
//Console.WriteLine(month);

///////////////////////////////////////////////////////////////////////
/*
using System;

double rateperhour = 12.34;

int numberofhoursworked = 40;

double currentmonthwage = rateperhour * numberofhoursworked;
Console.WriteLine(currentmonthwage);

if (currentmonthwage > 300)
    Console.WriteLine("Top Paid Employee");
*/
///////////////////////////////////////////////
/*
int intMaxValue = int.MaxValue;
int intMinValue = int.MinValue;

char userSelection = 'a';
char upperVersion = char.ToUpper(userSelection);

bool isDigit = char.IsDigit(userSelection);

bool isLetter = char.IsLetter(userSelection);

bool isWhiteSpave = char.IsWhiteSpace(userSelection);

Console.ReadLine();
*/
///////////////////////////////////////////////

/*
DateTime today = DateTime.Now;
Console.WriteLine(today);

DateTime hireDate = new DateTime(2022, 12, 20, 14,30,0);  // year , month , day , hour , minute , second
Console.WriteLine(hireDate);

DateTime exitDate = new DateTime(2025, 12, 11);
Console.WriteLine(exitDate);

DateTime startDate = hireDate.AddDays(15);
Console.WriteLine(startDate);

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 30, 0);
DateTime endHour = startHour.Add(workTime);

Console.WriteLine(startHour);
Console.WriteLine(endHour);
*/
/////////////////////////////////////////////////////////////////////////
/*
 * Challenge 
**First, create a variable of type DateTime named startDate and set it, in the same statement, 
*to a new date: March 05, 2022. Use the 3 argument constructor to do so.**

DateTime startDate1 = new DateTime(2022, 3, 5);

**Second, create a second DateTime variable named endDate. Set its value, 
*again in the same statement, to today's date. The time component should be set to 00:00:00.**


DateTime endDate = DateTime.Today;
endDate = endDate.Date;
Console.WriteLine(endDate);
 */

/////////////////////////////////////////////////////////////

/*
int a = 123456;
long l = a;
Console.WriteLine(l);

double d = 12345.0;
int b = (int)d;
Console.WriteLine(b);

int hourWorked = 156;

long veryLongMonth = hourWorked;

double e = 123454356.1;

int x = (int)e;
Console.WriteLine(x);
*/
/////////////////////////////////////////////////////////////


// Implicit typing
/*
var a = 123;   //int
var b = true;  // bool
var c = 11.0; //double
var hire = new DateTime(2023, 1, 23);

Console.ReadLine();

*/
////////////////////////////////////////////////////////////////////

// Problem and solution to the Sum Calculation //

/*
Console.WriteLine("Enter a first value: ");
string stringValue1 = Console.ReadLine();
Console.WriteLine("Enter a second value: ");
string stringValue2 = Console.ReadLine();
int intValue1 = int.Parse(stringValue1);
int intValue2 = int.Parse(stringValue2);
var sum = intValue1 + intValue2;
Console.WriteLine(sum);
*/


//////////////////////////////////////////////////////


/*
var age = 25;
bool a = age == 25;
Console.WriteLine("Age is 23: " +a);

bool b = age > 25;
Console.WriteLine("Age B is greater then 25: "+b);

bool c = (age >= 18) && (age <= 65);
Console.WriteLine("Age is between 18 and 65: " + c);

int age1 = 16;
int age2 = 64;
bool d = (age1 >= 18) && (age1 <= 65);
Console.WriteLine("Age 1 is greater then 18 and less then 65: " + d);
bool e = (age2 >= 18) || (age2 <= 65);
Console.WriteLine("Age 2 is Greater then 18 OR less then 65: " + e);
*/

////////////////////////////////////////////////////////////////////

/*
int age = 68;

if (age < 18)
{
    Console.WriteLine("Too young to apply");
}
else if (age > 65)
{
    Console.WriteLine("Too old to apply");
}
else
{
    Console.WriteLine("Thank you for applying");
}
*/

//////////////////////////

/*
Console.WriteLine("Please enter age: ");
int age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("Too young to apply");
    Console.WriteLine("Send Email to Candidate");
}
else if (age > 65)
{
    Console.WriteLine("Too Old to apply");
    Console.WriteLine("Send Email to Candidate");
}
else
{
    Console.WriteLine("You can start the application");
}
*/
///////////////////////////////////////////////////////////


// Problem and solution to comparing to values entered by a user
/*
Console.WriteLine("Enter a first number");
string stringValue1 = Console.ReadLine();
int intValue1 = int.Parse(stringValue1);

Console.WriteLine("Enter a second number");
string stringValue2 = Console.ReadLine();
int intValue2 = int.Parse(stringValue2);


if (intValue1 == intValue2)
{
    Console.WriteLine("The values are equal!");
}
else if (intValue1 < intValue2)
{
    Console.WriteLine("The first value is smaller!");
}
else
{
    Console.WriteLine("The second value is smaller!");
}

*/

///////////////////////////////////////////////////////////
///

/*
Console.WriteLine("Please enter your age: ");
int userAge = int.Parse(Console.ReadLine());


switch (userAge)
{
    case < 18:
        Console.WriteLine("Too young to apply");
        break;

    case > 65:
        Console.WriteLine("Too old to apply");
        break;

    default:
        Console.WriteLine("Great please continue");
        break;
}
*/

/////////////////////////////////////////////////////

/*
do
{
    Console.WriteLine("Choose the action you want to do: ");
    Console.WriteLine("1: Add employee");
    Console.WriteLine("2: Update employee");
    Console.WriteLine("3: Delete employee");
    Console.WriteLine("99: Exit");
    string selectedAction = Console.ReadLine();

    switch (selectedAction)
    {
    case "1":
        Console.WriteLine("Adding new employee");
        break;
    case "2":
        Console.WriteLine("Updating employee");
        break;
    case "3":
        Console.WriteLine("Deleting employee");
        break;
    default: 
        Console.WriteLine("Invalid Input");
        break;
    }
} while (selectedAction != "99");
Console.WriteLine("Closing App");

*/

/////////////////////////////////////////////////////

/*
Console.WriteLine("Enter a number: ");
int max = int.Parse(Console.ReadLine());
int i = 1;
while (i <= max)
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine("Loop over!");
*/


///////////////////////////////////////////////////////////

/*
int i = 0;
int j = 0;
while (i < 10)
{
    while (j < 10)
    {
        Console.WriteLine("i: " + i + " j: " + j);
        j++;
    }
    j = 0;
    i++;
}

*/


///////////////////////////////////

// Excercise 4 creating loops
/*
Console.WriteLine("Enter a value:");
int sum = 0;
string stringValue = Console.ReadLine();
int startValue = int.Parse(stringValue);

for (int i = startValue; i > 0; i--)
{
    sum += i;
    Console.WriteLine(i);
}

Console.WriteLine("The sum is " + sum);

*/


////////////////////////////////////////

/*
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 10);
*/

//////////////////////////////////////////////

/*
 
int sum = 0;
for(int i = 1; i < 11; i++)
{
    sum = sum + i;
    Console.WriteLine(i);
}
Console.WriteLine("The sum is: "+sum);

*/

/////////////////////////////////////////////


/*
Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());   

for (int i = 1; i <= max; i++)
{
    if(i == 5)
    {
        Console.WriteLine("You found the magic number: " + i);
        continue; // Continue the loop continues // break stops the loop // 
    }
    Console.WriteLine(i);
}

*/

////////////////////////////////////////////////////////

//Checkpoint 23 - for loop 
/*
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("End of loop");
*/

////////////////////////////////////////////////////////
/*
int AddTwoNumbers(int a , int b)
{
    return a + b;
}

Console.WriteLine(AddTwoNumbers(3, 4));

*/
/////////////////////////////////////////////////////

/*
Check point 27
public class Utilities
{
    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }
    public static int AddNumbers(int a, int b, int c)
    {
        return a + b + c;
    }
}
*/
//////////////////////////////////////////////////
/*
public class something
{
    public static double SomeMethod()
    {
        double value = 0.04;
        return value;
    }
}
*/

//////////////////////////////////////////////////

/*
int addNumbers(int a, int b, int c = 100)
{
    int sum = a + b + c;
    Console.WriteLine(sum);
    return sum;
    
}
addNumbers(a: 10, b: 20);
addNumbers(2, 2);
addNumbers(1, 2, 4);

*/
////////////////////////////////////////////////

//Excercise 6 : methods and their parameters

/*
using System;
public class Utilities
{
    public static int CalculateYearlyWage(int monthlyWage, bool giveBonus = true)
    {
        if (giveBonus)
        {
            return monthlyWage * 12 + 1000;
        }
        else
        {
            return monthlyWage * 12;
        }
    }
     public static void Main(string[] args)
    {
        int monthlySalary = 2000;
        int yearlyWageWithBonus = CalculateYearlyWage(monthlySalary); // Calls the method with default bonus (true)
        Console.WriteLine($"Yearly wage with bonus: {yearlyWageWithBonus}");

        int yearlyWageWithoutBonus = CalculateYearlyWage(monthlySalary, false); // Calls the method without bonus
        Console.WriteLine($"Yearly wage without bonus: {yearlyWageWithoutBonus}");
    }
}

*/

//////////////////////////////////////////////////////////////

//Check point 30: Expression Bodied

/*
public class Utilities
{
    public static int CalculateYearlyWage(int monthlyWage, int months)
    {
        return monthlyWage * months;
    }
//converted
    
    public static int CalculateYearlyWage1(int monthlyWage, int months) => monthlyWage * months;
    
}
*/
////////////////////////////////////////////////////////////

//More string stuff
/*
string myString = "Long stuff";

int l = myString.Length;
string upper = myString.ToUpper();
string lower = myString.ToLower();
bool b = myString.Contains("Long");
string s = myString.Replace("u", "o");
string t = myString.Substring(1, 3);
Console.WriteLine(s);
Console.WriteLine(t);
Console.WriteLine(b);
Console.WriteLine(lower);
Console.WriteLine(upper);
Console.WriteLine(l);
*/

/*
string employeeName = "Bob";
var age = 34;
var gretting = $"Helllo {employeeName} you are {age} years old";
Console.WriteLine(gretting);

string a = string.Concat(employeeName+age);
Console.WriteLine(a);
*/
//////////////////////////////////////////////////////////////

//Excercise 07 Remove Vowels
//Solution 1 

/*
public class Utilities
{
    public static string RemoveVowels(string input)
    {
        // Using LINQ to filter out vowels
        string result = new string(input.Where(c => !"aeiouyAEIOUY".Contains(c)).ToArray());
        return result;
    }

    // Example usage
    public static void Main(string[] args)
    {
        string inputString = "Hello, World!";
        string stringWithoutVowels = RemoveVowels(inputString);
        Console.WriteLine($"Input string without vowels: {stringWithoutVowels}");
    }
}
*/

//Solution 2 

/*
public class Utilities
{
    public static string RemoveVowels(string input)
    {
        string result = string.Empty;

        result = input.Replace("a", "")
                          .Replace("e", "")
                          .Replace("i", "")
                          .Replace("o", "")
                          .Replace("u", "")
                          .Replace("y", "");
        return result;
    }
}

*/

////////////////////////////////////////////////////////

/*
string escapedChar = "C:\\Documents\\readme.txt";
Console.WriteLine(escapedChar);
string verbatimFilePath = @"C:\Documents\readme.txt"; //@ ignores escape characters
Console.WriteLine(verbatimFilePath);
*/



///////////////////////////////////

//Exercise 8  - String Equality

//My Solution 

/*
public static bool CheckIfStringsAreEqual(string a, string b)

{
    bool answer;
    answer = a.ToLower() == b.ToLower();
    Console.WriteLine(answer);
    return answer;
}
*/

////////////////////////////////////////////

// Using Parse to Generate A value from a string
// parse do loop
// excersie 30 
/*
int i;
do
{
    Console.WriteLine("Enter the number of employees: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out i))
    {
        Console.WriteLine("Success! Added employees: " + i);
        break; 
    }
    else
    {
        Console.WriteLine("Failed to parse value: " + input + ". Please enter an integer value.");
    }
}while (true);

*/

/////////////////////////////////////////////

/*
public class Employee
{
    public string firstName; 
    public int age;
    public void MyMethod()
    {
        Console.WriteLine("Hello World");
    }
}

*/
//////////////////////////////////////////

//Checkpoint 38 - class and methods 
//solution to the problem


/*
public class Employee
{
    public string name;
    public int age;
    public int numberOfHoursWorked = 0;

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee name: {name} - Age: {age} - Number of hours worked: {numberOfHoursWorked};");
    }
    public void Work(int hours, bool resetHours)
    {
        if (resetHours)
            numberOfHoursWorked = 0;
        numberOfHoursWorked += hours;
    }
}

*/


////////////////////////////////////////////////

//excercise 9 - Vehicle class and objects

/*
 
public class Vehicle
{
    public int currentMileage;
    public string model;
    public string color;

    public Vehicle()
    {
    }

    public Vehicle(int currentMileage, string model, string color)
    {
        this.currentMileage = currentMileage;
        this.model = model;
        this.color = color;
    }

    public void Drive()
    {
        currentMileage++;
    }

    public void Drive(int miles)
    {
        if (miles > 0)
            currentMileage += miles;
    }

    public string DisplayVehicleDetails()
    {
        return $"Model: {model} - Color: {color} - Current mileage: {currentMileage}";
    }
}


public class Utilities
{
    public static Vehicle CreateAndUseVehicle()
    {
        Vehicle vehicle = new Vehicle(100, "BMW", "Black");

        vehicle.Drive(10);

        vehicle.color = "Red";

        return vehicle;
    }
}

*/

//////////////////////////////////////////////


//string a;
//string b;
//a = "hello";
//b = a;
//b += " world";
//Console.WriteLine("a = {0}", a);
//Console.WriteLine(b);




/////////////////////////////

/*
using System.Text;

/// Check point 44


StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Welcome ");
stringBuilder.Append("to ");
stringBuilder.AppendLine("Bethany's Pie Shop!");
stringBuilder.Append("Please log in!");
Console.WriteLine(stringBuilder.ToString());
*/


///////////////////////////////

//Check point 45 : Enum 1
//public enum Colors()
//{
//  Red,
//  Green,
//  Blue
//}


///////////////////////////////


//Check point 46 : Enum 2
//public enum Colors
//{
//  Red = 5,
//  Green = 8,
//  Blue = 10
//}

///////////////////////////////

/* 
 
Working with struct
* Represents a custom data structure
* Value type
* can be new'ed


struct WorkTast
{
    public string description;
    public int hours;

    public void PerformWorkTask()
    {
    //Code to perform work
    }
}
*/

/////////////////////////////////////////////////////

//Exercise 13 - static solution 

//public class Utilities
//{
//    public static int ChangeMaxSpeed()
//    {
//        int newMaxSpeed = 0;

//        int increaseAmount = 10;

//        Vehicle.IncreaseMaxSpeed(increaseAmount);

//        newMaxSpeed = Vehicle.maxSpeed;

//        return newMaxSpeed;

//    }
//}

/////////////////////////////////////////////////////
/*
Create a for loop which loops over all elements of the myValues array.

Use i as the iterator for the loop, and initialize it to 0.
The for loop should run as many times as we have elements in the array. Use i < myValues.Length for this.
In the body of the for loop, write each element of the array to the Console using the WriteLine() method.
Add only the for loop, no code outside of it, and there must be exactly one statement–the WriteLine()–in the loop.
*/

//int[] myvalues = new int[] { 5, 15, 25, 35, 45 };
//for (int i = 0; i < myvalues.length; i++)
//{
//    console.writeline(myvalues[i]);
//}

////////////////////////////////////////