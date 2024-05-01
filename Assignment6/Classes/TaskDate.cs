/// <summary>
/// Filename: TaskDate.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    /// <summary>
    /// Represents a task date.
    /// </summary>
    public class TaskDate
    {
        #region Fields

        /// <summary>
        /// Field for storing of task date, of type <see cref="DateTime"/>
        /// </summary>
        private DateTime _date;
        #endregion
        #region Properties

        /// <summary>
        /// Property for getting and setting value to private field <see cref="_date"/>
        /// </summary>
        public DateTime Date
        {
            get => _date;
            protected set => _date = value;
        }
        #endregion
        #region Constructors

        /// <summary>
        /// Default Date constructor, creates an intance of <see cref="Classes.TaskDate"/> with default values
        /// </summary>
        public TaskDate() : this(new DateTime())
        {
        }

        /// <summary>
        /// Date constructor, creates an intance of <see cref="Classes.TaskDate"/> with a specific <see cref="DateTime"/> as parameter
        /// </summary>
        /// <param name="date"></param>
        public TaskDate(DateTime date)
        {
            Date = date;
        }
        #endregion
        #region Overridden Methods

        /// <summary>
        /// Overridden method for printing task date to a <see cref="string"/>
        /// </summary>
        /// <returns>A string representation of the task date.</returns>
        public override string ToString()
        {
            return Date.ToString("yyyy-MM-dd");
        }
        #endregion
    }
}
