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
        /// <summary>
        /// 
        /// </summary>
        private List<Task> _taskList;
        #endregion
        #region Properties
        //TODO: Check setters!
        /// <summary>
        /// 
        /// </summary>
        public List<Task> TaskList
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
        #endregion
        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        public void AddNew(Task task)
        {
            TaskList.Add(task); //TODO: Add sanity check
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Change(Id id)
        {
            MessageBox.Show($"{id}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Id GetTaskId(Task task)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task GetTask(Id id)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{TaskList}"; //TODO: What does this do?
        }
        #endregion
    }
}
