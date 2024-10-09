public class Controller
{
    //private field, for internal use. Will manage the data.
    private Model _model;
    //Will handle input/output
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }
    //contains main logic of the program. Will run until exit is typed in console.
    public void Run()
    {
        bool exit = false;
        while (!exit)
        {
            string choice = _view.GetUserInput();
            switch (choice)
            {
                case "1":
                    _view.DisplayGames(_model.Games);
                    break;

                case "2":
                    AddNewGame();
                    break;

                case "3":
                    exit = true;
                    _view.ShowMessage("Exiting the program");
                    break;

                default:
                    _view.ShowMessage("Invalid. Try again");
                    break;
            }
        }
    }

    private void AddNewGame()
    {
        Console.Write("Enter the game title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the game year: ");
        int year;
        while (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Enter a valid year");
        }

        Console.Write("Enter the game genre");
        string genre = Console.ReadLine();

        _model.AddGame(new Game { Title = title, Year = year, Genre = genre });
        _view.ShowMessage($"Game '{title}' added successfully");
    }
}