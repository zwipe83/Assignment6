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
            openDataFileToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
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
            lblDescription = new Label();
            lblPriorityList = new Label();
            lblTime = new Label();
            lblDate = new Label();
            lstTasks = new ListView();
            btnChange = new Button();
            btnDelete = new Button();
            lblTimer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openDataFileToolStripMenuItem, saveDataFileToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(148, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openDataFileToolStripMenuItem
            // 
            openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            openDataFileToolStripMenuItem.Size = new Size(148, 22);
            openDataFileToolStripMenuItem.Text = "Open data file";
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.Size = new Size(148, 22);
            saveDataFileToolStripMenuItem.Text = "Save data file";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(148, 22);
            exitToolStripMenuItem.Text = "Exit";
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
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
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
            grpTaskList.Controls.Add(lblDescription);
            grpTaskList.Controls.Add(lblPriorityList);
            grpTaskList.Controls.Add(lblTime);
            grpTaskList.Controls.Add(lblDate);
            grpTaskList.Controls.Add(lstTasks);
            grpTaskList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpTaskList.Location = new Point(12, 161);
            grpTaskList.Name = "grpTaskList";
            grpTaskList.Size = new Size(1058, 348);
            grpTaskList.TabIndex = 6;
            grpTaskList.TabStop = false;
            grpTaskList.Text = "To Do";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(589, 36);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(89, 21);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblPriorityList
            // 
            lblPriorityList.AutoSize = true;
            lblPriorityList.Location = new Point(354, 36);
            lblPriorityList.Name = "lblPriorityList";
            lblPriorityList.Size = new Size(61, 21);
            lblPriorityList.TabIndex = 1;
            lblPriorityList.Text = "Priority";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(190, 36);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(44, 21);
            lblTime.TabIndex = 1;
            lblTime.Text = "Time";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(30, 36);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(42, 21);
            lblDate.TabIndex = 1;
            lblDate.Text = "Date";
            // 
            // lstTasks
            // 
            lstTasks.Location = new Point(6, 60);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(1046, 282);
            lstTasks.TabIndex = 0;
            lstTasks.UseCompatibleStateImageBehavior = false;
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
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
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
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Reminder application by Samuel Jeffman";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpTaskList.ResumeLayout(false);
            grpTaskList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
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
        private Label lblDate;
        private Label lblTime;
        private Label lblPriorityList;
        private Label lblDescription;
        private Button btnChange;
        private Button btnDelete;
        private Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}
