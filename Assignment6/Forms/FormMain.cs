
/// <summary>
/// Filename: FormMain.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 
using Assignment6.Classes;
using Assignment6.Enums;
using System.Diagnostics.Metrics;
using static Assignment6.Helpers.EnumHelper;

namespace Assignment6
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormMain : Form
    {
        #region Fields
        private TaskManager _taskManager;
        private readonly PriorityType defaultPriority = PriorityType.Normal;
        #endregion
        #region Properties
        internal TaskManager TaskManager
        {
            get => _taskManager ?? (_taskManager = new TaskManager());
        }

        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            _taskManager = new TaskManager();

            InitGUI();
        }
        #endregion
        #region private Methods
        /// <summary>
        /// 
        /// </summary>
        private void InitGUI()
        {
            dateTimePicker1.CustomFormat = "yyy-MM-dd    HH:mm:ss";
            dateTimePicker1.MinDate = DateTime.Now;
            lblTimer.Text = GetNowToString("HH:mm:ss");

            string[] priorityDescriptions = GetPriorityDescriptions();
            SetPriorityDescriptions(priorityDescriptions, cmbPriority);

            cmbPriority.SelectedIndex = (int)defaultPriority;

            lstTasks.View = View.Details;

            lstTasks.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lstTasks.Columns.Add("Time", 100, HorizontalAlignment.Left);
            lstTasks.Columns.Add("Priority", 150, HorizontalAlignment.Left);
            lstTasks.Columns.Add("Description", 550, HorizontalAlignment.Left);

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
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            //TODO: Null checks and so on...
            Id id = new Id(Guid.NewGuid());
            Date date = new Date(dateTimePicker1.Value.Date);
            Time time = new Time(dateTimePicker1.Value.TimeOfDay);
            Priority priority = new Priority((PriorityType)cmbPriority.SelectedIndex);
            Description description = new Description(txtToDo.Text);

            Assignment6.Classes.Task task = new Assignment6.Classes.Task(id, date, time, priority, description);

            TaskManager.AddNew(task);

            UpdateListView();
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpdateListView()
        {
            lstTasks.Items.Clear();
            foreach (Assignment6.Classes.Task task in TaskManager.TaskList)
            {
                ListViewItem item = new ListViewItem(task.Date.ToString()); // Create a new ListViewItem with the text for the first column
                item.SubItems.Add(task.Time.ToString()); // Add a subitem for the second column
                item.SubItems.Add(task.Priority.ToString()); // Add a subitem for the third column
                item.SubItems.Add(task.Description.ToString()); // Add a subitem for the fourth column

                //lstTasks.Items.Add(item); // Add the ListViewItem to the ListView

                string[] row = { task.Date.ToString(), task.Time.ToString(), task.Priority.ToString(), task.Description.ToString() };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = task.Id;
                lstTasks.Items.Add(listViewItem);

                //lstTasks.Items.Add(new ListViewItem(new string[] { task.ToString() }));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = GetNowToString("HH:mm:ss");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetNowToString(string format)
        {
            return DateTime.Now.ToString(format);
        }
        #endregion

        private void dateTimePicker1_MouseEnter(object sender, EventArgs e)
        {
            toolTipDateTime.Show("Click to open calender, write a time", this);
        }

        private void dateTimePicker1_MouseLeave(object sender, EventArgs e)
        {
            toolTipDateTime.Hide(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About...");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(lstTasks.SelectedItems.Count == 0)
            { 
                return; 
            }

            Id id = (Id)lstTasks.SelectedItems[0].Tag;

            TaskManager.Change(id);
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dummy = 0;
        }
    }
}
