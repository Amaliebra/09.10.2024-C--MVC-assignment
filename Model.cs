
public class Game
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
}

public class Model
{
    public List<Game> Games { get; set; }
    public Model()
    {
        Games = new List<Game>
        {
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

    public void AddGame(Game game)
    {
        Games.Add(game);
    }
}