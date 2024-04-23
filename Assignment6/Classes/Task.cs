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
        /// Field for storing of task id, of type <see cref="Id"/>
        /// </summary>
        private Id _id;
        /// <summary>
        /// Field for storing of task date, of type <see cref="Date"/>
        /// </summary>
        private Date _date;
        /// <summary>
        /// Field for storing of task time, of type <see cref="Time"/>
        /// </summary>
        private Time _time;
        /// <summary>
        /// Field for storing of task priority, of type <see cref="Priority"/>
        /// </summary>
        private Priority _priority;
        /// <summary>
        /// Field for storing of task description, of type <see cref="Description"/>
        /// </summary>
        private Description _description;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_id"/>
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
        /// Property for getting and setting value to private field <see cref="_date"/>
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
        /// Property for getting and setting value to private field <see cref="_time"/>
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
        /// Property for getting and setting value to private field <see cref="_priority"/>
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
        /// Property for getting and setting value to private field <see cref="_description"/>
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
        /// Default Task constructor, creates an intance of <see cref="Task"/> with default values
        /// </summary>
        public Task() : this(new Id())
        {
        }
        /// <summary>
        /// Task constructor, creates an intance of <see cref="Date"/> with a specific <see cref="Id"/> as parameter
        /// </summary>
        /// <param name="id"></param>
        public Task(Id id) : this(id, new Date())
        {
        }
        /// <summary>
        /// Task constructor, creates an intance of <see cref="Date"/> with a specific <see cref="Id"/> and <see cref="Date"/> as parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        public Task(Id id, Date date) : this(id, date, new Time())
        {
        }
        /// <summary>
        /// Task constructor, creates an intance of <see cref="Date"/> with a specific <see cref="Id"/>, <see cref="Date"/> and <see cref="Time"/> as parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        public Task(Id id, Date date, Time time) : this(id, date, time, new Priority())
        {
        }
        /// <summary>
        /// Task constructor, creates an intance of <see cref="Date"/> with a specific <see cref="Id"/>, <see cref="Date"/>, <see cref="Time"/> and <see cref="Priority"/> as parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="priority"></param>
        public Task(Id id, Date date, Time time, Priority priority) : this(id, date, time, priority, new Description())
        {
        }
        /// <summary>
        /// Task constructor, creates an intance of <see cref="Date"/> with a specific <see cref="Id"/>, <see cref="Date"/>, <see cref="Time"/>, <see cref="Priority"/> and <see cref="Description"/> as parameters
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
        /// Copy constructor. Copies from one instance of <see cref="Task"/> to a new instance of <see cref="Task"/>
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
        /// Overridden method for printing task date to a <see cref="string"/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Date} {Time} {Priority} {Description}";
        }
        #endregion
    }
}
