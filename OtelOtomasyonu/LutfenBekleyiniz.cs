using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class LutfenBekleyiniz : Form
    {
        public LutfenBekleyiniz()
        {
            InitializeComponent();
        }

        private void LutfenBekleyiniz_Load(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            timer1.Enabled = true;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            progressBar1.Value = i;
            if(i==100)
            {
                this.Close();
                Sirket_Secimi sc = new Sirket_Secimi();
                sc.ShowDialog();
            }
        }
    }
}
