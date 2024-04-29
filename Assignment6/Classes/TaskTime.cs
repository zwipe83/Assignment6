/// <summary>
/// Filename: TaskTime.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    /// <summary>
    /// Represents a task time.
    /// </summary>
    public class TaskTime
    {
        #region Fields
        /// <summary>
        /// Field for storing of task time, of type <see cref="TimeSpan"/>
        /// </summary>
        private TimeSpan _time;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_time"/>
        /// </summary>
        public TimeSpan Time
        {
            get => _time;
            protected set => _time = value;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Time constructor, creates an intance of <see cref="Classes.TaskTime"/> with default values
        /// </summary>
        public TaskTime() : this(new TimeSpan())
        {
        }
        /// <summary>
        /// Time constructor, creates an intance of <see cref="Classes.TaskTime"/> with a specific <see cref="TimeSpan"/> as parameter
        /// </summary>
        /// <param name="time"></param>
        public TaskTime(TimeSpan time)
        {
            Time = time;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// Overridden method for printing task time to a <see cref="string"/>
        /// </summary>
        /// <returns>A string representation of the task time.</returns>
        public override string ToString()
        {
            return $"{Time.Hours:D2}:{Time.Minutes:D2}:{Time.Seconds:D2}";
        }
        #endregion
    }
}
