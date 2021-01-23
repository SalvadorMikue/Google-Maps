using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Maps
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string street = txtBoxState.Text;
            string city = txtBoxCity.Text;
            string state = txtBoxState.Text;
            string ZipCode = txtBoxZipCode.Text;

            try
            {
                StringBuilder queryData = new StringBuilder();
                queryData.Append("http://maps.google.com/maps?q=");

                if (street!= String.Empty)
                {
                    queryData.Append(street + ", " + " +");
                }
                if (city != string.Empty)
                {
                    queryData.Append(city + ", " + " +");
                }
                if (state != string.Empty)
                {
                    queryData.Append(state + ", " + " +");
                }

                if ( ZipCode != string.Empty)
                {
                    queryData.Append(ZipCode + ", " + "+ ");
                }
                webBrowser1.Navigate(queryData.ToString());
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message.ToString(), "Error");
            }
        }
    }
}
