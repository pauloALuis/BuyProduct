

using Store.src.Enum;
using System.Collections.Generic;

namespace Store.src.Employee
{
    class Worker
    {

        private string _employeeName;
        private WorkerLevel _level;
        private double _baseSalary;
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        private Department _departmentName;

        public Department DepartmentName { get => DepartmentName1; set => DepartmentName1 = value; }
        internal WorkerLevel Level { get => _level; set => _level = value; }
        public double BaseSalary { get => _baseSalary; set => _baseSalary = value; }
        public string EmployeeName { get => _employeeName; set => _employeeName = value; }
        internal Department DepartmentName1 { get => _departmentName; set => _departmentName = value; }

        public Worker(string employeeName, WorkerLevel level, double baseSalary)
        {
            EmployeeName = employeeName;
            Level = level;
            BaseSalary = baseSalary;
        }

        public Worker(string employeeName, WorkerLevel level, double baseSalary,  Department departmentName) : this(employeeName, level, baseSalary)
        {
         
            DepartmentName1 = departmentName;
        }

        public Worker()
        {
        }

        public void AddContract(HourContract hourContract)
        {

            //List<HourContract> listContract = new List<HourContract>();
             Contracts.Add(hourContract);

        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.DateTime.Year == year && contract.DateTime.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
           
        }
        public void RemoveContract(HourContract hourContract)
        {
            Contracts.Remove(hourContract);


        }


        public override string ToString()
        {

            return base.ToString() + "(employeeName " + EmployeeName + ",baseSalary:" + BaseSalary + ",level:" + Level + ")";
        }





    }
}
