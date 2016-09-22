using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Models
{
    public class PasswordParameters
    {
        public PasswordParameters(int length, bool uppercase, bool lowercase, bool numbers, bool special)
        {
            Length = length;
            AreUppercaseCharsAllowed = uppercase;
            AreLowerCaseCharsAllowed = lowercase;
            AreNumbersAllowed = numbers;
            AreSpecialSignsAllowed = special;
        }

        public PasswordParameters()
        {
        }

        public bool IsAnyChecked()
        {
            return AreLowerCaseCharsAllowed || AreUppercaseCharsAllowed || AreSpecialSignsAllowed || AreNumbersAllowed;
        }

        public int Length { get; set; }
        public bool AreUppercaseCharsAllowed { get; set; }
        public bool AreNumbersAllowed { get; set; }
        public bool AreLowerCaseCharsAllowed { get; set; }
        public bool AreSpecialSignsAllowed { get; set; }
    }
}
