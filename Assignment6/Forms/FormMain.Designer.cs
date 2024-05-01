namespace Assignment6
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            openDataFileToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            lblDateAndTime = new Label();
            lblToDo = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblPriority = new Label();
            cmbPriority = new ComboBox();
            txtToDo = new TextBox();
            btnAddTask = new Button();
            grpTaskList = new GroupBox();
            lstTasks = new ListView();
            btnChange = new Button();
            btnDelete = new Button();
            lblTimer = new Label();
            updateClockTimer = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            updateMinDateTimer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            grpTaskList.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1082, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, toolStripSeparator1, openDataFileToolStripMenuItem, saveDataFileToolStripMenuItem, toolStripSeparator2, printToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(191, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(188, 6);
            // 
            // openDataFileToolStripMenuItem
            // 
            openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            openDataFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openDataFileToolStripMenuItem.Size = new Size(191, 22);
            openDataFileToolStripMenuItem.Text = "Open data file";
            openDataFileToolStripMenuItem.Click += openDataFileToolStripMenuItem_Click;
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveDataFileToolStripMenuItem.Size = new Size(191, 22);
            saveDataFileToolStripMenuItem.Text = "Save data file";
            saveDataFileToolStripMenuItem.Click += saveDataFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(188, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(191, 22);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += PrintToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(188, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(191, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(116, 22);
            aboutToolStripMenuItem.Text = "About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // lblDateAndTime
            // 
            lblDateAndTime.AutoSize = true;
            lblDateAndTime.Font = new Font("Segoe UI", 12F);
            lblDateAndTime.Location = new Point(12, 48);
            lblDateAndTime.Name = "lblDateAndTime";
            lblDateAndTime.Size = new Size(107, 21);
            lblDateAndTime.TabIndex = 1;
            lblDateAndTime.Text = "Date and time";
            // 
            // lblToDo
            // 
            lblToDo.AutoSize = true;
            lblToDo.Font = new Font("Segoe UI", 12F);
            lblToDo.Location = new Point(12, 92);
            lblToDo.Name = "lblToDo";
            lblToDo.Size = new Size(47, 21);
            lblToDo.TabIndex = 1;
            lblToDo.Text = "To do";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(148, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 29);
            dateTimePicker1.TabIndex = 2;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 12F);
            lblPriority.Location = new Point(525, 48);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(61, 21);
            lblPriority.TabIndex = 1;
            lblPriority.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.Font = new Font("Segoe UI", 12F);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(601, 45);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(172, 29);
            cmbPriority.TabIndex = 3;
            // 
            // txtToDo
            // 
            txtToDo.Font = new Font("Segoe UI", 12F);
            txtToDo.Location = new Point(148, 89);
            txtToDo.Name = "txtToDo";
            txtToDo.Size = new Size(625, 29);
            txtToDo.TabIndex = 4;
            txtToDo.TextChanged += txtToDo_TextChanged;
            // 
            // btnAddTask
            // 
            btnAddTask.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddTask.Location = new Point(148, 124);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(96, 31);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = "Add";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // grpTaskList
            // 
            grpTaskList.Controls.Add(lstTasks);
            grpTaskList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpTaskList.Location = new Point(12, 161);
            grpTaskList.Name = "grpTaskList";
            grpTaskList.Size = new Size(1058, 348);
            grpTaskList.TabIndex = 6;
            grpTaskList.TabStop = false;
            grpTaskList.Text = "To Do";
            // 
            // lstTasks
            // 
            lstTasks.FullRowSelect = true;
            lstTasks.Location = new Point(6, 28);
            lstTasks.MultiSelect = false;
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(1046, 314);
            lstTasks.Sorting = SortOrder.Ascending;
            lstTasks.TabIndex = 0;
            lstTasks.UseCompatibleStateImageBehavior = false;
            lstTasks.SelectedIndexChanged += lstTasks_SelectedIndexChanged;
            lstTasks.DoubleClick += lstTasks_DoubleClick;
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChange.Location = new Point(148, 509);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(96, 31);
            btnChange.TabIndex = 7;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(331, 509);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 31);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTimer
            // 
            lblTimer.BorderStyle = BorderStyle.FixedSingle;
            lblTimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(982, 517);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(82, 23);
            lblTimer.TabIndex = 8;
            lblTimer.Text = "00:00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updateClockTimer
            // 
            updateClockTimer.Enabled = true;
            updateClockTimer.Interval = 1000;
            updateClockTimer.Tick += updateClockTimer_Tick;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 0;
            toolTip1.ShowAlways = true;
            toolTip1.UseAnimation = false;
            // 
            // updateMinDateTimer
            // 
            updateMinDateTimer.Enabled = true;
            updateMinDateTimer.Interval = 60000;
            updateMinDateTimer.Tick += updateMinDateTimer_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 556);
            Controls.Add(lblTimer);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(grpTaskList);
            Controls.Add(btnAddTask);
            Controls.Add(txtToDo);
            Controls.Add(cmbPriority);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblToDo);
            Controls.Add(lblPriority);
            Controls.Add(lblDateAndTime);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Reminder application by Samuel Jeffman";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpTaskList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem openDataFileToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label lblDateAndTime;
        private Label lblToDo;
        private DateTimePicker dateTimePicker1;
        private Label lblPriority;
        private ComboBox cmbPriority;
        private TextBox txtToDo;
        private Button btnAddTask;
        private GroupBox grpTaskList;
        private ListView lstTasks;
        private Button btnChange;
        private Button btnDelete;
        private Label lblTimer;
        private System.Windows.Forms.Timer updateClockTimer;
        private ToolTip toolTip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer updateMinDateTimer;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
    }
}
