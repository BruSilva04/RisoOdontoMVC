using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisoOdontoDSKTP
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;

            //Lets get the first day of the month
            DateTime startOftheMonth = new DateTime(now.Year, now.Month, 1);
            //GetAccessibilityObjectById the count of days of the month
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            //Convert the startofthemonth to integer
            int dayoftheWeek = Convert.ToInt32(startOftheMonth.DayOfWeek.ToString("d"));

            //first lets create a blank usercontrol


        }

    }
}
