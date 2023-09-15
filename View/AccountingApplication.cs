using AccountingApp.DAL;
using AccountingApp.Model;
using AccountingApp.View;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccountingApp
{
    public partial class AccountingApplication : Form
    {
        #region Variables
        static private AccountingDAL dal = new AccountingDAL(); // after creating the form, it will automatily connect to the database
        #endregion

        #region Constructor
        /// <summary>
        /// Class constructor.
        /// </summary>
        public AccountingApplication()
        {
            InitializeComponent();
            workerTaskValue.Items.AddRange(new string[] { "Coding", "Testing", "Debugging", "Meeting", "Else" });
            workerTaskValue.SelectedIndex = 0;
        }
        #endregion

        #region Private events
        /// <summary>
        /// sendingButton_Click sends data to the table.
        /// </summary>
        private void sendingButton_Click(object sender, EventArgs e)
        {
            DateTime resultDate;
            DateTime taskStart;
            DateTime taskFinish;

            string dateMask = "dd/MM/yyyy";
            string hourMask = "HH:mm";
            string userDate = workerDateValue.Text;
            string userStart = workerTimeStartValue.Text;
            string userUntil = workerTimeUntilValue.Text;


            if (DateTime.TryParseExact(userDate, dateMask, null, System.Globalization.DateTimeStyles.None, out resultDate) &&
                DateTime.TryParseExact(userStart, hourMask, null, System.Globalization.DateTimeStyles.None, out taskStart) &&
                DateTime.TryParseExact(userUntil, hourMask, null, System.Globalization.DateTimeStyles.None, out taskFinish))
            {
                if (!workerNameValue.Text.Any(char.IsDigit)
                    && !workerNameValue.Text.IsNullOrEmpty()
                    && CheckUserTask()
                    && CheckInterval())
                    dal.InsertData(workerNameValue.Text, workerTaskValue.Text, workerCommentValue.Text, resultDate, taskStart, taskFinish);
                else
                    MessageBox.Show("The data you provided is not valid. Please, correct it and try again!", "Invalid data.");
            }
            else
            {
                MessageBox.Show("Invalid date or time format.");
            }

        }

        /// <summary>
        /// buttonTasksTimeAmount_Click gets data on each task (in particular, on how much hours were spent on each).
        /// </summary>
        private void buttonTasksTimeAmount_Click(object sender, EventArgs e)
        {
            DateTime fromDate;
            DateTime untilDate;

            string dateMask = "dd/MM/yyyy";
            string fromDateStr = dateIntervalumFromValue.Text;
            string untilDateStr = dateIntervalumUntilValue.Text;

            if (DateTime.TryParseExact(fromDateStr, dateMask, null, System.Globalization.DateTimeStyles.None, out fromDate) &&
                DateTime.TryParseExact(untilDateStr, dateMask, null, System.Globalization.DateTimeStyles.None, out untilDate))
            {
                List<TaskTimeAllocation> tasks = dal.GetTaskTimeAllocations(fromDate, untilDate);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    PrintTaskAllocationsToFile(tasks, saveFileDialog.FileName);
            }

        }

        /// <summary>
        /// buttonWorker_Click gets data on a worker (the tasks he had done and the amount of time he spent on each).
        /// </summary>
        private void buttonWorker_Click(object sender, EventArgs e)
        {
            DateTime fromDate;
            DateTime untilDate;

            string dateMask = "dd/MM/yyyy";
            string fromDateStr = dateIntervalumFromValue.Text;
            string untilDateStr = dateIntervalumUntilValue.Text;

            if (DateTime.TryParseExact(fromDateStr, dateMask, null, System.Globalization.DateTimeStyles.None, out fromDate) &&
                DateTime.TryParseExact(untilDateStr, dateMask, null, System.Globalization.DateTimeStyles.None, out untilDate) &&
                !workerValue.Text.Any(char.IsDigit) &&
                !workerValue.Text.IsNullOrEmpty()
                )
            {
                List<TaskTimeAllocation> tasks = dal.GetWorkerData(fromDate, untilDate, workerValue.Text);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    PrintTaskAllocationsToFile(tasks, saveFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Invalid date or user name. Make sure you've filled out the From: and Until: fields!", "Invalid data.");
            }
        }

        /// <summary>
        /// usersDataButton_Click opens a new form, where the whole data in table can be seen.
        /// </summary>
        private void usersDataButton_Click(object sender, EventArgs e)
        {
            WorkersData usersData = new WorkersData(dal);
            usersData.ShowDialog();
        }
        #endregion

        #region Private methods
        /// <summary>
        /// CheckUserTask checks if there the task was choosen.
        /// </summary>
        /// <returns>If any task selected - true, else - false</returns>
        private bool CheckUserTask()
        {
            return workerTaskValue.SelectedIndex >= 0;
        }

        /// <summary>
        /// CheckInterval validates the interval which was given by user.
        /// </summary>
        /// <returns>If the intervalum was given correctly - true, else - false</returns>
        private bool CheckInterval()
        {
            string[] start = workerTimeStartValue.Text.Split(':');
            string[] end = workerTimeUntilValue.Text.Split(':');

            if (start.Length == 2 &&
                int.TryParse(start[0], out int hoursStart) &&
                int.TryParse(start[1], out int minutesStart) &&
                end.Length == 2 &&
                int.TryParse(end[0], out int hoursEnd) &&
                int.TryParse(end[1], out int minutesEnd))
            {

                if ((hoursStart * 60) + minutesStart > 1440 || (hoursEnd * 60) + minutesEnd > 1440 || ((hoursEnd * 60) + minutesEnd) - ((hoursStart * 60) + minutesStart) < 0)
                    return false;

                return true;
            }

            return false;
        }

        /// <summary>
        /// PrintTaskAllocationsToFile prints the collected data from table to file.
        /// </summary>
        /// <param name="taskAllocations">List of tasks and hours spent on each</param>
        /// <param name="filePath">File path</param>
        private void PrintTaskAllocationsToFile(List<TaskTimeAllocation> taskAllocations, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Task Name | Total Hours");

                    foreach (var allocation in taskAllocations)
                    {
                        string line = $"{allocation.TaskName} | {allocation.TotalHours}";
                        writer.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
        }
        #endregion
    }
}
