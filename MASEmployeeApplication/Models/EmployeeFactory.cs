using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MASEmployeeApplication.Models
{
    public class EmployeeFactory
    {
        public AbstractEmployee BuildEmployee(RawEmployee employee)
        {

            AbstractEmployee newEmployee = GetEmployeePerContractType(employee);

            newEmployee.Id = employee.Id;
            newEmployee.Name = employee.Name;
            newEmployee.RoleId = employee.RoleId;
            newEmployee.RoleName = employee.RoleName;
            newEmployee.RoleDescription = employee.RoleDescription;
            newEmployee.HourlySalary = employee.HourlySalary;
            newEmployee.MonthlySalary = employee.MonthlySalary;

            newEmployee.CalculateAnnualSalary();
            return newEmployee;
        }

        private AbstractEmployee GetEmployeePerContractType(RawEmployee employee)
        {
            switch (employee.ContractTypeName)
            {
                case "HourlySalaryEmployee":
                    return new HourlySalaryEmployee();
                case "MonthlySalaryEmployee":
                    return new MonthlySalaryEmployee();
                default:
                    throw new InvalidOperationException("Cannot create an object of this contract type");
            }
        }
    }
}