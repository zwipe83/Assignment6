/// <summary>
/// Filename: Date.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    internal class Date
    {
        #region Fields
        private DateTime _taskDate;
        #endregion
        #region Properties
        public DateTime TaskDate
        {
            get => _taskDate; 
            set
            {
                if(value != null) //TODO: Add check for date is not already passed
                {
                    _taskDate = value;
                }
            }
        }
        #endregion
        #region Constructors
        public Date() : this(new DateTime())
        {
        }
        public Date(DateTime date)
        {
            TaskDate = date;
        }
        #endregion
        #region Overridden Methods
        public override string ToString()
        {
            return TaskDate.ToString("yyyy-MM-dd");
        }
        #endregion
    }
}
