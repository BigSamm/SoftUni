using System;
using System.Text;

public class Engine
{
    private ConsoleReader reader;
    private ConsoleWriter writer;
    private GameController gameController;

    public Engine(ConsoleReader reader, ConsoleWriter writer, GameController gameController)
    {
        this.reader = reader;
        this.writer = writer;
        this.gameController = gameController;
    }

    public void Run()
    {
        var input = reader.ReadLine();
        var result = new StringBuilder();

        while (!input.Equals("Enough! Pull back!"))
        {
            try
            {
                gameController.GiveInputToGameController(input);
            }
            catch (ArgumentException arg)
            {
                result.AppendLine(arg.Message);
            }

            input = reader.ReadLine();
        }

        gameController.RequestResult(result);
        writer.WriteLine(result.ToString());
    }
}