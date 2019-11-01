using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Globalization;
using System.Resources;
using System.Threading;
using System.Data.Entity;
using System.Data.SqlClient;

namespace OtelOtomasyonu
{
    
    public partial class Giris : Form
    {
       
        SqlConnection baglantim = new SqlConnection(@"Data Source=ADEM;Initial Catalog=cyper8;User ID=sa;Password=1234");
        public Giris(CultureInfo culture)
        {        
            InitializeComponent();
           

            
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

           // ResourceManager r = new ResourceManager("OtelOtomasyonu.Giris",System.Reflection.Assembly.GetExecutingAssembly());

            


            //labelkullanicigirisi.Text = r.GetString("labelkullanicigirisi.Text");
            //checkEditsifrehatirla.Text = r.GetString("checkEditsifrehatirla.Text");
            //btngiris.Text = r.GetString("btngiris.Text");
            //labelsunucuayarlari.Text = r.GetString("labelsunucuayarlari.Text");
            //labelsirketemizle.Text = r.GetString("labelsirketemizle.Text");

        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            
            //for (int i = 1; i < 100; i++)
            //{
            //    Thread.Sleep(100);
            //}

            //this.MinimizeBox = false;
            //this.Icon = new Icon("res/proje.ico");
            //this.ControlBox = false;
            btngiris.Focus();
            
        }
        
        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
           // this.Close();
            

           
        }

        public void dildegistirme()
        {
            ResourceManager r = new ResourceManager("OtelOtomasyonu.Giris", System.Reflection.Assembly.GetExecutingAssembly());
            this.Text = this.Text + "" + DateTime.Now.ToLongDateString();
            if (txtdil.Text == "Türkçe")
            {
                Giris g = new Giris(new CultureInfo("tr-tr"));
                labelkullanicigirisi.Text = r.GetString("labelkullanicigirisi.Text");
                checkEditsifrehatirla.Text = "Şifremi Hatırla";
                btngiris.Text = r.GetString("btngiris.Text");
                labelsunucuayarlari.Text = r.GetString("labelsunucuayarlari.Text");
                labelsirketemizle.Text = r.GetString("labelsirketemizle.Text");
            }
            if (txtdil.Text=="English")
            {
                Giris g = new Giris(new CultureInfo("en-US"));
                labelkullanicigirisi.Text = r.GetString("labelkullanicigirisi.Text");
                checkEditsifrehatirla.Text = "Remember Password";
                btngiris.Text = r.GetString("btngiris.Text");
                labelsunucuayarlari.Text = r.GetString("labelsunucuayarlari.Text");
                labelsirketemizle.Text = r.GetString("labelsirketemizle.Text");
            }
            if (txtdil.Text == "Azəri")
            {
                Giris g = new Giris(new CultureInfo("az-az"));
                labelkullanicigirisi.Text = r.GetString("labelkullanicigirisi.Text");
                checkEditsifrehatirla.Text = "Şifrəmi Xatırla";
                btngiris.Text = r.GetString("btngiris.Text");
                labelsunucuayarlari.Text = r.GetString("labelsunucuayarlari.Text");
                labelsirketemizle.Text = r.GetString("labelsirketemizle.Text");
            }
            if (txtdil.Text == "Pусский")
            {
                Giris g = new Giris(new CultureInfo("ru-ru"));
                labelkullanicigirisi.Text = r.GetString("labelkullanicigirisi.Text");
                checkEditsifrehatirla.Text = "Запомнить мой пароль";
                btngiris.Text = r.GetString("btngiris.Text");
                labelsunucuayarlari.Text = r.GetString("labelsunucuayarlari.Text");
                labelsirketemizle.Text = r.GetString("labelsirketemizle.Text");
            }
            if (txtdil.Text == "Nederlands")
            {
                Giris g = new Giris(new CultureInfo("nl-NL"));
                labelkullanicigirisi.Text = r.GetString("labelkullanicigirisi.Text");
                checkEditsifrehatirla.Text = "Herriner Wachtwoord";
                btngiris.Text = r.GetString("btngiris.Text");
                labelsunucuayarlari.Text = r.GetString("labelsunucuayarlari.Text");
                labelsirketemizle.Text = r.GetString("labelsirketemizle.Text");
            }
            if (txtdil.Text == "Shqip")
            {
                Giris g = new Giris(new CultureInfo("af-ZA"));
                labelkullanicigirisi.Text = r.GetString("labelkullanicigirisi.Text");
                checkEditsifrehatirla.Text = "Keni harruar fjalëkalimin";
                btngiris.Text = r.GetString("btngiris.Text");
                labelsunucuayarlari.Text = r.GetString("labelsunucuayarlari.Text");
                labelsirketemizle.Text = r.GetString("labelsirketemizle.Text");
            }
            if (txtdil.Text == "العربية")
            {
                Giris g = new Giris(new CultureInfo("ar-SA"));
                labelkullanicigirisi.Text = r.GetString("labelkullanicigirisi.Text");
                checkEditsifrehatirla.Text = "تذكر كلمة المرور";
                btngiris.Text = r.GetString("btngiris.Text");
                labelsunucuayarlari.Text = r.GetString("labelsunucuayarlari.Text");
                labelsirketemizle.Text = r.GetString("labelsirketemizle.Text");
            }
            if (txtdil.Text == "Norsk")
            {
                Giris g = new Giris(new CultureInfo("nn-NO"));
                labelkullanicigirisi.Text = r.GetString("labelkullanicigirisi.Text");
                checkEditsifrehatirla.Text = "Husk passord";
                btngiris.Text = r.GetString("btngiris.Text");
                labelsunucuayarlari.Text = r.GetString("labelsunucuayarlari.Text");
                labelsirketemizle.Text = r.GetString("labelsirketemizle.Text");
            }
            if (txtdil.Text == "Deutsch")
            {
                Giris g = new Giris(new CultureInfo("de-DE"));
                labelkullanicigirisi.Text = r.GetString("labelkullanicigirisi.Text");
                checkEditsifrehatirla.Text = "Erinnern Mein Passwort";
                btngiris.Text = r.GetString("btngiris.Text");
                labelsunucuayarlari.Text = r.GetString("labelsunucuayarlari.Text");
                labelsirketemizle.Text = r.GetString("labelsirketemizle.Text");
            }


            

            //if (txtdil.Text == "Türkçe")
            //{
            //    labelkullanicigirisi.Text = "Kullanıcı Girişi";
            //    checkEditsifrehatirla.Text = "Şifremi Hatırla";
            //    btngiris.Text = "Giriş";
            //    labelsunucuayarlari.Text = "Sunucu Ayarları";
            //    labelsirketemizle.Text = "Varsayılan Şirketi Temizle";
            //}
            //if (txtdil.Text=="English")
            //{
            //    labelkullanicigirisi.Text = "User Login";
            //    checkEditsifrehatirla.Text = "Remember Password";
            //    btngiris.Text = "Entry";
            //    labelsunucuayarlari.Text = "Server Settings";
            //    labelsirketemizle.Text = "Clear Default Company";
            //}
            //if (txtdil.Text == "Azəri")
            //{
            //    labelkullanicigirisi.Text = "İstifadəçi Giriş";
            //    checkEditsifrehatirla.Text = "Запомнить мой пароль";
            //    btngiris.Text = "Giriş";
            //    labelsunucuayarlari.Text = "Server Nizamları";
            //    labelsirketemizle.Text = "Fərzedilən Şirkəti Təmizlə";
            //}
            //if (txtdil.Text == "Pусский")
            //{
            //    labelkullanicigirisi.Text = "Логин пользователя";
            //    checkEditsifrehatirla.Text = "Şifrəmi Xatırla";
            //    btngiris.Text = "запись";
            //    labelsunucuayarlari.Text = "Настройки сервера";
            //    labelsirketemizle.Text = "Очистить компанию";
            //}
            //if (txtdil.Text == "Nederlands")
            //{
            //    labelkullanicigirisi.Text = "Inlog Gebruiker";
            //    checkEditsifrehatirla.Text = "Herriner Wachtwoord";
            //    btngiris.Text = "Aankomst";
            //    labelsunucuayarlari.Text = "Serverinstellingen";
            //    labelsirketemizle.Text = "Standaard Onderneming Verschonen";
            //}
            //if (txtdil.Text == "Shqip")
            //{
            //    labelkullanicigirisi.Text = "Hyrje Përdoruesit";
            //    checkEditsifrehatirla.Text = "Keni harruar fjalëkalimin";
            //    btngiris.Text = "Hyrje";
            //    labelsunucuayarlari.Text = "Konfigurimi Serverit";
            //    labelsirketemizle.Text = "Pastoj Kompanit Default";
            //}
            //if (txtdil.Text == "العربية")
            //{
            //    labelkullanicigirisi.Text = "تسجيل دخول المستخدم";
            //    checkEditsifrehatirla.Text = "تذكر كلمة المرور";
            //    btngiris.Text = "دخول";
            //    labelsunucuayarlari.Text = "إعدادات الخادم";
            //    labelsirketemizle.Text = "مسح الشركة الافتراضية";
            //}
            //if (txtdil.Text == "Norsk")
            //{
            //    labelkullanicigirisi.Text = "Brukerinnlogging";
            //    checkEditsifrehatirla.Text = "Husk passord";
            //    btngiris.Text = "inngang";
            //    labelsunucuayarlari.Text = "Server innstillinger";
            //    labelsirketemizle.Text = "Slett standard selskapet";
            //}
            //if (txtdil.Text == "Deutsch")
            //{
            //    labelkullanicigirisi.Text = "Benutzer Eingang";
            //    checkEditsifrehatirla.Text = "Erinnern Mein Passwort";
            //    btngiris.Text = "Entry";
            //    labelsunucuayarlari.Text = "Server-Einstellungen";
            //    labelsirketemizle.Text = "Standard-Firma Klar";
            //}
        }
        private void txtdil_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dildegistirme();

        }
        private void labelsunucuayarlari_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage=xtraTabPage2;
        }

        private void btnsunucugeri_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
        }

        public void giriskontrol()
        {
            using (db.cyper8Entities context = new db.cyper8Entities())
            {
                db.TBL_KULLANICI_GIRIS tb = new db.TBL_KULLANICI_GIRIS();

                var sorgu = (from x in context.TBL_KULLANICI_GIRIS
                            where x.K_ADI == txtkullaniciadi.Text && x.SIFRE == txtsifre.Text
                            select x).SingleOrDefault();
                if(sorgu!=null)
                {
                    LutfenBekleyiniz lb = new LutfenBekleyiniz();
                    lb.Show();
                   
                }
                else
                {
                 DevExpress.XtraEditors.XtraMessageBox.Show("Kullanıcı adı veya Şifreniz yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            
            giriskontrol();
        }
    }
}
