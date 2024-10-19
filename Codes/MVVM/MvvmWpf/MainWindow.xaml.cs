using System.Windows;

namespace MvvmWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new PersonViewModel();
            this.DataContext = _viewModel; // Set the DataContext to the ViewModel
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            // Call the SubmitData method in the ViewModel to update FeedbackMessage
            _viewModel.SubmitData();
        }
    }
}