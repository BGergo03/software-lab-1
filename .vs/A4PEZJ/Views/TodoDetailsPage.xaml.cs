using A4PEZJ.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace A4PEZJ.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TodoDetailsPage : Page
    {

        public TodoItem Todo { get; set; } = new TodoItem()
        {
                Title = "",
                Description = "",
                Priority = Priority.Normal,
                IsDone = false,
                Deadline = DateTimeOffset.Now
        };

        public List<Priority> Priorities { get; set; } = Enum.GetValues(typeof(Priority)).Cast<Priority>().ToList();

        public TodoDetailsPage()
        {
            this.InitializeComponent();
            DataContext = this;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            Todo.Id = MainPage.Todos.Max(t => t.Id) + 1;
            MainPage.Todos.Add(Todo);
            Frame.Navigate(typeof(MainPage), null);
        }
    }
}
