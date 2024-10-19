using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFStyle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> People { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Sample data for the ListBox
            People = new ObservableCollection<Person>
        {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Jane", Age = 25 },
            new Person { Name = "Mike", Age = 35 }
        };

            // Set DataContext to bind data to the UI
            this.DataContext = this;
        }
    }
}
