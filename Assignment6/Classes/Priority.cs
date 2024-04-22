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
    /// <summary>
    /// 
    /// </summary>
    public class Priority
    {
        #region Fields
        /// <summary>
        /// Field for storing of task priority, of type <see cref="PriorityType"/>
        /// </summary>
        private PriorityType _taskPriority;
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_taskPriority"/>
        /// </summary>
        private static readonly PriorityType defaultPriority = PriorityType.Normal;
        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public PriorityType TaskPriority
        {
            get => _taskPriority;
            protected set => _taskPriority = value;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Priority constructor, creates an intance of <see cref="Priority"/> with default values
        /// </summary>
        public Priority() : this(defaultPriority)
        {
        }
        /// <summary>
        /// Priority constructor, creates an intance of <see cref="Priority"/> with a specific <see cref="PriorityType"/> as parameter
        /// </summary>
        /// <param name="priority"></param>
        public Priority(PriorityType priority)
        {
            TaskPriority = priority;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// Overridden method for printing task priority to a <see cref="string"/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GetDescription(TaskPriority);
        }
        #endregion
    }
}
