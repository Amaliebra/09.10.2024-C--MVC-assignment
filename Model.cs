
public class Game
{
    //Get accessor returns the value of the Title. Set assigns a value to it.
    public string Title { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
}

//Defines a class named Model, whivh manages a collection of games.
public class Model
{
    //List of game objects. Get and set allows for retrieving and assigning from this list.
    public List<Game> Games { get; set; }

    //Constructor for the Model class. Runs when a instance of Model class is created.
    public Model()
    {
        Games = new List<Game>
        {
            //initializing s list with predefined game objects.
            new Game {Title = "Red Dead Redemption 2", Year = 2018, Genre = "Action Adventure Game"},
            new Game {Title = "Baldurs Gate 3", Year = 2023, Genre = "Roleplaying Game"},
            new Game {Title = "Terraria", Year = 2011, Genre = "Action Adventure Game"},
            new Game {Title = "Valheim", Year = 2021, Genre = "Survival Game"},
            new Game {Title = "Kenshi", Year = 2018, Genre = "Roleplaying Game"},
            new Game {Title = "Stardew Valley", Year = 2016, Genre = "Roleplaying Game"},
            new Game {Title = "Mount & Blade II: Bannerlord", Year = 2020, Genre = "Action Roleplaying Game"},
            new Game {Title = "Battlefield 1", Year = 2016, Genre = "First Person Shooter"},
            new Game {Title = "Cities Skylines", Year = 2015, Genre = "City Builder"}
        };


    }
    //AddGame method allows adding new games to the Games list
    public void AddGame(Game game)
    {
        //Takes the game parameter 
        Games.Add(game);
    }
}