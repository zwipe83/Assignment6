/// <summary>
/// Filename: TaskManager.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    internal class TaskManager
    {
        #region Fields
        private List<Task> _taskList;
        #endregion
        #region Properties
        //TODO: Check setters!
        public List<Task> TaskList
        {
            get => _taskList;
        }
        #endregion
        #region Constructors
        public TaskManager()
        {
            _taskList = new List<Task>();
        }
        #endregion
        #region Public Methods
        public void AddNew(Task task)
        {
            TaskList.Add(task); //TODO: Add sanity check
        }
        public void Change(int id)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public int GetTaskId(Task task)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Overridden Methods
        public override string ToString()
        {
            return $"{TaskList}"; //TODO: What does this do?
        }
        #endregion
    }
}
