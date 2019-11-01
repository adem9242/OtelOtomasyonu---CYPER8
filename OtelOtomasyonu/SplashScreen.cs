using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace OtelOtomasyonu
{
    public partial class SplashScreen : Form
    {
        
        public SplashScreen()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            Giris f2 = new Giris(new CultureInfo("tr-tr"));
           this.Hide();
           f2.Show();
           timer1.Stop();
        }

       
    }
}
