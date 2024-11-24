using static System.Console;

namespace FileHandler.src;

public class FileHandlers
{
    private string FilePath { get; }
    private const string Message = "File is being handled:";
    public FileHandlers(string filePath)
    {
        FilePath = filePath;
    }

    public void HandleFile()
    {
        if (!ValidateFilePath(out string validationMessage))
        {
            DisplayMessage(validationMessage, ConsoleColor.Red);
            return;
        }

        DisplayMessage($"{Message} {FilePath}", ConsoleColor.Green);
    }

    private bool ValidateFilePath(out string message)
    {
        if (!Path.IsPathFullyQualified(FilePath))
        {
            message = $"{FilePath} is not fully qualified.";
            return false;
        }

        if (!File.Exists(FilePath))
        {
            message = $"File {FilePath} does not exist!";
            return false;
        }

        message = string.Empty;
        return true;
    }

    private void DisplayMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        WriteLine(message);
        Console.ResetColor();
    }

}
