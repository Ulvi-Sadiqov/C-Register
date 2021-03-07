using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Register.Component;
namespace Register
{
	public partial class HomeScreen : Form
	{

		public HomeScreen()
		{

			InitializeComponent();

		}

		

		private void button2_Click(object sender, EventArgs e)
		{
			Hide();
			Session.form = this;

			RegisterLogin login = new RegisterLogin();
			login.ShowDialog();
		}


		private void HomeScreen_Load(object sender, EventArgs e)
		{
			Home[] AllHouses = Houses.GetAllHouse();
			int x = 12;
			foreach (Home home in AllHouses)
			{
				HomeControl homecontrol = new HomeControl();
				homecontrol.home_price.Text = home.Price.ToString();
				homecontrol.home_address.Text = home.Address;
				homecontrol.home_seller.Text = home.Seller;

				homecontrol.Location = new Point(x,300);
				x += 232;
				this.Controls.Add(homecontrol);
			}
		}

		private void HomeScreen_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}
	}
}
