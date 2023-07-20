namespace KaranlikTemaMesajKutusu
{
	partial class frmMesajOKCancel
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
			this.pnl = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnYes = new System.Windows.Forms.Button();
			this.lblMesaj = new System.Windows.Forms.Label();
			this.lblBaslik = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pbxOKCancel = new System.Windows.Forms.PictureBox();
			this.pnl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxOKCancel)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl
			// 
			this.pnl.BackColor = System.Drawing.Color.Black;
			this.pnl.Controls.Add(this.btnCancel);
			this.pnl.Controls.Add(this.btnYes);
			this.pnl.Controls.Add(this.lblMesaj);
			this.pnl.Controls.Add(this.lblBaslik);
			this.pnl.Controls.Add(this.label1);
			this.pnl.Controls.Add(this.pbxOKCancel);
			this.pnl.Location = new System.Drawing.Point(2, 2);
			this.pnl.Name = "pnl";
			this.pnl.Size = new System.Drawing.Size(417, 197);
			this.pnl.TabIndex = 5;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCancel.Location = new System.Drawing.Point(277, 141);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(125, 45);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Çıkış";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnYes
			// 
			this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnYes.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYes.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnYes.Location = new System.Drawing.Point(147, 141);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(125, 45);
			this.btnYes.TabIndex = 4;
			this.btnYes.Text = "Tamam";
			this.btnYes.UseVisualStyleBackColor = false;
			// 
			// lblMesaj
			// 
			this.lblMesaj.BackColor = System.Drawing.Color.Transparent;
			this.lblMesaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMesaj.ForeColor = System.Drawing.Color.White;
			this.lblMesaj.Location = new System.Drawing.Point(110, 50);
			this.lblMesaj.Name = "lblMesaj";
			this.lblMesaj.Size = new System.Drawing.Size(283, 70);
			this.lblMesaj.TabIndex = 3;
			this.lblMesaj.Text = "Mesaj";
			this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBaslik
			// 
			this.lblBaslik.BackColor = System.Drawing.Color.Transparent;
			this.lblBaslik.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBaslik.ForeColor = System.Drawing.Color.White;
			this.lblBaslik.Location = new System.Drawing.Point(16, 9);
			this.lblBaslik.Name = "lblBaslik";
			this.lblBaslik.Size = new System.Drawing.Size(390, 27);
			this.lblBaslik.TabIndex = 2;
			this.lblBaslik.Text = "Baslik Cümlesi";
			this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// pbxOKCancel
			// 
			this.pbxOKCancel.BackColor = System.Drawing.Color.Transparent;
			this.pbxOKCancel.Location = new System.Drawing.Point(21, 50);
			this.pbxOKCancel.Name = "pbxOKCancel";
			this.pbxOKCancel.Size = new System.Drawing.Size(70, 70);
			this.pbxOKCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxOKCancel.TabIndex = 0;
			this.pbxOKCancel.TabStop = false;
			// 
			// frmMesajOKCancel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(420, 200);
			this.Controls.Add(this.pnl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMesajOKCancel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmMesajYesCancel";
			this.pnl.ResumeLayout(false);
			this.pnl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxOKCancel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnl;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnYes;
		private System.Windows.Forms.Label lblMesaj;
		private System.Windows.Forms.Label lblBaslik;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbxOKCancel;
	}
}