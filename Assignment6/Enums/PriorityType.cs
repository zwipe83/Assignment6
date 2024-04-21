/// <summary>
/// Filename: PriorityType.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using System.ComponentModel;

namespace Assignment6.Enums
{
    #region Enums
    /// <summary>
    /// 
    /// </summary>
    public enum PriorityType
    {
        [Description("Very Important")]
        VeryImportant = 0,
        Important,
        Normal,
        [Description("Less Important")]
        LessImportant,
        [Description("Not Important")]
        NotImportant
    }
    #endregion
}
