using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EmployeeManagement.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : Window
    {
        private IEmployeeViewModel _employeeViewModel;
        private IEmployeesViewModel _employeesViewModel;
        public EmployeesView(IEmployeesViewModel employeesViewModel, IEmployeeViewModel employeeViewModel)
        {
            _employeeViewModel = employeeViewModel;
            _employeesViewModel = employeesViewModel;

            InitializeComponent();
            DataContext = employeesViewModel;
        }

        private void ListView_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;

            if (item is null)
            {
                return;
            }

            var employee = item as Employee;

            _employeeViewModel.Employee = employee;

            var employeeView = new EmployeeView(_employeeViewModel);

            employeeView.Show();
        }
    }
}
