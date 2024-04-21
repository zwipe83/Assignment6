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
        //TODO: Check setters!
        public Id Id
        {
            get => _id;
            set
            {
                if (value != null)
                {
                    _id = value;
                }
            }
        }
        public Date Date
        {
            get => _date;
            set
            {
                if (value != null)
                {
                    _date = value;
                }
            }
        }
        public Time Time
        {
            get => _time;
            set
            {
                if (value != null)
                {
                    _time = value;
                }
            }
        }
        public Priority Priority
        {
            get => _priority;
            set
            {
                if (value != null)
                {
                    _priority = value;
                }
            }
        }
        public Description Description
        {
            get => _description;
            set
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
