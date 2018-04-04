using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MASEmployeeApplication.Models
{
    public class MonthlySalaryEmployee : AbstractEmployee
    {
        private double annualSalary;
        private String contractType = "Monthly";
        public double AnnualSalary { get => annualSalary; set => annualSalary = value; }
        public String ContractType { get => contractType; }

        public override void CalculateAnnualSalary()
        {
            AnnualSalary =  MonthlySalary * 12;
        }
    }
}