#region Question 1
// Create a book and put it in an object variable then print it

Book b1 = new Book();
b1.Title = "C# Guide";
b1.Pages = 150;

// Store book in object variable
object myBook = b1;

Console.WriteLine(myBook);
#endregion

#region Question 2
// Call ToString, Equals, GetHashCode, and GetType on the book object

Book b2 = new Book();
b2.Title = "Clean Code";
b2.Pages = 300;

// Printing results of basic object methods
Console.WriteLine(b2.ToString());
Console.WriteLine(b2.Equals(b2));
Console.WriteLine(b2.GetHashCode());
Console.WriteLine(b2.GetType());
#endregion

#region Question 3
// Error type: Compile-time error
// Fix: We cannot store string "464" directly in int variable, we must parse it to int

int pages = int.Parse("464");
Console.WriteLine(pages);
#endregion

#region Question 4
// Try to divide by zero, catch exception and print messages
var num1 = 10;
var num2 = 0;
try
{
    int divisionResult = num1 / num2;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}
#endregion

#region Question 5
// Store int in double without casting (Implicit conversion)

int page = 300;
double doublePages = page; // Automatically converts int to double

Console.WriteLine(doublePages);
#endregion

#region Question 6
// Convert double to int using explicit cast

double price = 49.99;
int intPrice = (int)price; // Casting double to int

Console.WriteLine(intPrice);
#endregion

#region Question 7
// Convert string to int using Convert class

string pagesText = "464";
int Pages = Convert.ToInt32(pagesText);

Console.WriteLine(Pages);
#endregion

#region Question 8
// Convert yearText using int.Parse and use TryParse for badText safely

string yearText = "2023";
int year = int.Parse(yearText);
Console.WriteLine(year);

string badText = "abc";
bool isSuccess = int.TryParse(badText, out int result);

if (isSuccess)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Invalid number");
}
#endregion

#region Question 9
// Convert int to string using ToString() and print its type using GetType()

int pages2 = 464;
string pagesText2 = pages.ToString();

Console.WriteLine(pagesText);
Console.WriteLine(pagesText.GetType());
#endregion

#region Question 10
// Boxing and Unboxing

int copies = 100;

// Boxing: int to object
object objCopies = copies;

// Unboxing: object to int
int newCopies = (int)objCopies;

Console.WriteLine(objCopies);
Console.WriteLine(newCopies);
#endregion

#region Question 11
// Check if book pages is greater than 300 using if / else

int pages3 = 464;

if (pages3 > 300)
{
    Console.WriteLine("Long Book");
}
else
{
    Console.WriteLine("Short Book");
}
#endregion

#region Question 12
// Check two conditions using && operator

int pages4 = 464;
bool isAvailable = true;

if (pages4 > 300 && isAvailable)
{
    Console.WriteLine("You can borrow this book");
}
#endregion

#region Question 13
// Switch statement to check book title

string title = "Refactoring";

switch (title)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;
    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;
    default:
        Console.WriteLine("Never heard of it");
        break;
}
#endregion

#region Question 14
// Ternary operator to check if pages > 300

int pages5 = 464;

string sizeLabel = (pages5 > 300) ? "Long Book" : "Short Book";

Console.WriteLine(sizeLabel);
#endregion

#region Question 15
// For loop to print books with position numbers

string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

for (int y = 0; y < books.Length; y++)
{
    Console.WriteLine((y + 1) + ". " + books[y]);
}
#endregion

#region Question 16
// While loop to print every book title

string[] books1 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

int i = 0;
while (i < books1.Length)
{
    Console.WriteLine(books1[i]);
    i++;
}
#endregion

#region Question 17
// Do-while loop to print 3 times

int count = 0;

do
{
    Console.WriteLine("Checking book...");
    count++;
} while (count < 3);
#endregion

#region Question 18
// Foreach loop to print every book title

string[] books3 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

foreach (string book in books3)
{
    Console.WriteLine(book);
}
#endregion

#region Question 19
// Loop through numbers and skip 3 using continue

for (int t = 1; t <= 5; t++)
{
    if (t == 3)
    {
        continue; // Skip the number 3
    }
    Console.WriteLine(t);
}
#endregion

#region Question 20
// Loop through numbers and stop at 3 using break

for (int l = 1; l <= 5; l++)
{
    if (l == 3)
    {
        break; // Stop the loop when l is 3
    }
    Console.WriteLine(l);
}
#endregion

#region Question 21
// Try-catch block to handle invalid input when parsing string to int

string invalidInput = "abc";

try
{
    int pages6 = int.Parse(invalidInput);
    Console.WriteLine(pages6);
}
catch (FormatException ex)
{
    Console.WriteLine("Error: Input string was not in a correct format.");
}
#endregion
// Simple Book class
public class Book
{
    public string Title;
    public int Pages;
}