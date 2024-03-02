using System;
using System.IO;
using UnityEngine;

public class Logger
{
    private static string logFilePath = @"C:\\Users\\Welcome\\Desktop\\log.txt";

    public static void Log(string message)
    {
        Console.WriteLine(message); // Log ra terminal
        LogToFile(message); // Log vào tệp log
    }

    private static void LogToFile(string message)
    {
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine(message);
        }
    }
}