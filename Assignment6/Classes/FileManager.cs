/// <summary>
/// Filename: FileManager.cs
/// Created on: 2024-04-21 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using System.Text.Json;

namespace Assignment6.Classes
{
    internal class FileManager
    {
        public static void SaveToFile(File file, TaskManager taskManager)
        {
            string json = JsonSerializer.Serialize(taskManager.TaskList);
            System.IO.File.WriteAllText(file.Path, json);
        }

        public static void LoadFromFile(File file, TaskManager taskManager)
        {
            if (System.IO.File.Exists(file.Path))
            {
                string json = System.IO.File.ReadAllText(file.Path);
                taskManager.AddRange(JsonSerializer.Deserialize<List<Task>>(json)); //TODO: Add sanity check
            }
        }
    }
}
