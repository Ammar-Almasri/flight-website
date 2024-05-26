using Ammarinho_s_Airlines.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ammarinho_s_Airlines
{
    public partial class frmflyammar : Form
    {
        public frmflyammar()
        {
            InitializeComponent();
        }

        private frmBook frm;
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (frm == null || frm.IsDisposed)
            {
                frm = new frmBook();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frm.BringToFront(); // Bring the existing form to the front
            }
        }

        private void postponeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPostpone frmm = new frmPostpone(frm);

            if (frm == null || frm.ticketno == null)
            {
                MessageBox.Show("Error: No booked flights.","تستهبل؟",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                frmm.MdiParent = this;
                frmm.Show();
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelFlight frmm = new frmCancelFlight(frm);

            if (frm == null || frm.ticketno == null)
            {
                MessageBox.Show("Error: No booked flights.", "تستهبل؟", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmm.MdiParent = this;
                frmm.Show();
            }
        }

        private void onlineCheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOnlineCheckin frmm = new frmOnlineCheckin(frm);

            if (frm == null || frm.ticketno == null)
            {
                MessageBox.Show("Error: No booked flights.", "تستهبل؟", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmm.MdiParent = this;
                frmm.Show();
            }
        }
    }
}
