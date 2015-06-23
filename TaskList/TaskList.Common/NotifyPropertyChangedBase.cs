using System.ComponentModel;

namespace TaskList.Common
{
    /// <summary>
    /// Base class which implements INotifyPropertyChanged
    /// To be used whenever we need to have change events
    /// </summary>
    public class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
