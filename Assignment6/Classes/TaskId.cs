/// <summary>
/// Filename: TaskId.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    /// <summary>
    /// Represents a task id.
    /// </summary>
    public class TaskId
    {
        #region Fields
        /// <summary>
        /// Field for storing of task id, of type <see cref="Guid"/>
        /// </summary>
        private Guid _id;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_id"/>
        /// </summary>
        public Guid Id
        {
            get => _id;
            protected set => _id = value;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Id constructor, creates an intance of <see cref="Classes.TaskId"/> with default values
        /// </summary>
        public TaskId() : this(Guid.NewGuid())
        {
        }
        /// <summary>
        /// Id constructor, creates an intance of <see cref="Classes.TaskId"/> with a specific <see cref="Guid"/> as parameter
        /// </summary>
        /// <param name="id"></param>
        public TaskId(Guid id)
        {
            Id = id;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// Overridden method for printing task id to a <see cref="string"/>
        /// </summary>
        /// <returns>A string representation of the task id.</returns>
        public override string ToString()
        {
            return Id.ToString();
        }
        #endregion
    }
}
