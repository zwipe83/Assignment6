/// <summary>
/// Filename: Description.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Description
    {
        #region Fields
        /// <summary>
        /// Field for storing of task description, of type <see cref="string"/>
        /// </summary>
        private string _taskDescription;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_taskDescription"/>
        /// </summary>
        public string TaskDescription
        {
            get => _taskDescription;
            protected set
            {
                if (value != null)
                {
                    _taskDescription = value;
                }
                else
                {
                    _taskDescription = string.Empty;
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Description constructor, creates an intance of <see cref="Description"/> with default values
        /// </summary>
        public Description() : this(string.Empty)
        {
        }
        /// <summary>
        /// Description constructor, creates an intance of <see cref="Description"/> with a specific <see cref="string"/> as parameter
        /// </summary>
        /// <param name="description"></param>
        public Description(string description)
        {
            TaskDescription = description;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// Overridden method for printing task description to a <see cref="string"/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return TaskDescription.ToString();
        }
        #endregion
    }
}
