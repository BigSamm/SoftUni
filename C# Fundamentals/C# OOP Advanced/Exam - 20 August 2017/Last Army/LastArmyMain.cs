public class LastArmyMain
{
    static void Main()
    {
        ConsoleReader reader = new ConsoleReader();
        ConsoleWriter writer = new ConsoleWriter();
        GameController gameController = new GameController();

        Engine engine = new Engine(reader, writer, gameController);
        engine.Run();
    }
}