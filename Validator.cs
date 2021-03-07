using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
	class Validator
	{
		public bool IsInvalid(User user, RegisterLogin form)
		{
			bool hasError = false;
			if (string.IsNullOrEmpty(user.name))
			{
				form.label_name.Text = "Please Enter Your Name";
				hasError = true;
			}

			if (string.IsNullOrEmpty(user.surname))
			{
				form.label_surname.Text = "Please Enter Your Surname";
				hasError = true;

			}

			if (string.IsNullOrEmpty(Convert.ToString(user.age)))
			{
				
					form.label_age.Text = "Please Enter Your Age";
					hasError = true;

				}

				if (string.IsNullOrEmpty(user.Email))
				{
					form.label_email.Text = "Please Enter Your Email";
					hasError = true;

				}

				if (string.IsNullOrEmpty(user.password))
				{
					form.label_password.Text = "Please Enter Your Password";
					hasError = true;

				}

			return hasError;
			
		}
	}
}
