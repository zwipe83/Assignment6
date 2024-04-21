/// <summary>
/// Filename: File.cs
/// Created on: 2024-04-21 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6.Classes
{
    internal class File
    {
        private string _path;
        public string Path
        {
            get => _path;
            set 
            { 
                if(value != null) //TODO: add check for valid path
                {
                    _path = value;
                }
            }
        }

        public File() : this(string.Empty) //TODO: Default path?
        {

        }
        public File(string path) 
        { 
            Path = path;
        }
    }
}
