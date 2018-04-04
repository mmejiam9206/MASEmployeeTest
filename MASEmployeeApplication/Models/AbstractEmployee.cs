using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MASEmployeeApplication.Models
{
    public abstract class AbstractEmployee
    {
        public abstract void CalculateAnnualSalary();

        private int id;
        private String name;
        private int roleId;
        private String roleName;
        private String roleDescription;
        private double hourlySalary;
        private double monthlySalary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int RoleId { get => roleId; set => roleId = value; }
        public string RoleName { get => roleName; set => roleName = value; }
        public string RoleDescription { get => roleDescription; set => roleDescription = value; }
        public double HourlySalary { get => hourlySalary; set => hourlySalary = value; }
        public double MonthlySalary { get => monthlySalary; set => monthlySalary = value; }

    }
}