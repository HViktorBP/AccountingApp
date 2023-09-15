using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.Model
{
    public class TaskTimeAllocation
    {
        #region Variables
        public string TaskName { get; set; } = null!;
        public int TotalHours { get; set; }
        #endregion
    }
}
