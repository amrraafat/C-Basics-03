#region Question 1
// Create a book and put it in an object variable then print it

Book b1 = new Book();
b1.Title = "C# Guide";
b1.Pages = 150;

// Store book in object variable
object myBook = b1;

Console.WriteLine(myBook);
#endregion

// Simple Book class
public class Book
{
    public string Title;
    public int Pages;
}