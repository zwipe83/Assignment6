/// <summary>
/// Filename: Task.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Task
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private Id _id;
        /// <summary>
        /// 
        /// </summary>
        private Date _date;
        /// <summary>
        /// 
        /// </summary>
        private Time _time;
        /// <summary>
        /// 
        /// </summary>
        private Priority _priority;
        /// <summary>
        /// 
        /// </summary>
        private Description _description;
        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public Id Id
        {
            get => _id;
            protected set
            {
                if (value != null)
                {
                    _id = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Date Date
        {
            get => _date;
            internal set
            {
                if (value != null)
                {
                    _date = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Time Time
        {
            get => _time;
            internal set
            {
                if (value != null)
                {
                    _time = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Priority Priority
        {
            get => _priority;
            internal set
            {
                if (value != null)
                {
                    _priority = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Description Description
        {
            get => _description;
            internal set
            {
                if (value != null)
                {
                    _description = value;
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Task() : this(new Id())
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public Task(Id id) : this(id, new Date())
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        public Task(Id id, Date date) : this(id, date, new Time())
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        public Task(Id id, Date date, Time time) : this(id, date, time, new Priority())
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="priority"></param>
        public Task(Id id, Date date, Time time, Priority priority) : this(id, date, time, priority, new Description())
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="priority"></param>
        /// <param name="description"></param>
        public Task(Id id, Date date, Time time, Priority priority, Description description)
        {
            Id = id;
            Date = date;
            Time = time;
            Priority = priority;
            Description = description;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objToCopyFrom"></param>
        public Task(Task objToCopyFrom)
        {
            Id = objToCopyFrom.Id;
            Date = objToCopyFrom.Date;
            Time = objToCopyFrom.Time;
            Priority = objToCopyFrom.Priority;
            Description = objToCopyFrom.Description;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Date} {Time} {Priority} {Description}";
        }
        #endregion
    }
}
