namespace Register
{
	partial class administration
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Email = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Username = new System.Windows.Forms.Label();
			this.txbx_address = new System.Windows.Forms.TextBox();
			this.AddHome = new System.Windows.Forms.Button();
			this.txbx_price = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Count = new System.Windows.Forms.Label();
			this.logout_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(206, 28);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(0, 13);
			this.Email.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(309, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 18);
			this.label1.TabIndex = 1;
			this.label1.Tag = "";
			this.label1.Text = "UserEmail:";
			// 
			// Username
			// 
			this.Username.AutoSize = true;
			this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Username.Location = new System.Drawing.Point(390, 84);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(0, 18);
			this.Username.TabIndex = 2;
			this.Username.Tag = "";
			// 
			// txbx_address
			// 
			this.txbx_address.Location = new System.Drawing.Point(30, 28);
			this.txbx_address.Name = "txbx_address";
			this.txbx_address.Size = new System.Drawing.Size(231, 20);
			this.txbx_address.TabIndex = 3;
			// 
			// AddHome
			// 
			this.AddHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.AddHome.FlatAppearance.BorderSize = 0;
			this.AddHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddHome.Location = new System.Drawing.Point(84, 136);
			this.AddHome.Name = "AddHome";
			this.AddHome.Size = new System.Drawing.Size(85, 36);
			this.AddHome.TabIndex = 5;
			this.AddHome.Text = "Add Home";
			this.AddHome.UseVisualStyleBackColor = false;
			this.AddHome.Click += new System.EventHandler(this.AddHome_Click);
			// 
			// txbx_price
			// 
			this.txbx_price.Location = new System.Drawing.Point(33, 95);
			this.txbx_price.Name = "txbx_price";
			this.txbx_price.Size = new System.Drawing.Size(231, 20);
			this.txbx_price.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Address";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Price";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(309, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "HomeCount:";
			// 
			// Count
			// 
			this.Count.AutoSize = true;
			this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Count.Location = new System.Drawing.Point(390, 136);
			this.Count.Name = "Count";
			this.Count.Size = new System.Drawing.Size(0, 16);
			this.Count.TabIndex = 10;
			// 
			// logout_btn
			// 
			this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.logout_btn.FlatAppearance.BorderSize = 0;
			this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logout_btn.Location = new System.Drawing.Point(321, 200);
			this.logout_btn.Name = "logout_btn";
			this.logout_btn.Size = new System.Drawing.Size(85, 36);
			this.logout_btn.TabIndex = 11;
			this.logout_btn.Text = "Logout";
			this.logout_btn.UseVisualStyleBackColor = false;
			this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
			// 
			// administration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 248);
			this.Controls.Add(this.logout_btn);
			this.Controls.Add(this.Count);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txbx_price);
			this.Controls.Add(this.AddHome);
			this.Controls.Add(this.txbx_address);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Email);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "administration";
			this.Text = "administration";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.administration_FormClosed);
			this.Load += new System.EventHandler(this.administration_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Email;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Username;
		private System.Windows.Forms.TextBox txbx_address;
		private System.Windows.Forms.Button AddHome;
		private System.Windows.Forms.TextBox txbx_price;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label Count;
		private System.Windows.Forms.Button logout_btn;
	}
}