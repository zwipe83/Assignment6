
using Assignment6.Enums;

/// <summary>
/// Filename: Priority.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 
namespace Assignment6.Classes
{
    internal class Priority
    {
        #region Fields
        private PriorityType _taskPriority;
        #endregion
        #region Properties
        public PriorityType TaskPriority
        {
            get => _taskPriority;
            set
            {
                if (value != null)
                {
                    _taskPriority = value;
                }
            }
        }
        #endregion
        #region Constructors
        public Priority() : this(PriorityType.Normal)
        {
        }
        public Priority(PriorityType priority)
        {
            TaskPriority = priority;
        }
        #endregion
        #region Overridden Methods
        public override string ToString()
        {
            return TaskPriority.ToString();
        }
        #endregion
    }
}
