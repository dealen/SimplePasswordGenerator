using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Utility
{
    public class PasswordMaker
    {
        private int _length;
        private bool _useLowercase;
        private bool _useUppercase;
        private bool _useNumbers;
        private bool _useSpecial;

        private string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUWVXYZ";
        private string lowercaseLetters = "abcdefghijklmnopqrstuvxyz";
        private string numbers = "0123456789";
        private string specialSigns = "!@#$%^&*()[]{}";

        public PasswordMaker(int lenght, bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial)
        {
            _length = lenght;
            _useNumbers = useNumbers;
            _useSpecial = useSpecial;
            _useLowercase = useLowercase;
            _useUppercase = useUppercase;
        }

        public string GeneratePassword()
        {
            var passwordBase = string.Empty;

            if (_useLowercase)
                passwordBase += lowercaseLetters;
            if (_useNumbers)
                passwordBase += numbers;
            if (_useUppercase)
                passwordBase += uppercaseLetters;
            if (_useSpecial)
                passwordBase += specialSigns;

            var password = "";
            var rand = new Random();

            for (int i = 0; i < _length; i++)
                password += passwordBase[rand.Next(0, passwordBase.Length)];

            return password;
        }
    }
}
