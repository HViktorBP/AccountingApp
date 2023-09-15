using AccountingApp.Model;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace AccountingApp.DAL
{
    public class AccountingDAL
    {
        #region Variables
        private string connectionString;
        private SqlConnection connection = null!;
        #endregion

        #region Constructor
        /// <summary>
        /// Class constructor. Creates the connection betwwen app and database.
        /// </summary>
        public AccountingDAL()
        {
            connectionString = "Data Source=DESKTOP-1FH7N6R\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True"; // Please, paste here your connectionString!
        }
        #endregion

        #region Public methods
        /// <summary>
        /// InsertData method inserts data into table.
        /// </summary>
        /// <param name="workerName">Worker's name</param>
        /// <param name="workerTask">Workers's task</param>
        /// <param name="workerComments">Worker's comment</param>
        /// <param name="workerDate">Worker's date</param>
        /// <param name="workerStartTime">Worker's starting time</param>
        /// <param name="workerFinishTime">Worker's finishing time</param>
        /// <returns>If method was executed successfully - true, else - false</returns>
        public bool InsertData(string workerName, string workerTask, string workerComments, DateTime workerDate, DateTime workerStartTime, DateTime workerFinishTime)
        {
            try // Program validates data before we inserting it, but it still needs this try-block because of the possible error connection
            {
                OpenConnection();

                string query = "INSERT INTO AccountingApp (WorkerName, WorkerTask, WorkerComments, WorkerDate, WorkerStartTime, WorkerFinishTime) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", workerName);
                    command.Parameters.AddWithValue("@Value2", workerTask);
                    command.Parameters.AddWithValue("@Value3", workerComments);
                    command.Parameters.AddWithValue("@Value4", workerDate);
                    command.Parameters.AddWithValue("@Value5", workerStartTime);
                    command.Parameters.AddWithValue("@Value6", workerFinishTime);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// GetData gets all the data from table.
        /// </summary>
        /// <returns>Datab table</returns>
        public DataTable GetData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM AccountingApp";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        /// <summary>
        /// GetTaskTimeAllocations gets the hours which where spent on each task during a period of time.
        /// </summary>
        /// <param name="fromDate">Starting date</param>
        /// <param name="untilDate">Finishing date</param>
        /// <returns>List of each performed task and hours spent on each of them</returns>
        public List<TaskTimeAllocation> GetTaskTimeAllocations(DateTime fromDate, DateTime untilDate)
        {
            List<TaskTimeAllocation> taskAllocations = new List<TaskTimeAllocation>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT WorkerTask, SUM(DATEDIFF(HOUR, WorkerStartTime, WorkerFinishTime)) AS TotalHours FROM AccountingApp WHERE WorkerDate >= @fromDate AND WorkerDate <= @untilDate GROUP BY WorkerTask";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@untilDate", untilDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TaskTimeAllocation allocation = new TaskTimeAllocation
                            {
                                TaskName = reader["WorkerTask"].ToString() ?? "Not task was performed.",
                                TotalHours = Int32.Parse(reader["TotalHours"].ToString() ?? "0"),
                            };

                            taskAllocations.Add(allocation);
                        }
                    }
                }
            }

            return taskAllocations;
        }

        /// <summary>
        /// GetWorkerData gets the tasks and the hours he spent on each of them during the period of time.
        /// </summary>
        /// <param name="fromDate">Starting date</param>
        /// <param name="untilDate">Finishing date</param>
        /// <param name="name">Worker's name</param>
        /// <returns>List of completed tasks by worker and hours spent on each of them</returns>
        public List<TaskTimeAllocation> GetWorkerData(DateTime fromDate, DateTime untilDate, string name)
        {
            List<TaskTimeAllocation> taskAllocations = new List<TaskTimeAllocation>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT WorkerTask, SUM(DATEDIFF(HOUR, WorkerStartTime, WorkerFinishTime)) AS TotalHours FROM AccountingApp WHERE WorkerName = @name AND WorkerDate >= @fromDate AND WorkerDate <= @untilDate GROUP BY WorkerTask";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@untilDate", untilDate);
                    command.Parameters.AddWithValue("@name", name);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TaskTimeAllocation allocation = new TaskTimeAllocation
                            {
                                TaskName = reader["WorkerTask"].ToString() ?? "There is no worker with the name you've given.",
                                TotalHours = Int32.Parse(reader["TotalHours"].ToString() ?? "0"),
                            };

                            taskAllocations.Add(allocation);
                        }
                    }
                }
            }

            return taskAllocations;
        }
        #endregion

        #region Private methods
        /// <summary>
        /// OpenConnection opens the connection between database and application in a safe way.
        /// </summary>
        private void OpenConnection()
        {
            if (connection == null)
                connection = new SqlConnection(connectionString);

            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        /// <summary>
        /// CloseConnection closes the connection in a safe way.
        /// </summary>
        private void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }
        #endregion
    }
}
