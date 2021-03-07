using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
	public partial class administration : Form
	{
		public administration()
		{
			InitializeComponent();
		}

		private void administration_Load(object sender, EventArgs e)
		{
			Username.Text = Session.CurrentUserName;
			Count.Text = Houses.UserHomeCount(Session.CurrentUserName).ToString();

		}

		private void administration_FormClosed(object sender, FormClosedEventArgs e)
		{
			Session.form.Close();
		}

		private void AddHome_Click(object sender, EventArgs e)
		{
			Home home = new Home();
			home.Address = txbx_address.Text;
			home.Price = Convert.ToDecimal(txbx_price.Text);
			home.Seller = Session.CurrentUserName;

			Houses.Add(home);
			Count.Text = Houses.UserHomeCount(Session.CurrentUserName).ToString();
		}

		private void logout_btn_Click(object sender, EventArgs e)
		{
			Session.CurrentUserName = null;
			RegisterLogin registerScreen = new RegisterLogin();
			registerScreen.Show();

			this.Hide();
		}
	}
}
