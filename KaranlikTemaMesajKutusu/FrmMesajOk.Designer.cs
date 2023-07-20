namespace KaranlikTemaMesajKutusu
{
	partial class FrmMesajOk
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
			this.btnOK = new System.Windows.Forms.Button();
			this.lblMesaj = new System.Windows.Forms.Label();
			this.lblBaslik = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pbxOK = new System.Windows.Forms.PictureBox();
			this.pnl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxOK)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl
			// 
			this.pnl.BackColor = System.Drawing.Color.Black;
			this.pnl.Controls.Add(this.btnOK);
			this.pnl.Controls.Add(this.lblMesaj);
			this.pnl.Controls.Add(this.lblBaslik);
			this.pnl.Controls.Add(this.label1);
			this.pnl.Controls.Add(this.pbxOK);
			this.pnl.Location = new System.Drawing.Point(2, 2);
			this.pnl.Name = "pnl";
			this.pnl.Size = new System.Drawing.Size(417, 197);
			this.pnl.TabIndex = 3;
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnOK.Location = new System.Drawing.Point(268, 141);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(125, 45);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "Tamam";
			this.btnOK.UseVisualStyleBackColor = false;
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
			// pbxOK
			// 
			this.pbxOK.BackColor = System.Drawing.Color.Transparent;
			this.pbxOK.Image = global::KaranlikTemaMesajKutusu.Properties.Resources.bilgi;
			this.pbxOK.Location = new System.Drawing.Point(21, 50);
			this.pbxOK.Name = "pbxOK";
			this.pbxOK.Size = new System.Drawing.Size(70, 70);
			this.pbxOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxOK.TabIndex = 0;
			this.pbxOK.TabStop = false;
			// 
			// FrmMesajOk
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(420, 200);
			this.Controls.Add(this.pnl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmMesajOk";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMesajOk";
			this.pnl.ResumeLayout(false);
			this.pnl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxOK)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnl;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblMesaj;
		private System.Windows.Forms.Label lblBaslik;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbxOK;
	}
}