/// <summary>
/// Filename: FormMain.cs
/// Created on: 2024-04-20 00:00:00
/// Author: Samuel Jeffman
/// </summary>
/// 

namespace Assignment6
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormMain : Form
    {
        #region Fields
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
        private void InitGUI()
        {
            lblTimer.Text = GetNowToString("HH:mm:ss");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTask_Click(object sender, EventArgs e)
        {

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
    }
}
