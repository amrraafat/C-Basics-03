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

// Simple Book class
public class Book
{
    public string Title;
    public int Pages;
}