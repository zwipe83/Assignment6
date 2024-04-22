/// <summary>
/// Filename: FormMain.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment6.Classes;
using Assignment6.Enums;
using Assignment6.Forms;
using System.Windows.Forms;
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

            InitGUI();
        }
        #endregion
        #region private Methods
        /// <summary>
        /// 
        /// </summary>
        private void InitGUI() //TODO: Make this prettier
        {
            _taskManager = new TaskManager();

            lstTasks.Items.Clear();

            txtToDo.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            lstTasks.Columns.Clear();

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

            btnAddTask.Enabled = false;

            UpdateFileMenu();
            UpdateButtons();

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
            Id id = new Id();
            Date date = new Date(dateTimePicker1.Value.Date);
            Time time = new Time(dateTimePicker1.Value.TimeOfDay);
            Priority priority = new Priority((PriorityType)cmbPriority.SelectedIndex);
            Description description = new Description(txtToDo.Text);

            Assignment6.Classes.Task task = new Assignment6.Classes.Task(id, date, time, priority, description);

            TaskManager.AddNew(task);

            UpdateListView();
            UpdateFileMenu();
            UpdateButtons();
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpdateListView()
        {
            lstTasks.Items.Clear();
            foreach (Assignment6.Classes.Task task in TaskManager.TaskList)
            {
                ListViewItem item = new ListViewItem(task.Date.ToString());
                item.SubItems.Add(task.Time.ToString());
                item.SubItems.Add(task.Priority.ToString());
                item.SubItems.Add(task.Description.ToString());

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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_MouseEnter(object sender, EventArgs e)
        {
            toolTipDateTime.Show("Click to open calender, write a time", this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_MouseLeave(object sender, EventArgs e)
        {
            toolTipDateTime.Hide(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About...");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close application?\n\nAll unsaved data will be lost!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                return; //Do nothing
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems.Count == 0)
            {
                return;
            }

            Id id = (Id)lstTasks.SelectedItems[0].Tag;

            if (id == null)
            {
                return;
            }

            Assignment6.Classes.Task taskCopy = new Assignment6.Classes.Task(TaskManager.GetTask(id)); //Make a local copy of Task

            FormEdit formEdit = new FormEdit(taskCopy);

            formEdit.ShowDialog();


            if (formEdit.DialogResult == DialogResult.OK)
            {
                TaskManager.Change(formEdit.TaskCopy);
                UpdateListView();
                UpdateFileMenu();
                UpdateButtons();

            }
            else
            {
                //Nothing for now...
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpdateFileMenu()
        {
            if (lstTasks.Items.Count > 0)
            {
                saveDataFileToolStripMenuItem.Enabled = true;
            }
            else
            {
                saveDataFileToolStripMenuItem.Enabled = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpdateButtons()
        {
            if (lstTasks.Items.Count > 0)
            {
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnChange.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dummy = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtToDo.Text))
            {
                btnAddTask.Enabled = true;
            }
            else
            {
                btnAddTask.Enabled = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems.Count == 0)
            {
                return;
            }

            Id id = (Id)lstTasks.SelectedItems[0].Tag;

            if (id == null)
            {
                return;
            }


            DialogResult result = MessageBox.Show("Are you sure you want to delete task?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TaskManager.Delete(id);

                UpdateListView();
                UpdateFileMenu();
                UpdateButtons();
            }
            else if (result == DialogResult.No)
            {
                return; //Do nothing
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (string.IsNullOrWhiteSpace(filePath))
                        return;

                    string path = Path.GetDirectoryName(filePath);
                    string fileName = Path.GetFileName(filePath);

                    Classes.File file = new Classes.File(path, fileName);
                    TaskManager.SaveToFile(file);
                }
                else
                {
                    //No need to do anything...
                }

                //Json method
                //Classes.File file2 = new Classes.File(@"C:\files", "save1.json");
                //TaskManager.SaveToJsonFile(file2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    if (string.IsNullOrWhiteSpace(filePath))
                        return;

                    string path = Path.GetDirectoryName(filePath);
                    string fileName = Path.GetFileName(filePath);

                    Classes.File file = new Classes.File(path, fileName);
                    TaskManager.ReadFromFile(file);
                    UpdateListView();
                }
                else
                {
                    //No need to do anything...
                }

                //Json method
                //Classes.File file2 = new Classes.File(@"C:\files", "save1.json");
                //TaskManager.ReadFromJsonFile(file2);
                //UpdateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reload application?\n\nAll unsaved data will be lost!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                InitGUI();
            }
            else if (result == DialogResult.No)
            {
                return; //Do nothing
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTasks_DoubleClick(object sender, EventArgs e)
        {
            btnChange_Click(sender, e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }
    }
}
