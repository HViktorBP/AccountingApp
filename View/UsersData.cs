using AccountingApp.DAL;
using System.Data;
using System.Windows.Forms;

namespace AccountingApp.View
{
    public partial class WorkersData : Form
    {
        #region Variables
        private AccountingDAL dal = null!;
        #endregion

        #region Constructor
        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="dal">Database</param>
        public WorkersData(AccountingDAL dal)
        {
            InitializeComponent();
            this.dal = dal;
        }
        #endregion

        #region Private events
        /// <summary>
        /// UsersData_Load projects a table to user.
        /// </summary>
        private void UsersData_Load(object sender, EventArgs e)
        {
            DataGrid.DataSource = dal.GetData();
        }
        #endregion
    }
}
