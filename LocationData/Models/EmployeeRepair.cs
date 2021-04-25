using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class EmployeeRepair
    {
        /*
        E.EmployeeName,
	    COUNT(DISTINCT IIF(R.[Status] = 'Complete', R.[Status], NULL)) AS RepairsCompleted,
	    COUNT(DISTINCT IIF(R.[Status] = 'In Progress', R.[Status], NULL)) AS RepairsInProgress  
        */
        public string EmployeeName { get; }
        public int RepairsCompleted { get; }
        public int RepairsInProgress { get; }

        public EmployeeRepair(string employeeName)
        {
            EmployeeName = employeeName;
        }

        public EmployeeRepair(int repCompleted, int repInProgress)
        {
            RepairsCompleted = repCompleted;
            RepairsInProgress = repInProgress;
        }

        public EmployeeRepair(string empName, int repCompleted, int repInProgress)
        {
            EmployeeName = empName;
            RepairsCompleted = repCompleted;
            RepairsInProgress = repInProgress;
        }

    }
}
