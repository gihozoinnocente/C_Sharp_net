// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

float baseSalary = 5000;
float hra = 0.30F;

float netSalary = (baseSalary - (baseSalary * hra));
Console.WriteLine("Base Salary:" + baseSalary);
Console.WriteLine("Net Salary:" + netSalary);

int a = 5;
int b = 10;
int c = (a + b);
Console.WriteLine("sum is:" + c);

int temperature = 50;
if (temperature < 20)
    Console.WriteLine("Its cold outside");
else
    Console.WriteLine("Its Moderate outside");

bool isLoggedIn = true;
bool isEmailVerified = true;
bool cardInfo = true;

if (isLoggedIn && isEmailVerified && cardInfo)
    Console.WriteLine("You are authenticated!");
else
    Console.WriteLine("You are not authenticated");
// CONDITIONAL STATEMENTS

//conditional statements are based on certain conditions and generate decisions accordingly
//these statements are a bunch of codes that can be executed by "decisions statements"
//these conditions have some specific "boolean expressions"

bool isAuthenticated = true;
if (isAuthenticated)
    Console.WriteLine("You are logged in");
else
    Console.WriteLine("You're not logged in");

//isAuthenticated ? "You are logged In" : "You are not logged In";

string userType = "admin";
switch (userType)
{
    case "admin":
        Console.WriteLine("You have full access");
        break;

    case "subadmin":
        Console.WriteLine("You can create or delete courses");
        break;

    case "user":
        Console.WriteLine("You can access the courses");
        break;

    default:
        Console.WriteLine("Trial User.");
        break;
}


//DO WHILE
int i = 0;
string[] names = { "Volvo", "BMW", "Ford", "Mazda" };
do
{
    Console.WriteLine(names[i]);
    i++;
} while (i < names.Length);

//For Each
foreach (string name in names)
    Console.WriteLine(name);

//LOOPS

//loops are used to execute a block of code repeatedly until a certain condition is met
//used to repeat a block of statements for certain times
//a loop statement continue its execution until the specified expression evaluates to false 
// while ,do-while,for,foreach


string[] kings = new string[5] { "king", "sarah", "John", "Roger", "James" };

for (int y = 0; y < kings.Length; y++)
{
    Console.WriteLine(kings[y]);
}

for (int y = 4; y >= 0; y--)
{
    Console.WriteLine(kings[y]);
}


//While loops
int x = 0;

while (x < kings.Length)
{
    Console.WriteLine(kings[x]);
    x++;
}

//JUMP STATEMENTS

//jump statements are keywords that allows you to control the flow of execution in a program
//these are used to transfer program control from one point to another point in the program
//they are 5 keywords in jump statements: break,continue,goto,return,throw

//Arrays: single array,multidimensional array,jagged array
//collection of elements of same data type that are stored in contiguous memory location
//single dimensional array is also known as one row for storing data
//it has single set of square bracket("[]")

//multi-dimensional array:contains more than one row to store data on it,also known as recyangle array.
//Jagged array is an array of arrays where each sub-array can have different length. used to store a collection of arrays of different sizes

//example of multidimensional array
int[,] s = new int[3, 3];

//example of jagged array
int[][] myArray = new int[3][];
myArray[0] = new int[2] { 1, 2 };
myArray[1] = new int[3] { 3, 4, 5 };
myArray[2] = new int[4] { 6, 7, 8, 9 };

int[] marks = new int[5];
marks[0] = 25;
marks[1] = 50;
marks[2] = 55;
marks[3] = 60;
marks[4] = 40;

// foreach (int mark in marks)
//     Console.WriteLine(mark);

// for (int i = 0; i < marks.Length; i++)
//     Console.WriteLine(marks[0]);

// int[,] mutliArray = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };

// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         Console.WriteLine(multiArray[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

//Strings and strings method
//string is an object of system.string class represent sequence of characters

//types of string
//immutable strings => System.String class, they can't be modifies
//mutable string => String Builder class, they can be modified

//String Methods
// Functions    Description
//Clone()       Make clone of strings
//CompareTo()   compare two strings and returns integer value as output
//Contains()    It checks whether specified character exists or not in the string value
//EndsWith()    checks if the string ends with the given string
//Equals()      compare two strings and returns boolean value as out put
//ToUpper()     converts the string to uppercase
//ToLower()     convert the string to lowercase
//Insert()      insert a string or character in the string at the specified position
//IndeOf()      returns the index position of first occurrence of specified character

//Manipulating strings && //initialise string

string s1 = "hello";
string s2 = "welcome";
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s1.Length);
Console.WriteLine(s1.Concat(s2));
Console.WriteLine(s1.Equals(s2));

//Immutable string
string str1 = "C# Programming";
string str2 = "Java Programming";

//Mutable String

//using System.Text;
//StringBuilder string_name = null;
// StringBuilder stringBuilder = new StringBuilder(); //Instantiation
// stringBuilder.Append("C# Programming");
// stringBuilder.Append("Java");

//Fundamental concept of object oriented programming language: Encapsulation, Inheritance,Abstraction, Polymorphism.
//Acces modifier
//Constructors

//Object oriented concept: classes,objects,encapsulation,abstraction,inheritance,polymorphism(one interface multiple function)
Console.WriteLine("Welcome to object oriented programming");

//classes are blue print or template for creating objects
//defines the properties and behavior of an object
//class can have fields,properties,methods and events


// Constructors
// it is a special method that is used to initialize an object of a class
// it is similar to a method that is involed when an object of the class is created
//However, unkike methods, a constructor: has the same name as that of the class, does not have any return type

//Types of constructors
//default
//parameterized
public Student(int sid, string sName)
{
    studentId = sId;
    studentName = sName;
}
//copy
//private
//static

//Inhertance
//possible to inherit fields and methods from one class to another
//define new class based on an existing class
//new class inherits the properties and methods of the existing class and can also add new properties and methods of its own
//it promotes code reuse, simplifies code maintenance, and improves code organization


//POLYMORPHISM
//C# Compile-time Polymorphism can be achieved in two ways: Method Overloading && Constuctor overloading


//Example of Method overriding: cannot be imlememnted without class ,defines same method as defined in its base class,
class ConsolePrinter
{
    public void Print(string str){
        Console.WriteLine(str);
    }
    public void Print(string str1, string str2){
        Console.WriteLine($"{str1},{str2}");
    }
    public void Print(string str1, string str2, string str3){
        Console.WriteLine($"{str1},{str2},{str3}");
    }
}

//ABSTRACT CLASS: cannot be intiated, it serves as a base class for other classes to inherit from, they are used to define a common set of properties that derived classes should have

abstract class Test{


}
Test obj = new Test()

//ABSTRACT CLASS: can have both abstract methods(method without body) and non-abstract methods(method with the boody)

abstract class Test {
    //abstract method
    public abstract void display1();

    //non-abstract method
    public void display2(){
        Console.WriteLine("Non abstract method")
    }
}

namespace coreObjectOrientedConcepts