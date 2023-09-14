using EmployeeManagement.Models;
using System.Collections.ObjectModel;

namespace EmployeeManagement.ViewModels
{
    public interface IEmployeesViewModel
    {
        ObservableCollection<Employee> Employees { get; set; }
        string Filter { get; set; }
        string FilterMessage { get; set; }
    }
}
