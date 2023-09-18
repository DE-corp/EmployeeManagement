using EmployeeManagement.ViewModels;
using System.Windows;

namespace EmployeeManagement.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : Window
    {
        public EmployeeView(IEmployeeViewModel employeesViewModel)
        {
            InitializeComponent();
            DataContext = employeesViewModel;
        }
    }
}
