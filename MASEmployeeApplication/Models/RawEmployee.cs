using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MASEmployeeApplication.Models
{
    public class RawEmployee : AbstractEmployee
    {
        private String contractTypeName;
        public string ContractTypeName { get => contractTypeName; set => contractTypeName = value; }

        public override void CalculateAnnualSalary()
        {
            throw new NotImplementedException("This method is not available for this type of employee");
        }
    }
}