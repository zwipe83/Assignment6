/// <summary>
/// Filename: TaskManager.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 
namespace Assignment6.Classes
{
    /// <summary>
    /// Represents a task manager that manages a list of tasks.
    /// </summary>
    internal class TaskManager
    {
        #region Fields

        /// <summary>
        /// Field for storing of task list, of type <see cref="List{Task}"/>
        /// </summary>
        private List<Task> _taskList;
        #endregion
        #region Properties

        /// <summary>
        /// Property for getting and setting value to private field <see cref="_taskList"/>
        /// </summary>
        internal List<Task> TaskList
        {
            get => _taskList;
        }
        #endregion
        #region Constructors

        /// <summary>
        /// Default TaskManager constructor, creates an intance of <see cref="TaskManager"/> with default values
        /// </summary>
        public TaskManager()
        {
            _taskList = new List<Task>();
        }

        /// <summary>
        /// Copy constructor. Copies from one instance of <see cref="TaskManager"/> to a new instance of <see cref="TaskManager"/>
        /// </summary>
        public TaskManager(TaskManager objToCopyFrom)
        {
            _taskList = objToCopyFrom.TaskList;
        }
        #endregion
        #region Public Methods

        /// <summary>
        /// Methods adds a new task of type <see cref="Task"/> to <see cref="TaskManager.TaskList"/>
        /// </summary>
        /// <param name="newTask"></param>
        public void AddNewTask(Task newTask)
        {
            if (TaskList == null || newTask == null)
            {
                return;
            }

            TaskList.Add(newTask);
        }

        /// <summary>
        /// Methods changes an existing task of type <see cref="Task"/> in <see cref="TaskManager.TaskList"/>
        /// </summary>
        /// <param name="editTask"></param>
        public void ChangeTask(Task editTask)
        {
            int index = TaskList.FindIndex(item => item.Id == editTask.Id);

            if (index != -1)
            {
                TaskList[index] = editTask;
            }
        }

        /// <summary>
        /// Methods deletes a task of type <see cref="Task"/> from <see cref="TaskManager.TaskList"/>
        /// </summary>
        /// <param name="taskId"></param>
        public void DeleteTask(TaskId taskId)
        {
            int index = TaskList.FindIndex(item => item.Id == taskId);

            if (index != -1)
            {
                TaskList.RemoveAt(index);
            }
        }

        /// <summary>
        /// Methods finds a specific task of type <see cref="Task"/> from <see cref="TaskManager.TaskList"/>, using a specific <see cref="Task.Id"/>
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public Task GetTask(TaskId taskId)
        {
            foreach (Task task in TaskList)
            {
                if (task.Id == taskId)
                {
                    return task;
                }
            }

            return null;
        }

        /// <summary>
        /// Method saves current <see cref="TaskList"/> to provided file of type <see cref="File"/>
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
        /// Method reads to current <see cref="TaskList"/> from provided file of type <see cref="File"/>
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
                    throw new Exception($"Failed to read the file:\n\n{fullPath}\n\nBad application token and/or file version?");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion
        #region Overridden Methods

        /// <summary>
        /// Overridden method for printing task list to a <see cref="string"/>
        /// </summary>
        /// <returns>A string representation of the task list.</returns>
        public override string ToString()
        {
            return $"{TaskList}";
        }
        #endregion
    }
}
