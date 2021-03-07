namespace Register.Component
{
	partial class HomeControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.home_address = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.home_seller = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.home_price = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.home_address);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.home_seller);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.home_price);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(-8, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(232, 127);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// home_address
			// 
			this.home_address.AutoSize = true;
			this.home_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.home_address.Location = new System.Drawing.Point(93, 91);
			this.home_address.Name = "home_address";
			this.home_address.Size = new System.Drawing.Size(0, 18);
			this.home_address.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(21, 91);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Address:";
			// 
			// home_seller
			// 
			this.home_seller.AutoSize = true;
			this.home_seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.home_seller.Location = new System.Drawing.Point(73, 51);
			this.home_seller.Name = "home_seller";
			this.home_seller.Size = new System.Drawing.Size(0, 18);
			this.home_seller.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(21, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 18);
			this.label6.TabIndex = 2;
			this.label6.Text = "Seller:";
			// 
			// home_price
			// 
			this.home_price.AutoSize = true;
			this.home_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.home_price.Location = new System.Drawing.Point(73, 16);
			this.home_price.Name = "home_price";
			this.home_price.Size = new System.Drawing.Size(0, 18);
			this.home_price.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(21, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Price:";
			// 
			// HomeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "HomeControl";
			this.Size = new System.Drawing.Size(226, 150);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.Label home_address;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label home_seller;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.Label home_price;
		public System.Windows.Forms.Label label4;
	}
}
