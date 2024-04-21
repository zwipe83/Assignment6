/// <summary>
/// Filename: Priority.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment6.Enums;
using static Assignment6.Helpers.EnumHelper;

namespace Assignment6.Classes
{
    public class Priority
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private PriorityType _taskPriority;
        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
        public Priority() : this(PriorityType.Normal)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="priority"></param>
        public Priority(PriorityType priority)
        {
            TaskPriority = priority;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GetDescription(TaskPriority);
        }
        #endregion
    }
}
