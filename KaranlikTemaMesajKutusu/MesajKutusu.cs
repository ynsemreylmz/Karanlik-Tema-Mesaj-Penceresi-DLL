using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaranlikTemaMesajKutusu
{
	public class MesajKutusu
	{
		/// <summary>
		/// Karanlık Tema Mesaj Kutusu
		/// </summary>
		/// <param name="mesaj">Ekranda gösterilecek mesaj</param>
		/// <param name="baslik">Mesaj Başlığı</param>
		/// <param name="buton">Ekranda gösterilmesi istenen butonlar(OK, OKCancel, YesNoCancel, YesNo)</param>
		/// <param name="ikon">Gösterilmesi istenen iconlar(Information, Error, Question)</param>
		/// <returns></returns>
		public static DialogResult MesajGoster(string mesaj, string baslik, MessageBoxButtons buton, MessageBoxIcon ikon)
		{
			DialogResult dlgResault = new DialogResult();

			switch (buton)
			{
				case MessageBoxButtons.OK:
					using (FrmMesajOk msjOK = new FrmMesajOk())
					{
						msjOK.Mesaj = mesaj;
						msjOK.Baslik = baslik;
						switch (ikon)
						{
							case MessageBoxIcon.Information:

								msjOK.MesajIcon = Properties.Resources.bilgi;

								break;
							case MessageBoxIcon.Error:

								msjOK.MesajIcon = Properties.Resources.yasak;

								break;
							case MessageBoxIcon.Warning:

								msjOK.MesajIcon = Properties.Resources.uyari;

								break;
							case MessageBoxIcon.Question:
								msjOK.MesajIcon = Properties.Resources.soru;

								break;

						}
						dlgResault = msjOK.ShowDialog();
					}

					break;
				case MessageBoxButtons.OKCancel:
					using (frmMesajOKCancel msjOKCancel = new frmMesajOKCancel())
					{
						msjOKCancel.Mesaj = mesaj;
						msjOKCancel.Baslik = baslik;
						switch (ikon)
						{
							case MessageBoxIcon.Information:

								msjOKCancel.MesajIcon = Properties.Resources.bilgi;

								break;
							case MessageBoxIcon.Error:

								msjOKCancel.MesajIcon = Properties.Resources.uyari;

								break;
							case MessageBoxIcon.Question:
								msjOKCancel.MesajIcon = Properties.Resources.bilgi;

								break;

						}
						dlgResault = msjOKCancel.ShowDialog();
					}




					break;
				case MessageBoxButtons.YesNoCancel:
					using (FrmYesNoCancel msjYesNoCancel = new FrmYesNoCancel())
					{
						msjYesNoCancel.Mesaj = mesaj;
						msjYesNoCancel.Baslik = baslik;
						switch (ikon)
						{
							case MessageBoxIcon.Information:

								msjYesNoCancel.MesajIcon = Properties.Resources.bilgi;

								break;
							case MessageBoxIcon.Error:

								msjYesNoCancel.MesajIcon = Properties.Resources.uyari;

								break;
							case MessageBoxIcon.Question:
								msjYesNoCancel.MesajIcon = Properties.Resources.bilgi;

								break;

						}
						dlgResault = msjYesNoCancel.ShowDialog();

					}



					break;
				case MessageBoxButtons.YesNo:
					using (FrmMesajYesNo msjYesNo = new FrmMesajYesNo())
					{

						msjYesNo.Mesaj = mesaj;
						msjYesNo.Baslik = baslik;
						switch (ikon)
						{
							case MessageBoxIcon.Information:

								msjYesNo.MesajIcon = Properties.Resources.bilgi;

								break;
							case MessageBoxIcon.Error:

								msjYesNo.MesajIcon = Properties.Resources.uyari;

								break;
							case MessageBoxIcon.Question:
								msjYesNo.MesajIcon = Properties.Resources.bilgi;

								break;

						}
						dlgResault = msjYesNo.ShowDialog();

					}
					break;
				default:
					break;
			}



			return dlgResault;
		}
	}
}
