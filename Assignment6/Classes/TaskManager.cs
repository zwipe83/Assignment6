/// <summary>
/// Filename: TaskManager.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 
namespace Assignment6.Classes
{
    /// <summary>
    /// 
    /// </summary>
    internal class TaskManager
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private List<Task> _taskList;
        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        internal List<Task> TaskList
        {
            get => _taskList;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public TaskManager()
        {
            _taskList = new List<Task>();
        }
        /// <summary>
        /// 
        /// </summary>
        public TaskManager(TaskManager objToCopyFrom)
        {
            _taskList = objToCopyFrom.TaskList;
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        public void AddNew(Task task)
        {
            if (TaskList == null || task == null)
            {
                return;
            }

            TaskList.Add(task);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        public void AddRange(List<Task> tasks) //TODO: Use this instead?
        {
            TaskList.AddRange(tasks);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Change(Task task)
        {
            int index = TaskList.FindIndex(item => item.Id == task.Id);

            if (index != -1)
            {
                TaskList[index] = task;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Delete(Id id)
        {
            int index = TaskList.FindIndex(item => item.Id == id);

            if (index != -1)
            {
                TaskList.RemoveAt(index);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task GetTask(Id id)
        {
            foreach (Task task in TaskList)
            {
                if (task.Id == id)
                {
                    return task;
                }
            }

            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        public void SaveToFile(File file)
        {
            try
            {
                string fullPath = Path.Combine(file.Path, file.Name);
                FileManager fileManager = new FileManager();
                if (fileManager.SaveTaskListToFile(file, TaskList))
                {
                    MessageBox.Show($"File saved successfully to:\n\n{fullPath}");
                }
                else
                {
                    throw new Exception($"Failed to save the file:\n\n{fullPath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        public void ReadFromFile(File file)
        {
            try
            {
                string fullPath = Path.Combine(file.Path, file.Name);
                FileManager filemanager = new FileManager();
                if (filemanager.ReadTaskListFromFile(file, TaskList))
                {
                    MessageBox.Show($"File loaded successfully from:\n\n{fullPath}");
                }
                else
                {
                    throw new Exception($"Failed to read the file:\n\n{fullPath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        public void SaveToJsonFile(File file)
        {
            FileManager fileManager = new FileManager();
            fileManager.SaveToJsonFile(file, TaskList);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        public void ReadFromJsonFile(File file)
        {
            FileManager fileManager = new FileManager();
            fileManager.ReadFromJsonFile(file, TaskList);
        }

        #endregion
        #region Overridden Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{TaskList}"; //TODO: What does this return?
        }
        #endregion
    }
}
