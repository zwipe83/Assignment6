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
        /// 
        /// </summary>
        private DateTime _taskDate;
        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public DateTime TaskDate
        {
            get => _taskDate;
            protected set
            {
                //TODO: Add check for date is not already passed, which is not really needed since MinDate property is used on DateTimePicker
                if (value != null)
                {
                    _taskDate = value;
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Date() : this(new DateTime())
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        public Date(DateTime date)
        {
            TaskDate = date;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return TaskDate.ToString("yyyy-MM-dd");
        }
        #endregion
    }
}
