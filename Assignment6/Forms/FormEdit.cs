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
        /// Field for storing of task copy, of type <see cref="Task"/>
        /// </summary>
        private Assignment6.Classes.Task _taskCopy;
        #endregion
        #region Properties

        /// <summary>
        /// Property for getting value to private field <see cref="_taskCopy"/>
        /// </summary>
        public Assignment6.Classes.Task TaskCopy
        {
            get => _taskCopy;
        }
        #endregion
        #region Constructors

        /// <summary>
        /// Default constuctor
        /// </summary>
        public FormEdit() : this(new Assignment6.Classes.Task())
        {
        }

        /// <summary>
        /// Constructor with a specific <see cref="Task"/> as parameter
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
        /// Initialize GUI
        /// </summary>
        private void InitGUI()
        {
            //Set icon
            this.Icon = Properties.Resources.AppIcon;

            txtToDo.Text = TaskCopy.Description.ToString();

            InitComboBox();

            InitDateTimePicker();
        }

        /// <summary>
        /// Init Combobox
        /// </summary>
        private void InitComboBox()
        {
            string[] priorityDescriptions = GetPriorityDescriptions();
            SetPriorityDescriptions(priorityDescriptions, cmbPriority);
            cmbPriority.SelectedIndex = (int)TaskCopy.Priority.Priority;
        }

        /// <summary>
        /// Init Datetimepicker
        /// </summary>
        private void InitDateTimePicker()
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd    HH:mm";

            DateTime date = TaskCopy.Date.Date;
            TimeSpan time = TaskCopy.Time.Time;

            DateTime dateTime = date.Add(time); // Combine the date and time

            dateTimePicker1.MinDate = (dateTime > DateTime.Now) ? DateTime.Now : dateTime; //FIXED: Add DateTime.Now if date hasn't passed yet.

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
        /// Save changes to task copy of type <see cref="Task"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TaskCopy.Date = new TaskDate(dateTimePicker1.Value.Date);
                TaskCopy.Time = new TaskTime(dateTimePicker1.Value.TimeOfDay);
                TaskCopy.Priority = new TaskPriority((PriorityType)cmbPriority.SelectedIndex);
                TaskCopy.Description = new TaskDescription(txtToDo.Text);

                DialogResult = DialogResult.OK;

                this.Close();
            }
            else if (result == DialogResult.No)
            {
                return; //Do nothing
            }
        }

        /// <summary>
        /// Update MinDate property continuously to make it near impossible to enter a date and time that has already passed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateMinDateTimer_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }

        /// <summary>
        /// Close window without saving
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
