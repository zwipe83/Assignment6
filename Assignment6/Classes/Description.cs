/// <summary>
/// Filename: Description.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    internal class Description
    {
        #region Fields
        private string _taskDescription;
        #endregion
        #region Properties
        public string TaskDescription
        {
            get => _taskDescription;
            set
            {
                if (value != null) 
                {
                    _taskDescription = value;
                }
            }
        }
        #endregion
        #region Constructors
        public Description() : this(string.Empty)
        {
        }
        public Description(string description)
        {
            TaskDescription = description;
        }
        #endregion
        #region Overridden Methods
        public override string ToString()
        {
            return TaskDescription.ToString();
        }
        #endregion
    }
}
