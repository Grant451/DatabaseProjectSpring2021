using System;
using System.Collections.Generic;
using System.Text;
using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;


namespace LocationData
{
    internal class CreateRepairDataDelegate : NonQueryDataDelegate<Repair>
    {
        private string RepName;
        private string LaborCost;
        private string Status;

        public CreateRepairDataDelegate(string repName, string laborCost, string status)
            : base("AutoShop.CreateRepair")
        {
            this.RepName = repName;
            this.LaborCost = laborCost;
            this.Status = status;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("RepairName", SqlDbType.NVarChar);
            p.Value = RepName;

            p = command.Parameters.Add("LaborCost", SqlDbType.NVarChar);
            p.Value = LaborCost;

            p = command.Parameters.Add("Status", SqlDbType.NVarChar);
            p.Value = Status;
        }

        public override Repair Translate(SqlCommand command)
        {
            return new Repair(RepName, LaborCost, Status);
        }


    }
}