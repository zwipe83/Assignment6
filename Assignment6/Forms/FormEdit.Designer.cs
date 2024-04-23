namespace Assignment6.Forms
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnSaveTask = new Button();
            txtToDo = new TextBox();
            cmbPriority = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            lblToDo = new Label();
            lblPriority = new Label();
            lblDateAndTime = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnSaveTask
            // 
            btnSaveTask.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveTask.Location = new Point(148, 112);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(96, 31);
            btnSaveTask.TabIndex = 12;
            btnSaveTask.Text = "Save";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // txtToDo
            // 
            txtToDo.Font = new Font("Segoe UI", 12F);
            txtToDo.Location = new Point(148, 77);
            txtToDo.Name = "txtToDo";
            txtToDo.Size = new Size(625, 29);
            txtToDo.TabIndex = 11;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.Font = new Font("Segoe UI", 12F);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(601, 33);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(172, 29);
            cmbPriority.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(148, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 29);
            dateTimePicker1.TabIndex = 9;
            // 
            // lblToDo
            // 
            lblToDo.AutoSize = true;
            lblToDo.Font = new Font("Segoe UI", 12F);
            lblToDo.Location = new Point(12, 80);
            lblToDo.Name = "lblToDo";
            lblToDo.Size = new Size(47, 21);
            lblToDo.TabIndex = 6;
            lblToDo.Text = "To do";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 12F);
            lblPriority.Location = new Point(525, 36);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(61, 21);
            lblPriority.TabIndex = 7;
            lblPriority.Text = "Priority";
            // 
            // lblDateAndTime
            // 
            lblDateAndTime.AutoSize = true;
            lblDateAndTime.Font = new Font("Segoe UI", 12F);
            lblDateAndTime.Location = new Point(12, 36);
            lblDateAndTime.Name = "lblDateAndTime";
            lblDateAndTime.Size = new Size(107, 21);
            lblDateAndTime.TabIndex = 8;
            lblDateAndTime.Text = "Date and time";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 60000;
            timer2.Tick += timer2_Tick;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 165);
            Controls.Add(btnSaveTask);
            Controls.Add(txtToDo);
            Controls.Add(cmbPriority);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblToDo);
            Controls.Add(lblPriority);
            Controls.Add(lblDateAndTime);
            Name = "FormEdit";
            Text = "Edit task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveTask;
        private TextBox txtToDo;
        private ComboBox cmbPriority;
        private DateTimePicker dateTimePicker1;
        private Label lblToDo;
        private Label lblPriority;
        private Label lblDateAndTime;
        private System.Windows.Forms.Timer timer2;
    }
}