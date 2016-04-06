using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaskList.Data.Entities;
using TaskList.UserInterface.ViewModels;

namespace TaskList.UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TaskListViewModel ViewModel
        {
            get { return (TaskListViewModel) DataContext; }
        }

        public MainWindow()
        {
            DataContext = new TaskListViewModel();
            InitializeComponent();
        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            ViewModel.AddTask();
        }

        private void FinishTask(object sender, RoutedEventArgs e)
        {
            var button = (Button) sender;
            var task = (Task) button.DataContext;

            ViewModel.FinishTask(task);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveTask(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var task = (Task)button.DataContext;
            ViewModel.RemoveTask(task);
        }
    }
}
