/// <summary>
/// Filename: FileManager.cs
/// Created on: 2024-04-21 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment6.Enums;

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
                    writer.WriteLine(taskList[i].Date.Date.Year);
                    writer.WriteLine(taskList[i].Date.Date.Month);
                    writer.WriteLine(taskList[i].Date.Date.Day);
                    writer.WriteLine(taskList[i].Time.Time.Hours);
                    writer.WriteLine(taskList[i].Time.Time.Minutes);
                    writer.WriteLine(taskList[i].Time.Time.Seconds);
                    writer.WriteLine(taskList[i].Priority.Priority.ToString());
                    writer.WriteLine(taskList[i].Description.Description);
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
            return ok; //FIXED: Add message if it was success or not.
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

                        task.Date = new TaskDate(new DateTime(year, month, day));
                        task.Time = new TaskTime(new TimeSpan(hour, minute, second));
                        task.Priority = new TaskPriority((PriorityType)Enum.Parse(typeof(PriorityType), priority));
                        task.Description = new TaskDescription(description);

                        taskList.Add(task);
                    }
                }
                else
                {
                    ok = false;
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
        #endregion
    }
}
