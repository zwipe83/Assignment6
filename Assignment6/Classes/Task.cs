/// <summary>
/// Filename: Task.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    internal class Task
    {
        #region Fields
        private Id _id;
        private Date _date;
        private Time _time;
        private Priority _priority;
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
        public Task() : this(new Id())
        {
        }
        public Task(Id id) : this(id, new Date())
        {
        }
        public Task(Id id, Date date) : this(id, date, new Time())
        {
        }
        public Task(Id id, Date date, Time time) : this(id, date, time, new Priority())
        {
        }
        public Task(Id id, Date date, Time time, Priority priority) : this(id, date, time, priority, new Description())
        {
        }
        public Task(Id id, Date date, Time time, Priority priority, Description description)
        {
            Id = id;
            Date = date;
            Time = time;
            Priority = priority;
            Description = description;
        }
        #endregion
        #region Overridden Methods
        public override string ToString()
        {
            return $"{Date} {Time} {Priority} {Description}";
        }
        #endregion
    }
}
