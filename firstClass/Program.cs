Movie movie1 = new Movie("Es", 18, "Horror");
Movie movie2 = new Movie("Starwars", 12, "Action");

Console.WriteLine(movie1.title + ", " + movie1.minAge + ", "  + movie1.category);
Console.WriteLine(movie2.title + ", " + movie2.minAge + ", " + movie2.category);

movie1.printtitlecategory(movie1.title, movie1.category);
movie2.printtitlecategory(movie2.title, movie2.category);

