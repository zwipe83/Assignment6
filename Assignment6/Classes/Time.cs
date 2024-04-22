/// <summary>
/// Filename: Time.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Time
    {
        #region Fields
        /// <summary>
        /// Field for storing of task time, of type <see cref="TimeSpan"/>
        /// </summary>
        private TimeSpan _taskTime;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_taskTime"/>
        /// </summary>
        public TimeSpan TaskTime
        {
            get => _taskTime;
            protected set => _taskTime = value;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default Time constructor, creates an intance of <see cref="Time"/> with default values
        /// </summary>
        public Time() : this(new TimeSpan())
        {
        }
        /// <summary>
        /// Time constructor, creates an intance of <see cref="Time"/> with a specific <see cref="TimeSpan"/> as parameter
        /// </summary>
        /// <param name="time"></param>
        public Time(TimeSpan time)
        {
            TaskTime = time;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// Overridden method for printing task date to a <see cref="string"/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{TaskTime.Hours:D2}:{TaskTime.Minutes:D2}:{TaskTime.Seconds:D2}";
        }
        #endregion
    }
}
