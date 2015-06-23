using System;
using TaskList.Common;

namespace TaskList.Data.Entities
{
    public class Task : NotifyPropertyChangedBase // The task needs to implement change notifications to display the IsFinished status on the screen
    {
        public int Id { get; set; }
        public string Description { get; private set; }

        public DateTime DateStarted { get; private set; }
        public DateTime? DateFinished { get; private set; }

        public User Owner { get; private set; }

        public bool IsFinished
        {
            get { return DateFinished.HasValue; }
        }

        /// <summary>
        /// A task can't be created without a description and an owner
        /// </summary>
        /// <param name="description"></param>
        /// <param name="owner"></param>
        public Task(string description, User owner)
        {
            DateStarted = DateTime.Now;
            Description = description;
            Owner = owner;
        }

        /// <summary>
        /// When a task is finished we set the date and time when it is finished
        /// We also emit a change for the IsFinished property
        /// </summary>
        public void Finish()
        {
            DateFinished = DateTime.Now;
            NotifyPropertyChanged("IsFinished");
        }
    }
}
