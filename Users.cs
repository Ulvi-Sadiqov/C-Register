using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
	class Users
	{
		User[] users = new User[10];
		int counter = 0;
		

		public bool HasUser(string email,string Password)
		{
			bool hasUsr = false;
			for (int k = 0; k < users.Length; k++)
			{
				if (users[k] != null)
				{
					User u = users[k];
					if (u.Email == email && u.password == Password)
					{
						hasUsr = true;
					}
				}
			}
			return hasUsr;
		}
		public bool HasUser(string email)
		{
			bool hasUsr = false;
			for (int k = 0; k < users.Length;k++)
			{
				if(users[k] != null)
				{
					User u = users[k];
					if (u.Email ==email){
						hasUsr = true;
					}
				}
			}
			return hasUsr;

		}

		public bool Add(User usr)
		{
			bool successAdd = false; 

			if(counter == users.Length)
			{
				MessageBox.Show("The user array is full");
			}

			if (!HasUser(usr.Email)){

				users[counter] = usr;

				counter += 1;
				successAdd = true;
				
				}
			else
			{
				MessageBox.Show("This user has already exist");
			}
			return successAdd;
		}

		public string UsersCount()
		{
			int userCount = 0;
			for(int k = 0; k < users.Length; k++)
			{
				if (users[k]!=null)
				{
					userCount++;
				}
			}
			return Convert.ToString(userCount);

		}

	
	}
}
