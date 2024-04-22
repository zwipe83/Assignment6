﻿/// <summary>
/// Filename: FileManager.cs
/// Created on: 2024-04-21 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment6.Enums;
using System.Text.Json;

namespace Assignment6.Classes
{
    /// <summary>
    /// 
    /// </summary>
    internal class FileManager
    {
        #region Fields
        /// <summary>
        /// Field for storing of app token, of type <see cref="string"/>. A unique identifier to check file was saved by this application
        /// </summary>
        private const string appToken = "ToDo2024";
        /// <summary>
        /// Field for storing of file version, of type <see cref="double"/>
        /// </summary>
        private const double fileVersion = 1.0;
        #endregion
        #region Constructors
        /// <summary>
        /// Default FileManager constructor, creates an intance of <see cref="FileManager"/> with default values
        /// </summary>
        public FileManager()
        {
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Method for saving the contents of a <see cref="List{Task}"/> to a <see cref="File"/>. List contains instances of <see cref="Task"/>
        /// </summary>
        /// <param name="file"></param>
        /// <param name="taskList"></param>
        /// <returns>True if save was a success</returns>
        public bool SaveTaskListToFile(File file, List<Task> taskList)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                string fullPath = Path.Combine(file.Path, file.Name);
                writer = new StreamWriter(fullPath);
                writer.WriteLine(appToken);
                writer.WriteLine(fileVersion.ToString("F1"));
                writer.WriteLine(taskList.Count);

                for (int i = 0; i < taskList.Count; i++)
                {
                    writer.WriteLine(taskList[i].Date.TaskDate.Year);
                    writer.WriteLine(taskList[i].Date.TaskDate.Month);
                    writer.WriteLine(taskList[i].Date.TaskDate.Day);
                    writer.WriteLine(taskList[i].Time.TaskTime.Hours);
                    writer.WriteLine(taskList[i].Time.TaskTime.Minutes);
                    writer.WriteLine(taskList[i].Time.TaskTime.Seconds);
                    writer.WriteLine(taskList[i].Priority.TaskPriority.ToString());
                    writer.WriteLine(taskList[i].Description.TaskDescription);
                }
            }
            catch
            {
                ok = false;
                throw;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return ok; //TODO: Add message if it was success or not.
        }
        /// <summary>
        /// Method for reading the contents of a <see cref="File"/> and storing the read data to a <see cref="Task"/> instance. Instances are then stored in provided <see cref="List{Task}"/>
        /// </summary>
        /// <param name="file"></param>
        /// <param name="taskList"></param>
        /// <returns>True if read was a success</returns>
        public bool ReadTaskListFromFile(File file, List<Task> taskList)
        {
            bool ok = true;
            StreamReader reader = null;
            try
            {
                if (taskList != null)
                {
                    taskList.Clear();
                }
                else
                {
                    taskList = new List<Task>();
                }

                string fullPath = Path.Combine(file.Path, file.Name);
                reader = new StreamReader(fullPath);

                string appTokenTest = reader.ReadLine();
                bool av = double.TryParse(reader.ReadLine(), out double appVersionTest);

                if ((appTokenTest == appToken) && (appVersionTest == fileVersion))
                {
                    bool lc = int.TryParse(reader.ReadLine(), out int count);
                    for (int i = 0; i < count; i++)
                    {
                        Task task = new Task();

                        int year = 0, month = 0, day = 0;
                        int hour = 0, minute = 0, second = 0;

                        bool y = int.TryParse(reader.ReadLine(), out year);
                        bool mo = int.TryParse(reader.ReadLine(), out month);
                        bool d = int.TryParse(reader.ReadLine(), out day);
                        bool h = int.TryParse(reader.ReadLine(), out hour);
                        bool mi = int.TryParse(reader.ReadLine(), out minute);
                        bool s = int.TryParse(reader.ReadLine(), out second);

                        if (!(y || mo || d || h || mi || s)) //Failed to extract proper date data, try next one
                            continue;

                        string priority = reader.ReadLine() ?? "Normal";
                        string description = reader.ReadLine() ?? string.Empty;

                        task.Date = new Date(new DateTime(year, month, day));
                        task.Time = new Time(new TimeSpan(hour, minute, second));
                        task.Priority = new Priority((PriorityType)Enum.Parse(typeof(PriorityType), priority));
                        task.Description = new Description(description);

                        taskList.Add(task);
                    }
                }
            }
            catch
            {
                ok = false;
                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return ok;
        }
        /// <summary>
        /// Alternative method for saving data. Data is serialized to Json, then written to <see cref="File"/>
        /// </summary>
        /// <param name="file"></param>
        /// <param name="taskList"></param>
        public void SaveToJsonFile(File file, List<Task> taskList)
        {
            string fullPath = Path.Combine(file.Path, file.Name);
            string json = JsonSerializer.Serialize(taskList);
            System.IO.File.WriteAllText(fullPath, json);
        }
        /// <summary>
        /// Alternative method for reading data. Data is deserialized from Json, then stored in <see cref="List{Task}"/> as instances of <see cref="Task"/>
        /// </summary>
        /// <param name="file"></param>
        /// <param name="taskList"></param>
        public void ReadFromJsonFile(File file, List<Task> taskList)
        {
            string fullPath = Path.Combine(file.Path, file.Name);
            if (System.IO.File.Exists(fullPath))
            {
                string json = System.IO.File.ReadAllText(fullPath);
                taskList.AddRange(JsonSerializer.Deserialize<List<Task>>(json));
            }
        }
        #endregion
    }
}
