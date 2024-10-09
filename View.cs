using System;
using System.Collections.Generic;
public class View
{
    public void DisplayGames(List<Game> games)
    {
        Console.WriteLine("Game list:");
        foreach (var game in games)
        {
            Console.WriteLine($"Title: {game.Title}, Year: {game.Year}, Genre: {game.Genre}");
        }
    }

    public string GetUserInput()
    {
        Console.WriteLine("\nChoose an action: (1) Display games, (2) Add a new game, (3) Exit");
        return Console.ReadLine();
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}