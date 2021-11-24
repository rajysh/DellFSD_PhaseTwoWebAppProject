using System.Collections.Generic;

namespace Day3_CoreMVCConcepts.Models
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        Employee GetEmployeeId (int employeeId);
        IList<Employee> GetEmployees();
    }
}