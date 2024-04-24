/// <summary>
/// Filename: TaskDescription.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskDescription
    {
        #region Fields
        /// <summary>
        /// Field for storing of task description, of type <see cref="string"/>
        /// </summary>
        private string _description;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_description"/>
        /// </summary>
        public string Description
        {
            get => _description;
            protected set
            {
                if (value != null)
                {
                    _description = value;
                }
                else
                {
                    _description = string.Empty;
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Description constructor, creates an intance of <see cref="Classes.TaskDescription"/> with default values
        /// </summary>
        public TaskDescription() : this(string.Empty)
        {
        }
        /// <summary>
        /// Description constructor, creates an intance of <see cref="Classes.TaskDescription"/> with a specific <see cref="string"/> as parameter
        /// </summary>
        /// <param name="description"></param>
        public TaskDescription(string description)
        {
            Description = description;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// Overridden method for printing task description to a <see cref="string"/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Description.ToString();
        }
        #endregion
    }
}
