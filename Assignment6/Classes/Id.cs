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
        /// Field for storing of task id, of type <see cref="Guid"/>
        /// </summary>
        private Guid _taskId;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_taskId"/>
        /// </summary>
        public Guid TaskId
        {
            get => _taskId;
            protected set => _taskId = value;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Id constructor, creates an intance of <see cref="Id"/> with default values
        /// </summary>
        public Id() : this(Guid.NewGuid())
        {
        }
        /// <summary>
        /// Id constructor, creates an intance of <see cref="Id"/> with a specific <see cref="Guid"/> as parameter
        /// </summary>
        /// <param name="id"></param>
        public Id(Guid id)
        {
            TaskId = id;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// Overridden method for printing task id to a <see cref="string"/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return TaskId.ToString();
        }
        #endregion
    }
}
