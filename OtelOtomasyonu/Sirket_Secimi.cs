using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class Sirket_Secimi : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = ADEM; Initial Catalog = cyper8; User ID = sa; Password = 1234");
        public Sirket_Secimi()
        {
           
            InitializeComponent();
            this.entityInstantFeedbackSource1.GetQueryable += entityInstantFeedbackSource1_GetQueryable;
           
            this.entityInstantFeedbackSource1.DismissQueryable += entityInstantFeedbackSource1_DismissQueryable;
        }
        #region Entitiy Sorguları

 void entityInstantFeedbackSource1_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {

            // Instantiate a new DataContext
            OtelOtomasyonu.db.cyper8Entities dataContext = new OtelOtomasyonu.db.cyper8Entities();
            // Assign a queryable source to the EntityInstantFeedbackSource
            e.QueryableSource = dataContext.TBL_SIRKET_SECIMI;
            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissQueryable event handler
            e.Tag = dataContext;
        }

        
        void entityInstantFeedbackSource1_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {

            // Dispose of the DataContext
            ((OtelOtomasyonu.db.cyper8Entities)e.Tag).Dispose();
        }

        #endregion
       
        public void Listele()
        {
            
            entityInstantFeedbackSource1.Refresh();
            gridControl1.DataSource = null;
            gridControl1.DataSource = entityInstantFeedbackSource1;
            gridControl1.RefreshDataSource();
        }

        private void textEdithizli_arama_EditValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();
           SqlDataAdapter s1 = new SqlDataAdapter("Select* from TBL_SIRKET_SECIMI",baglanti);
            DataTable dt = new DataTable();
            s1.Fill(dt);
          
            DataView dv = dt.DefaultView;
            dv.RowFilter = "KODU LIKE '" + textEdithizli_arama.Text + "%'";
            gridControl1.DataSource = dv;
            
            gridControl1.RefreshDataSource();
          
            baglanti.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
               textEdithizli_arama.EditValue=   dr[0].ToString();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textEdithizli_arama_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            textEdithizli_arama.Text = "";
        }
    }
}
