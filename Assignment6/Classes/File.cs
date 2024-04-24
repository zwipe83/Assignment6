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
        /// Field for storing of file path, of type <see cref="string"/>
        /// </summary>
        private string _path;
        /// <summary>
        /// Field for storing of file name, of type <see cref="string"/>
        /// </summary>
        private string _name;
        /// <summary>
        /// Field for storing of default file path, of type <see cref="string"/>
        /// </summary>
        private static readonly string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        /// <summary>
        /// Field for storing of default file name, of type <see cref="string"/>
        /// </summary>
        private static readonly string defaultFileName = "SaveFile.txt";
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_path"/>
        /// </summary>
        public string Path
        {
            get => _path;
            protected set
            {
                if (value != null && System.IO.Path.IsPathRooted(value)) //FIXED: add check for valid path, absolute path not relative path
                {
                    _path = value;
                }
                else
                {
                    throw new InvalidOperationException($"Path is invalid: {value}");
                }
            }
        }
        /// <summary>
        /// Property for getting and setting value to private field <see cref="_name"/>
        /// </summary>
        public string Name
        {
            get => _name;
            protected set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new InvalidOperationException($"File name is invalid: {value}");
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Default File constructor, creates an intance of <see cref="File"/> with default values
        /// </summary>
        public File() : this(defaultPath) //FIXED: Default path?
        {
        }
        /// <summary>
        /// File constructor, creates an intance of <see cref="TaskDescription"/> with a specific path <see cref="string"/> and default file name as parameters
        /// </summary>
        /// <param name="path"></param>
        public File(string path) : this(path, defaultFileName)
        {
        }
        /// <summary>
        /// File constructor, creates an intance of <see cref="TaskDescription"/> with a specific path <see cref="string"/> and file name <see cref="string"/> as parameters
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        public File(string path, string fileName)
        {
            Path = path;
            Name = fileName;
        }
        #endregion
    }
}
