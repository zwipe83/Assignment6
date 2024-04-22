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
        /// 
        /// </summary>
        private TimeSpan _taskTime;
        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public TimeSpan TaskTime
        {
            get => _taskTime;
            protected set
            {
                if (value != null)
                {
                    _taskTime = value;
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Time() : this(new TimeSpan())
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        public Time(TimeSpan time)
        {
            TaskTime = time;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{TaskTime.Hours}:{TaskTime.Minutes}:{TaskTime.Seconds}";
        }
        #endregion
    }
}
