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
	public partial class RegisterLogin : Form
	{
		public RegisterLogin()
		{
			InitializeComponent();

		
		}

		Users usrArr = new Users();

		                                                                                                                                                     
		private void btn_register_Click(object sender, EventArgs e)
		{


			label_name.Text = "";
			label_surname.Text = "";
			label_age.Text = "";
			label_email.Text = "";
			label_password.Text = "";

			Validator validate = new Validator();
			User user = new User();

			if (string.IsNullOrEmpty(txbx_age.Text))
			{
				label_age.Text = "Please Enter Your Age";
				txbx_age.Text = "0";

			}

			user.name = txbx_name.Text;
			user.surname = txbx_surname.Text;
			user.age = Convert.ToByte(txbx_age.Text);
			user.Email = txbx_email.Text;
			user.password = txbx_password.Text;

			if (!validate.IsInvalid(user,this)) 
			{
				
				
				if (usrArr.Add(user)) {
					MessageBox.Show("Register has been Successful");
				 lbl_account_count.Text=usrArr.UsersCount();
				}
			}
			else
			{
				MessageBox.Show("Not Successful");
			}
		}
		
		private void btn_login_Click(object sender, EventArgs e)
		{
			string email = txbx_login_email.Text;
			string password = txbx_login_password.Text;

			if (usrArr.HasUser(email, password))
			{
				Hide();
				Session.CurrentUserName = email;
				administration administrationscreen = new administration();
				administrationscreen.Show();

			}
		
		
			else 
			{
				MessageBox.Show("Login is not success for this user" + email);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lbl_account_count.Text = usrArr.UsersCount();
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			if (txbx_login_password.UseSystemPasswordChar == true)
			{
				txbx_login_password.UseSystemPasswordChar = false;
				pictureBox10.Image = Properties.Resources.show_hide_icon_20;


			}
			else
			{
				txbx_login_password.UseSystemPasswordChar = true;
				pictureBox10.Image = Properties.Resources._772420_200;

			}
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			if (txbx_password.UseSystemPasswordChar == true)
			{
				txbx_password.UseSystemPasswordChar = false;
				pictureBox10.Image = Properties.Resources.show_hide_icon_20;


			}
			else
			{
				txbx_password.UseSystemPasswordChar = true;
				pictureBox10.Image = Properties.Resources._772420_200;

			}
		}

		private void RegisterLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			Session.form.Close();

		}

		private void back_home_Click(object sender, EventArgs e)
		{
			HomeScreen homescreen = new HomeScreen();
			this.Hide();
			homescreen.ShowDialog();
		}
	}

   
}
