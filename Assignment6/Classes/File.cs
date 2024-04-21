/// <summary>
/// Filename: File.cs
/// Created on: 2024-04-21 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    /// <summary>
    /// 
    /// </summary>
    internal class File
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private string _path;
        /// <summary>
        /// 
        /// </summary>
        private string _name;
        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public string Path
        {
            get => _path;
            set
            {
                if (value != null) //TODO: add check for valid path
                {
                    _path = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value != null) //TODO: add check for valid path
                {
                    _name = value;
                }
            }
        }
        #endregion
        #region Constructors
        public File() : this(string.Empty) //TODO: Default path?
        {
        }
        public File(string path) : this(path, "SaveFile.txt")
        {
        }
        public File(string path, string fileName)
        {
            Path = path;
            Name = fileName;
        }
        #endregion
    }
}
