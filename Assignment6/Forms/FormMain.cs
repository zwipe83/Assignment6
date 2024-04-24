/// <summary>
/// Filename: FormMain.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

using Assignment6.Classes;
using Assignment6.Enums;
using Assignment6.Forms;
using System.Drawing.Printing;
using System.Threading.Tasks;
using static Assignment6.Helpers.EnumHelper;

namespace Assignment6
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormMain : Form
    {
        #region Fields
        /// <summary>
        /// Field for storing of task manager, of type <see cref="TaskManager"/>
        /// </summary>
        private TaskManager _taskManager;
        /// <summary>
        /// Default priosrity of type <see cref="PriorityType"/>
        /// </summary>
        private readonly PriorityType defaultPriority = PriorityType.Normal;
        #endregion
        #region Properties
        /// <summary>
        /// Property for getting object of type <see cref="_taskManager"/>
        /// </summary>
        internal TaskManager TaskManager
        {
            get => _taskManager ??= new TaskManager();
        }

        #endregion
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            InitGUI();
        }
        #endregion
        #region Private Methods
        /// <summary>
        /// Initializes the GUI with a more aesthetically pleasing layout.
        /// </summary>
        private void InitGUI()
        {
            //Create new instance of TaskManager
            _taskManager = new TaskManager();

            //Set icon
            this.Icon = Properties.Resources.AppIcon;

            //Disable Add button
            btnAddTask.Enabled = false;

            //Update rest of interaction controls
            InitDateTimepicker();
            SetDefaultValues();
            InitCombobox();
            InitListView();
            InitToolTip();
            UpdateFileMenu();
            UpdateButtons();
        }
        /// <summary>
        /// Init datetimepicker
        /// </summary>
        private void InitDateTimepicker()
        {
            //Configure dateTimePicker
            dateTimePicker1.CustomFormat = "yyy-MM-dd    HH:mm:ss";
            dateTimePicker1.MinDate = DateTime.Now;
        }
        /// <summary>
        /// Init combobox with priority descriptions
        /// </summary>
        private void InitCombobox()
        {
            //Get priorities from Enum
            string[] priorityDescriptions = GetPriorityDescriptions();
            SetPriorityDescriptions(priorityDescriptions, cmbPriority);

            //Set default value to combobox
            cmbPriority.SelectedIndex = (int)defaultPriority;
        }
        /// <summary>
        /// Set default values in gui controls
        /// </summary>
        private void SetDefaultValues()
        {
            //Set default values
            txtToDo.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            lblTimer.Text = GetNowToString("HH:mm:ss");
        }

        /// <summary>
        /// Init listview
        /// </summary>
        private void InitListView()
        {
            //Clear listview
            lstTasks.Items.Clear();
            lstTasks.Columns.Clear();

            //Add columns to listview
            lstTasks.View = View.Details;

            lstTasks.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lstTasks.Columns.Add("Time", 100, HorizontalAlignment.Left);
            lstTasks.Columns.Add("Priority", 150, HorizontalAlignment.Left);
            lstTasks.Columns.Add("Description", 550, HorizontalAlignment.Left);
        }

        /// <summary>
        /// Init tooltip
        /// </summary>
        private void InitToolTip()
        {
            //Configure tooltip
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(dateTimePicker1, "Click to open calendar, write to enter time.");
            toolTip1.SetToolTip(cmbPriority, "Select a priority.");
            toolTip1.SetToolTip(txtToDo, "Enter a description for your reminder.");
            toolTip1.SetToolTip(btnAddTask, "Click here to save your reminder.");
            toolTip1.SetToolTip(btnChange, "Click here to edit selected reminder.");
            toolTip1.SetToolTip(btnDelete, "Click here to delete selected reminder.");
            toolTip1.SetToolTip(lblTimer, "Shows current time.");
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
        /// Adds a <see cref="Task"/> to a collection of type <see cref="TaskManager.TaskList"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TaskId id = new TaskId();
            TaskDate date = new TaskDate(dateTimePicker1.Value.Date);
            TaskTime time = new TaskTime(dateTimePicker1.Value.TimeOfDay);
            TaskPriority priority = new TaskPriority((PriorityType)cmbPriority.SelectedIndex);
            TaskDescription description = new TaskDescription(txtToDo.Text);

            Assignment6.Classes.Task task = new Assignment6.Classes.Task(id, date, time, priority, description);

            TaskManager.AddNewTask(task);

            ResetControls();
            UpdateListView();
            UpdateFileMenu();
            UpdateButtons();
        }
        /// <summary>
        /// Reset controls
        /// </summary>
        private void ResetControls()
        {
            //Reset controls
            txtToDo.Text = string.Empty;
            cmbPriority.SelectedIndex = (int)defaultPriority;
            dateTimePicker1.Value = DateTime.Now;
        }

        /// <summary>
        /// Updates content in listview
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

                string[] row = { task.Date.ToString(), task.Time.ToString(), task.Priority.ToString(), task.Description.ToString() };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = task.Id;
                lstTasks.Items.Add(listViewItem);
            }
        }
        /// <summary>
        /// Timer updates time label in gui
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = GetNowToString("HH:mm:ss");
        }
        /// <summary>
        /// Get <see cref="DateTime.Now"/> as string
        /// </summary>
        /// <returns><see cref="DateTime.Now"/> as a string</returns>
        private string GetNowToString(string format)
        {
            return DateTime.Now.ToString(format);
        }
        /// <summary>
        /// Open about dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        /// <summary>
        /// Exit application
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
        /// Changes currently selected <see cref="Task"/> in listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems.Count == 0)
            {
                return; //Nothing selected
            }

            TaskId id = (TaskId)lstTasks.SelectedItems[0].Tag;

            if (id == null)
            {
                return; //Id is no good...
            }

            Assignment6.Classes.Task taskCopy = new Assignment6.Classes.Task(TaskManager.GetTask(id)); //Make a local copy of Task

            //Create new form and show it
            FormEdit formEdit = new FormEdit(taskCopy);

            formEdit.ShowDialog();

            //Handle form closing
            if (formEdit.DialogResult == DialogResult.OK)
            {
                TaskManager.ChangeTask(formEdit.TaskCopy);
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
        /// Update File menu
        /// </summary>
        private void UpdateFileMenu()
        {
            if (lstTasks.Items.Count > 0)
            {
                saveDataFileToolStripMenuItem.Enabled = true;
                printToolStripMenuItem.Enabled = true;
            }
            else
            {
                saveDataFileToolStripMenuItem.Enabled = false;
                printToolStripMenuItem.Enabled = false;
            }
        }
        /// <summary>
        /// Update button status in the GUI
        /// </summary>
        private void UpdateButtons()
        {
            if (lstTasks.Items.Count > 0 && lstTasks.SelectedItems.Count > 0)
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
        /// Update button status when selected index changes in listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }
        /// <summary>
        /// Enable/Disable Add button depending on if description textbox is empty or not
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
        /// Delete selected <see cref="Task"/> in the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems.Count == 0)
            {
                return; //Nothing selected
            }

            TaskId id = (TaskId)lstTasks.SelectedItems[0].Tag;

            if (id == null)
            {
                return; //Id is no good
            }

            //Ask if you really want to delete.
            DialogResult result = MessageBox.Show("Are you sure you want to delete task?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TaskManager.DeleteTask(id);

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
        /// Save a file to disk
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
                    {
                        return;
                    }

                    DialogResult result = MessageBox.Show($"Are you sure you want to save to file?\n\n{filePath}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string path = Path.GetDirectoryName(filePath);
                        string fileName = Path.GetFileName(filePath);

                        Classes.File file = new Classes.File(path, fileName);
                        TaskManager.SaveToFile(file);
                    }
                    else if (result == DialogResult.No)
                    {
                        return; //Do nothing
                    }
                }
                else
                {
                    //No need to do anything...
                }

                //Json method, alternative
                //Classes.File file2 = new Classes.File(@"C:\files", "save1.json");
                //TaskManager.SaveToJsonFile(file2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /// <summary>
        /// Read a file from disk
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

                    DialogResult result = MessageBox.Show($"Are you sure you want to load from file?\n\n{filePath}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string path = Path.GetDirectoryName(filePath);
                        string fileName = Path.GetFileName(filePath);

                        Classes.File file = new Classes.File(path, fileName);
                        TaskManager.ReadFromFile(file);
                        UpdateListView();
                        UpdateButtons();
                        UpdateFileMenu();
                    }
                    else if (result == DialogResult.No)
                    {
                        return; //Do nothing
                    }
                }
                else
                {
                    //No need to do anything...
                }

                //Json method, alternative
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
        /// Reset GUI to startup state
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
        /// Open FormEdit on double click in listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTasks_DoubleClick(object sender, EventArgs e)
        {
            btnChange_Click(sender, e);
        }
        /// <summary>
        /// Update MinDate property continuously to make it near impossible to enter a date and time that has already passed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }
        /// <summary>
        /// Print current TaskList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a PrintDocument object
            PrintDocument printDocument = new PrintDocument();

            // Handle the PrintPage event
            printDocument.PrintPage += (s, ev) =>
            {
                Graphics graphics = ev.Graphics;

                // Set the font and margin values
                Font font = new Font("Courier New", 12);
                int margin = 50;
                int yPos = margin;

                // Add headers
                graphics.DrawString($"{"Date",-12}{"Time",-10}{"Priority",-15}{"Description"}", font, Brushes.Black, margin, yPos);
                
                yPos += 20;

                // Iterate TaskList
                foreach (Assignment6.Classes.Task task in TaskManager.TaskList)
                {
                    graphics.DrawString($"{task.Date,-12}{task.Time,-10}{task.Priority,-15}{task.Description}", font, Brushes.Black, margin, yPos);

                    yPos += 20;
                }
            };

            // Display the PrintDialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        #endregion
    }
}
