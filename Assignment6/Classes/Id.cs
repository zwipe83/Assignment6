/// <summary>
/// Filename: Id.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    internal class Id
    {
        #region Fields
        private Guid _taskId;
        #endregion
        #region Properties
        public Guid TaskId
        {
            get => _taskId;
            set
            {
                if (value != null) //TODO: Add check for date is not already passed
                {
                    _taskId = value;
                }
            }
        }
        #endregion
        #region Constructors
        public Id() :this(Guid.NewGuid())
        {
        }
        public Id(Guid id)
        {
            TaskId = id;
        }
        #endregion
        #region Overridden Methods
        public override string ToString()
        {
            return TaskId.ToString();
        }
        #endregion
    }
}
