//this class handles displaying info, and getting input from user.
public class View
{
    public void DisplayGames(List<Game> games)
    {
        //This method displays a list of games in the console.
        Console.WriteLine("Game list:");
        //Loops through each game in the games list
        foreach (var game in games)
        {
            //Foreach game, it prints title, year and genre. Using string interpolation.
            Console.WriteLine($"Title: {game.Title}, Year: {game.Year}, Genre: {game.Genre}");
        }
    }

    public string GetUserInput()
    {
        //method displaying promt to user, and returning input.
        Console.WriteLine("\nChoose an action: (1) Display games, (2) Add a new game, (3) Exit");
        return Console.ReadLine();
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}