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
    int result = num1 / num2;
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

// Simple Book class
public class Book
{
    public string Title;
    public int Pages;
}