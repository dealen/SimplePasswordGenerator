using PasswordGenerator.ViewModels;
using System.Windows;

namespace PasswordGenerator.Views
{
    public partial class MainWindow : Window
    {
        private VMPasswordGenerator _oPasswordGenerator;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = PasswordGenerator;
        }
        
        private VMPasswordGenerator PasswordGenerator
        {
            get
            {
                if (_oPasswordGenerator == null)
                {
                    _oPasswordGenerator = new VMPasswordGenerator();
                }

                return _oPasswordGenerator;
            }
        }
    }
}
