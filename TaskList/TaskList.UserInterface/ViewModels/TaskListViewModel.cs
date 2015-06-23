using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using TaskList.Common;
using TaskList.Data.Entities;

namespace TaskList.UserInterface.ViewModels
{
    public class TaskListViewModel : NotifyPropertyChangedBase // The base class implements INotifyPropertyChanges so we can emit changes to the view
    {
        private readonly ICollection<Task> _tasks;

        /// <summary>
        /// ICollectionView makes it easy to filter and order items
        /// </summary>
        public ICollectionView TasksView { get; private set; }
        public ICollection<User> Users { get; private set; }

        /// <summary>
        /// Enable the AddTask button if a User is selected and a task description is entered
        /// </summary>
        public bool CanAddTask
        {
            get { return !string.IsNullOrWhiteSpace(NewTaskDescription) && SelectedUser.Id > 0; }
        }

        private string _newTaskDescription;
        public string NewTaskDescription
        {
            get { return _newTaskDescription; }
            set
            {
                _newTaskDescription = value;
                NotifyPropertyChanged("NewTaskDescription");
                NotifyPropertyChanged("CanAddTask"); // CanAddTask depends on this property, so we need to emit a change event for CanAddTask too
            }
        }

        private User _selectedUser = new User {Id = 0, Name = "All"}; // Initialize a "null" user, when selected all users' tasks are shown
        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;

                NotifyPropertyChanged("SelectedUser");
                NotifyPropertyChanged("CanAddTask"); // CanAddTask depends on this property, so we need to emit a change event for CanAddTask too
                TasksView.Refresh(); // when we select a user, we refresh the TasksView so that the collection will be appropriately filtered
            }
        }

        public TaskListViewModel()
        {
            Users = new List<User>() { SelectedUser };
            _tasks = new List<Task>();

            var u1 = new User { Id = 1,Name = "Ivan" };
            var u2 = new User { Id = 2, Name = "Ines" };

            Users.Add(u1);
            Users.Add(u2);

            var t1 = new Task("Clean kitchen", u1);
            var t2 = new Task("Wash dishes", u1);
            var t3 = new Task("Watch tv", u2);

            _tasks.Add(t1);
            _tasks.Add(t2);
            _tasks.Add(t3);

            TasksView = CollectionViewSource.GetDefaultView(_tasks);
            TasksView.Filter = FilterTasks; // Attach the FilterTasks method to the TasksView.Filter
        }

        public void AddTask()
        { 
            var task = new Task(NewTaskDescription, SelectedUser);

            NewTaskDescription = "";

            _tasks.Add(task);
            TasksView.Refresh();
        }

        public void FinishTask(Task task)
        {
            task.Finish();
        }

        /// <summary>
        /// A Task will be shown if: no user is selected OR the owner of the task is the currently selected user
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool FilterTasks(object obj)
        {
            if (SelectedUser == null || SelectedUser.Id == 0) return true;

            var task = (Task) obj;
            return task.Owner.Id == SelectedUser.Id;
        }
    }
}
