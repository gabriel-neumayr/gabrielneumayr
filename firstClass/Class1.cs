
public class Movie
{

    public string title;
    public int minAge; 
    public string category;
    private int year = 2005;
    private int myAge;

    public void printtitlecategory(string title, string category)
    {
        Console.WriteLine(title + category);
        
        myAge = (2022 - year);

        if ( myAge >= minAge)
        {
            Console.WriteLine("Can Watch!");
        }
        else
        {
            Console.WriteLine("Sorry to jung");
        }
    }

    public Movie(string title, int minAge, string category)
    {
        this.title = title;
        this.minAge = minAge;
        this.category = category;
        this.year = year;
    }
}

