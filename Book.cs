using System;

namespace COMP003A.Assignment6;

public class Book //class to track books by user
{
    //fields for the book
    public string Title;
    public int Pages;
    public bool Completed;
    
    //constructor to initialize the fields when book is created
    public Book(string title, int pages, bool completed)
    { 
        Title = title;
        Pages = pages;
        Completed = completed;
    }
    //action to display book info formated with the above fields
    public void DisplayInfo()
    {
        Console.WriteLine($"Title={Title}, Pages={Pages}, Completed={Completed}");
    } //this will work as a command to list out the book field for the target book
    //next a public void to update completion status.
    public void MarkCompleted()
    {
        Completed = true; //works since you can complete a book not the other way around.
    }

}