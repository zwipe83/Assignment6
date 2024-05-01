/// <summary>
/// Filename: TaskPriority.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment6.Enums;
using static Assignment6.Helpers.EnumHelper;

namespace Assignment6.Classes
{
    /// <summary>
    /// Represents a task priority.
    /// </summary>
    public class TaskPriority
    {
        #region Fields

        /// <summary>
        /// Field for storing of task priority, of type <see cref="PriorityType"/>
        /// </summary>
        private PriorityType _priority;

        /// <summary>
        /// Property for getting and setting value to private field <see cref="_priority"/>
        /// </summary>
        private static readonly PriorityType defaultPriority = PriorityType.Normal;
        #endregion
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public PriorityType Priority
        {
            get => _priority;
            protected set => _priority = value;
        }
        #endregion
        #region Constructors

        /// <summary>
        /// Default Priority constructor, creates an intance of <see cref="Classes.TaskPriority"/> with default values
        /// </summary>
        public TaskPriority() : this(defaultPriority)
        {
        }

        /// <summary>
        /// Priority constructor, creates an intance of <see cref="Classes.TaskPriority"/> with a specific <see cref="PriorityType"/> as parameter
        /// </summary>
        /// <param name="priority"></param>
        public TaskPriority(PriorityType priority)
        {
            Priority = priority;
        }
        #endregion
        #region Overridden Methods

        /// <summary>
        /// Overridden method for printing task priority to a <see cref="string"/>
        /// </summary>
        /// <returns>A string representation of the task priority.</returns>
        public override string ToString()
        {
            return GetDescription(Priority);
        }
        #endregion
    }
}
