using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe_Restorant_Yonetim_Sistemi
{

    
    public partial class frmGiris : Form
    {
        public static bool durum;
        public static string kulAdi;
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }


        private void frmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
         
        }

		private void btnKapat_Click_1(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Uygulamadan Çıkmak İstediğine Emin misin?", "Exit", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			if (guna2TextBox1.Text == "")
			{
				MessageBox.Show("Alanları Boş Geçmeyiniz!");
			}
			else if (guna2TextBox2.Text == "")
			{
				MessageBox.Show("Şifreyi Boş Geçmeyiniz!");
			}
			else
			{
				if (kontroller.kullaniciKontrolu(guna2TextBox1.Text, Islemler.MD5eDonustur(guna2TextBox2.Text)) == false)
				{
					MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
				}
				else
				{
					durum = true;
					kulAdi = guna2TextBox1.Text;
					//this.Close();
					frmAna frmAna = new frmAna();
					frmAna.ShowDialog();

				}
			}
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Lütfen uygulama yöneticiniz ile iletişime geçiniz (efepos@efepos.com)");
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Lütfen uygulama yöneticiniz ile iletişime geçiniz (efepos@efepos.com)");
		}
	}
}
