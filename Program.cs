using FileHandler.src;
using static System.Console;

string path = @"F:\Integrify-Post-Training\File Handling In C#\FileHandler/file.txt";
string path2 = @"..\file.txt";


FileHandlers fileHandler = new FileHandlers(path);
fileHandler.HandleFile();


