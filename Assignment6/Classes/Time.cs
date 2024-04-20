/// <summary>
/// Filename: Time.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    internal class Time
    {
        #region Fields
        private TimeSpan _taskTime;
        #endregion
        #region Properties
        public TimeSpan TaskTime
        {
            get => _taskTime;
            set
            {
                if (value != null)
                {
                    _taskTime = value;
                }
            }
        }
        #endregion
        #region Constructors
        public Time() : this(new TimeSpan())
        {
        }
        public Time(TimeSpan time)
        {
            TaskTime = time;
        }
        #endregion
        #region Overridden Methods
        public override string ToString()
        {
            return TaskTime.ToString("HH:mm:ss");
        }
        #endregion
    }
}
