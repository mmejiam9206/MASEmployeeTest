using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MASEmployeeApplication.Models
{
    public class HourlySalaryEmployee : AbstractEmployee
    {
        private double annualSalary;
        private String contractType = "Hourly";
        public double AnnualSalary { get => annualSalary; set => annualSalary = value; }
        public String ContractType { get => contractType; }


        public override void CalculateAnnualSalary()
        {
            AnnualSalary = 120 * this.HourlySalary * 12;
        }
    }
}