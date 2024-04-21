/// <summary>
/// Filename: FormEdit.cs
/// Created on: 2024-04-21 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment6.Classes;
using Assignment6.Enums;
using static Assignment6.Helpers.EnumHelper;

namespace Assignment6.Forms
{
    public partial class FormEdit : Form
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private Assignment6.Classes.Task _taskCopy;
        #endregion
        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public Assignment6.Classes.Task TaskCopy
        {
            get => _taskCopy;
            private set
            {
                if (value != null)
                {
                    _taskCopy = value;
                }
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public FormEdit() : this(new Assignment6.Classes.Task())
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskCopy"></param>
        public FormEdit(Assignment6.Classes.Task taskCopy)
        {
            InitializeComponent();

            _taskCopy = taskCopy;

            InitGUI();
        }
        #endregion
        #region Private Methods
        /// <summary>
        /// 
        /// </summary>
        private void InitGUI()
        {
            dateTimePicker1.CustomFormat = "yyy-MM-dd    HH:mm:ss";

            string[] priorityDescriptions = GetPriorityDescriptions();
            SetPriorityDescriptions(priorityDescriptions, cmbPriority);

            txtToDo.Text = TaskCopy.Description.ToString();
            cmbPriority.SelectedIndex = (int)TaskCopy.Priority.TaskPriority;

            DateTime date = TaskCopy.Date.TaskDate;
            TimeSpan time = TaskCopy.Time.TaskTime;

            DateTime dateTime = date.Add(time); // Combine the date and time

            dateTimePicker1.MinDate = dateTime; //TODO: Add DateTime.Now if date hasn't passed yet.

            dateTimePicker1.Value = dateTime;

        }

        /// <summary>
        /// Gets priority descriptions as <see cref="string"/> from Enum of type <see cref="PriorityType"/>
        /// </summary>
        private string[] GetPriorityDescriptions()
        {
            var priorityAry = Enum.GetValues(typeof(PriorityType));
            var priorityDescriptions = new string[priorityAry.Length];
            for (int i = 0; i < priorityAry.Length; i++)
            {
                priorityDescriptions[i] = GetDescription((Enum)priorityAry.GetValue(i));
            }

            return priorityDescriptions;
        }
        /// <summary>
        /// Set priority descriptions to provided <see cref="ComboBox"/>
        /// </summary>
        /// <param name="priorityDescriptions"></param>
        /// <param name="comboBox"></param>
        private void SetPriorityDescriptions(string[] priorityDescriptions, ComboBox comboBox)
        {
            comboBox.DataSource = priorityDescriptions;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            TaskCopy.Date = new Date(dateTimePicker1.Value.Date);
            TaskCopy.Time = new Time(dateTimePicker1.Value.TimeOfDay);
            TaskCopy.Priority = new Priority((PriorityType)cmbPriority.SelectedIndex);
            TaskCopy.Description = new Description(txtToDo.Text);

            DialogResult = DialogResult.OK;

            this.Close();
        }
        #endregion
    }
}
