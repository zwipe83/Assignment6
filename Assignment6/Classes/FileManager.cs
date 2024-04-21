/// <summary>
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
        private const string appToken = "ToDo2024";
        private const double appVersion = 1.0;
        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public FileManager()
        {
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="taskList"></param>
        /// <returns></returns>
        public bool SaveTaskListToFile(File file, List<Task> taskList)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                string fullPath = Path.Combine(file.Path, file.Name);
                writer = new StreamWriter(fullPath);
                writer.WriteLine(appToken);
                writer.WriteLine(appVersion.ToString("F1"));
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
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return ok;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="taskList"></param>
        /// <returns></returns>
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

                if ((appTokenTest == appToken) && (appVersionTest == appVersion))
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
                        string priority = reader.ReadLine();
                        string description = reader.ReadLine();

                        task.Date.TaskDate = new DateTime(year, month, day);
                        task.Time.TaskTime = new TimeSpan(hour, minute, second);
                        task.Priority.TaskPriority = (PriorityType)Enum.Parse(typeof(PriorityType), priority);
                        task.Description = new Description(description);

                        taskList.Add(task);
                    }
                }
            }
            catch
            {
                ok = false;
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="taskList"></param>
        public void ReadFromJsonFile(File file, List<Task> taskList)
        {
            string fullPath = Path.Combine(file.Path, file.Name);
            if (System.IO.File.Exists(fullPath))
            {
                string json = System.IO.File.ReadAllText(fullPath);
                taskList.AddRange(JsonSerializer.Deserialize<List<Task>>(json)); //TODO: Add sanity check
            }
        }
        #endregion
    }
}
