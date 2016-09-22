using PasswordGenerator.Models;
using PasswordGenerator.Utility;
using System.Windows;

namespace PasswordGenerator.ViewModels
{
    public class VMPasswordGenerator : ViewModel
    {
        #region Contructor

        public VMPasswordGenerator()
        {
            PasswordParams = new PasswordParameters();
        }

        #endregion Constructor


        #region Public Properties

        public PasswordParameters PasswordParams
        {
            get { return _oPasswordGenerator; }
            set
            {
                _oPasswordGenerator = value;
                OnPropertyChanged("PasswordGenerator");
            }
        }

        public string Password
        {
            get { return _strPassword; }
            set
            {
                _strPassword = value;
                OnPropertyChanged("Password");
            }
        }
                
        #endregion Public Properties


        #region Private Methods

        private void GeneratePassword(object sender)
        {
            if (!IsAnyFieldChecked())
            {
                MessageBox.Show("It is essential to check at least one of parameters.", "No password parameter choosen.", MessageBoxButton.OK);
                return;
            }

            PasswordMaker pwd = new PasswordMaker(
                PasswordParams.Length,
                PasswordParams.AreLowerCaseCharsAllowed,
                PasswordParams.AreUppercaseCharsAllowed,
                PasswordParams.AreNumbersAllowed,
                PasswordParams.AreSpecialSignsAllowed);

            Password = pwd.GeneratePassword();
        }

        private bool IsAnyFieldChecked()
        {
            return PasswordParams.IsAnyChecked();
        }

        #endregion Private Methods


        #region Public Commands

        public ViewModelCommand CommandGeneratePassword
        {
            get
            {
                return _cmdCommandGeneratePassword ?? (_cmdCommandGeneratePassword = new ViewModelCommand(GeneratePassword));
            }
        }

        #endregion Public Commands


        #region Private Fields

        private PasswordParameters _oPasswordGenerator;
        private string _strPassword;
        private ViewModelCommand _cmdCommandGeneratePassword;
        private bool _bIsNumbersCheked;
        private bool _bIsUpercaseChecked;
        private bool _bIsLowercaseChecked;
        private bool _bIsSpecialChecked;

        #endregion Private Fields
    }
}
