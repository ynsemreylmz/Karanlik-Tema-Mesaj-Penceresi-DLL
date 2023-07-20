using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaranlikTemaMesajKutusu
{
	public partial class FrmYesNoCancel : Form
	{
		public FrmYesNoCancel()
		{
			InitializeComponent();
		}

		public Image MesajIcon
		{
			get { return pbxYesNoCancel.Image; }
			set { pbxYesNoCancel.Image = value; }
		}

		public string Mesaj
		{
			get { return lblMesaj.Text; }
			set { lblMesaj.Text = value; }
		}

		public string Baslik
		{
			get { return lblBaslik.Text; }
			set { lblBaslik.Text = value; }
		}
	}
}
