using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MvvmWinForms
{
    public partial class MainForm : Form
    {
        private PersonViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new PersonViewModel();
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            // TwoWay binding: Name <--> TextBox
            txtName.DataBindings.Add("Text", _viewModel, "Name", false, DataSourceUpdateMode.OnPropertyChanged);

            // OneWay binding: Age (Read-Only in Label)
            lblAge.DataBindings.Add("Text", _viewModel, "Age", false, DataSourceUpdateMode.Never);

            // TwoWay binding: Age <--> TextBox
            txtAge.DataBindings.Add("Text", _viewModel, "Age", false, DataSourceUpdateMode.OnPropertyChanged);

            // OneWayToSource binding: InputMessage (View to ViewModel only)
            txtInputMessage.TextChanged += (sender, e) => _viewModel.InputMessage = txtInputMessage.Text;

            // OneWay binding: FeedbackMessage (ViewModel to Label)
            lblFeedbackMessage.DataBindings.Add("Text", _viewModel, "FeedbackMessage", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Call the ViewModel method to update the FeedbackMessage
            _viewModel.SubmitData();
        }
    }
}
