using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_Lv6
{
    class PasswordValidator
    {
		private StringChecker first = new StringDigitChecker();
		private StringChecker last = new StringLowerCaseChecker();
		private StringUpperCaseChecker upperCaseChecker;

		public PasswordValidator(StringDigitChecker stringDigitChecker)
		{
			this.first = stringDigitChecker;
			this.last = stringDigitChecker;
			this.first.SetNext(null);
		}

		public PasswordValidator(StringUpperCaseChecker upperCaseChecker)
		{
			this.upperCaseChecker = upperCaseChecker;
		}

		public void AddNext(StringChecker stringChecker)
		{
			last.SetNext(stringChecker);
			last = stringChecker;
		}
		public bool checkValidation(string password)
		{
			return first.Check(password);
		}
	}
}
