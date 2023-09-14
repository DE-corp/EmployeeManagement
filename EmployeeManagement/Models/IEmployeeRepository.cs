using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        Employee GetById(Guid id);

        void Add(Employee employee);

        void Delete(Guid id);
    }
}
