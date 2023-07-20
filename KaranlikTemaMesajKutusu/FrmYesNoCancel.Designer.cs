namespace KaranlikTemaMesajKutusu
{
	partial class FrmYesNoCancel
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
			this.lblMesaj = new System.Windows.Forms.Label();
			this.lblBaslik = new System.Windows.Forms.Label();
			this.pnl = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnYes = new System.Windows.Forms.Button();
			this.btnNo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pbxYesNoCancel = new System.Windows.Forms.PictureBox();
			this.pnl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxYesNoCancel)).BeginInit();
			this.SuspendLayout();
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
			// pnl
			// 
			this.pnl.BackColor = System.Drawing.Color.Black;
			this.pnl.Controls.Add(this.btnCancel);
			this.pnl.Controls.Add(this.btnYes);
			this.pnl.Controls.Add(this.btnNo);
			this.pnl.Controls.Add(this.lblMesaj);
			this.pnl.Controls.Add(this.lblBaslik);
			this.pnl.Controls.Add(this.label1);
			this.pnl.Controls.Add(this.pbxYesNoCancel);
			this.pnl.Location = new System.Drawing.Point(2, 2);
			this.pnl.Name = "pnl";
			this.pnl.Size = new System.Drawing.Size(417, 197);
			this.pnl.TabIndex = 4;
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
			this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYes.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnYes.Location = new System.Drawing.Point(17, 141);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(125, 45);
			this.btnYes.TabIndex = 3;
			this.btnYes.Text = "Evet";
			this.btnYes.UseVisualStyleBackColor = false;
			// 
			// btnNo
			// 
			this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
			this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnNo.Location = new System.Drawing.Point(147, 141);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(125, 45);
			this.btnNo.TabIndex = 4;
			this.btnNo.Text = "Hayır";
			this.btnNo.UseVisualStyleBackColor = false;
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
			// pbxYesNoCancel
			// 
			this.pbxYesNoCancel.BackColor = System.Drawing.Color.Transparent;
			this.pbxYesNoCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxYesNoCancel.Location = new System.Drawing.Point(0, 0);
			this.pbxYesNoCancel.Name = "pbxYesNoCancel";
			this.pbxYesNoCancel.Size = new System.Drawing.Size(417, 197);
			this.pbxYesNoCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxYesNoCancel.TabIndex = 0;
			this.pbxYesNoCancel.TabStop = false;
			// 
			// FrmYesNoCancel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(420, 200);
			this.Controls.Add(this.pnl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmYesNoCancel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmYesNoCancel";
			this.pnl.ResumeLayout(false);
			this.pnl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxYesNoCancel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblMesaj;
		private System.Windows.Forms.Label lblBaslik;
		private System.Windows.Forms.Panel pnl;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnYes;
		private System.Windows.Forms.Button btnNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbxYesNoCancel;
	}
}