using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
	public static class Houses
	{
		private static ArrayList _houses;
		private static byte _counter;
	    
		static Houses(){ 

			_houses = new ArrayList();
			
		}

		public static void Add(Home home)
		{
			_houses.Add(home);
		}


		public static Home[] GetHouseByUser(string email)
		{
			Home[] houses = GetAllHouse();
			Home[] foundHome = null;
			ArrayList hs = new ArrayList();
			foreach (Home home in houses)
			{
				if (home.Seller == email)
				{
					hs.Add(home);
				}
			}

			foundHome = new Home[hs.Count];
			for (int i = 0;i<hs.Count;i++) {
				houses[i] = (Home)_houses[i];
			}
			return foundHome;
		}


		public static int HomeCount()
		{
			return _houses.Count;

		}

	  public static int UserHomeCount(string email)
		{
			return GetHouseByUser(email).Length;
		}

		public static Home[] GetAllHouse()
		{
			int count = _houses.Count;
			Home[] houses = new Home[count];

			for (int i = 0;i<count;i++) {
				houses[i] = (Home)_houses[i];
			}
			return houses;
		}
	}
}
