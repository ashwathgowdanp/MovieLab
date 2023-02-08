// See https://aka.ms/new-console-template for more information

using MoviesLab;

List<Movie> movies= new List<Movie>()
{
    new Movie(1,"Scifi", "Inception", 120,2020, "Scifi Movie..."),
    new Movie(1,"Scifi", "Arrival", 140,2021, "Scifi Movie.."),
    new Movie(1,"Scifi", "Super 8", 134,2022, "Scifi Movie..."),
    new Movie(1,"Scifi", "Seventh Son", 121,2021, "Scifi Movie..."),
    new Movie(2,"Animated", "The Bad Guys",119,2022, "Animated Movie..."),
    new Movie(2,"Animated", "Strange World",126,2020, "Animated Movie..."),
    new Movie(2,"Animated", "Wonder Woman",128,2022, "Animated Movie..."),
    new Movie(2,"Animated", "Turning Red",100,20201, "Animated Movie..."),
    new Movie(3,"Drama", "Plane",116,2020, "Drama Movie..."),
    new Movie(3,"Drama", "Karen",107,2018,"Drama Movie..."),
    new Movie(3,"Drama", "Alice Darling",156,2018, "Drama Movie..."),
    new Movie(3,"Drama", "Forest Gump",111,2000, "Drama Movie..."),
    new Movie(4,"Horror", "Smile",120,2017, "Horror Movie..."),
    new Movie(4,"Horror", "Run",121,2020, "Horror Movie..."),
    new Movie(4,"Horror", "A Quiet Place",126,2021, "Horror Movie...")
};

Dictionary<int, string> MovieTypes = new();
MovieTypes.Add(1, "Scifi");
MovieTypes.Add(2, "Animated");
MovieTypes.Add(3, "Drama");
MovieTypes.Add(4, "Horror");

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine($"There are {MovieTypes.Count} Categories in the list.");
foreach(var mt in MovieTypes)
{
    Console.WriteLine($"{mt.Key}. {mt.Value}");
}
do
{
    Console.Write("What category are you interested in? Please enter the Number between 1 to " + MovieTypes.Count + "(including): ");
    string category = Console.ReadLine();
    
    var UserEnteredNumber = int.TryParse(category, out var UserEntered);

    if (UserEnteredNumber && UserEntered >= 1 && UserEntered <= MovieTypes.Count)
    {     
        
        movies = movies.OrderBy(x => x.title).ToList();        

        foreach(Movie x in movies)
        {
            if (x.id == UserEntered)
            {

                Console.WriteLine($"{x.title}- Released In: {x.YearReleased} Run time: {x.hours} minutes  {x.description}");

            }
        }

        
    }
    else
    {
        Console.Write("Please enter valid category.");
        goto UserPrompt;
    }

    UserPrompt:
    Console.Write("Would you like to continue (y/n):  ");
}while(Console.ReadLine().ToLower() == "y");

