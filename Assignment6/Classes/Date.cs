/// <summary>
/// Filename: Date.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Date
    {
        #region Fields
        /// <summary>
        /// Field for storing of task date, of type <see cref="DateTime"/>
        /// </summary>
        private DateTime _taskDate;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_taskDate"/>
        /// </summary>
        public DateTime TaskDate
        {
            get => _taskDate;
            protected set => _taskDate = value;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Date constructor, creates an intance of <see cref="Date"/> with default values
        /// </summary>
        public Date() : this(new DateTime())
        {
        }
        /// <summary>
        /// Date constructor, creates an intance of <see cref="Date"/> with a specific <see cref="DateTime"/> as parameter
        /// </summary>
        /// <param name="date"></param>
        public Date(DateTime date)
        {
            TaskDate = date;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// Overridden method for printing task date to a <see cref="string"/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return TaskDate.ToString("yyyy-MM-dd");
        }
        #endregion
    }
}
