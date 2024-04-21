/// <summary>
/// Filename: Description.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class Description
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private string _taskDescription;
        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
        public Description() : this(string.Empty)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        public Description(string description)
        {
            TaskDescription = description;
        }
        #endregion
        #region Overridden Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return TaskDescription.ToString();
        }
        #endregion
    }
}
