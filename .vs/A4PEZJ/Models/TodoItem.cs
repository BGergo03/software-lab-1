using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace A4PEZJ.Models
{
    public class TodoItem : INotifyPropertyChanged
    {
        private bool isDone;
        private string title;
        private string description;
        private DateTimeOffset deadline;
        private Priority priority;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }
        public bool IsDone {
            get => isDone;
            set
            {
                if (isDone != value)
                {
                    isDone = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Title {
            get => title;
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Description {
            get => description;
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTimeOffset Deadline {
            get => deadline;
            set
            {
                if (deadline != value)
                {
                    deadline = value;
                    OnPropertyChanged();
                }
            }
        }
        public Priority Priority {
            get => priority;
            set
            {
                if (priority != value)
                {
                    priority = value;
                    OnPropertyChanged();
                }
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
