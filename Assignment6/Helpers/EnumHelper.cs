/// <summary>
/// Filename: EnumHelper.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using System.ComponentModel;
using System.Reflection;

namespace Assignment6.Helpers
{
    /// <summary>
    /// Class for doing operations on Enums. For example getting an enum description.
    /// </summary>
    internal class EnumHelper
    {
        #region Public Static Methods

        /// <summary>
        /// Get description from provided enum value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Description of the enum value. If null return enum value.</returns>
        public static string GetDescription(Enum value)
        {
            FieldInfo? fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute? attribute = fi?.GetCustomAttribute<DescriptionAttribute>();

            return attribute?.Description ?? value.ToString(); //Null check, return input value
        }
        #endregion
    }
}
