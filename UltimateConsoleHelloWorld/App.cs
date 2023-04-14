using HelloWorldLibrary.BusinessLogic;

namespace UltimateConsoleHelloWorld;

public class App
{
    private readonly IMessages _messages;

    public App(IMessages messages)
    {
        _messages = messages;
    }

    public void Run(string[] args)
    {
        string lang = "en";

        foreach (var t in args)
        {
            if (t.ToLower().StartsWith("lang="))
            {
                lang = t.Substring(5);
                break;
            }
        }

        string message = _messages.Greeting(lang);
        
        Console.WriteLine(message);
    }
}