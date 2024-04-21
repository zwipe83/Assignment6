/// <summary>
/// Filename: Id.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Id
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private Guid _taskId;
        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public Guid TaskId
        {
            get => _taskId;
            set
            {
                if (value != null) //TODO: Add check for date is not already passed
                {
                    _taskId = value;
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Id() : this(Guid.NewGuid())
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public Id(Guid id)
        {
            TaskId = id;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return TaskId.ToString();
        }
        #endregion
    }
}
